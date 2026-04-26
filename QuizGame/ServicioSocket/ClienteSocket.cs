using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace QuizGame.ModelosSocket
{
    public class ClienteSocket
    {
        private TcpClient cliente;
        private NetworkStream stream;

        public bool Conectar()
        {
            try
            {
                string ipServidor = BuscarServidor();

                if (ipServidor == null)
                    return false;

                cliente = new TcpClient();
                cliente.Connect(ipServidor, 5000);

                stream = cliente.GetStream();

                return true;
            }
            catch
            {
                return false;
            }
        }

        private string BuscarServidor()
        {
            try
            {
                UdpClient udp = new UdpClient();
                udp.EnableBroadcast = true;

                byte[] data = Encoding.UTF8.GetBytes("QUIZ_GAME_SERVIDOR");

                udp.Send(data, data.Length,
                    new IPEndPoint(IPAddress.Broadcast, 5000));

                udp.Client.ReceiveTimeout = 3000;

                IPEndPoint remote = new IPEndPoint(IPAddress.Any, 0);

                byte[] respuesta = udp.Receive(ref remote);

                string texto = Encoding.UTF8.GetString(respuesta);

                if (texto == "AQUI_ESTOY")
                    return remote.Address.ToString();

                return null;
            }
            catch
            {
                return null;
            }
        }

        public bool Enviar(string mensaje)
        {
            byte[] data = Encoding.UTF8.GetBytes(mensaje + "\n");
            stream.Write(data, 0, data.Length);
            return true;
        }

        public string Recibir()
        {
            try
            {
                byte[] data = new byte[1024];
                int bytes = stream.Read(data, 0, data.Length);

                return Encoding.UTF8.GetString(data, 0, bytes);
            }
            catch
            {
                return "";
            }
        }

        public void Cerrar()
        {
            if (stream != null)
                stream.Close();

            if (cliente != null)
                cliente.Close();
        }
    }
}