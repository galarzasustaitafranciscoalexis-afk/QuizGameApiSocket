using Newtonsoft.Json;
using QuizGame.ClasesAdicionales;
using QuizGame.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame.ServicioSocket
{
    public class ClienteSocket
    {
        private TcpClient cliente;
        private NetworkStream stream;
        private Thread hiloEscucha;

        public event Action<List<Pregunta>> OnPreguntasRecibidas;

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

                //Cliente esperando respuesta
                hiloEscucha = new Thread(EscucharServidor);
                hiloEscucha.IsBackground = true;
                hiloEscucha.Start();

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

        //Esperando respuesta Hilo
        private void EscucharServidor()
        {
            byte[] buffer = new byte[4096];
            StringBuilder data = new StringBuilder();

            while (true)
            {
                try
                {
                    int bytes = stream.Read(buffer, 0, buffer.Length);

                    if (bytes == 0) break;

                    string recibido = Encoding.UTF8.GetString(buffer, 0, bytes);
                    Console.WriteLine("Recibido: " + recibido);

                    data.Append(recibido);

                    string contenido = data.ToString();

                    while (contenido.Contains("\n"))
                    {
                        int index = contenido.IndexOf('\n');
                        string mensaje = contenido.Substring(0, index).Trim();

                        if (!string.IsNullOrWhiteSpace(mensaje))
                            ProcesarMensaje(mensaje);

                        contenido = contenido.Substring(index + 1);
                    }

                    data.Clear();
                    data.Append(contenido); // guarda lo incompleto
                }
                catch
                {
                    break;
                }
            }
        }


        //Conversion del json
        private void ProcesarMensaje(string mensaje)
        {
            try
            {
                mensaje = mensaje.Trim();

                // 🔹 Detectar si es JSON
                if (mensaje.StartsWith("{"))
                {
                    var respuesta = JsonConvert.DeserializeObject<RespuestaServidor>(mensaje);

                    if (respuesta.comando == "PREGUNTAS")
                    {
                        var preguntas = JsonConvert.DeserializeObject<List<Pregunta>>(respuesta.datos.ToString());

                        string texto = "";

                        foreach (Pregunta p in preguntas)
                        {
                            texto += "Pregunta: " + p.textoPregunta + "\n\n";

                            foreach (Respuesta r in p.respuestas)
                            {
                                texto += "- " + r.textoRespuesta + "\n";
                            }

                            texto += "\n---------------------\n";
                        }

                        MessageBox.Show(texto, "Preguntas Recibidas");

                        OnPreguntasRecibidas?.Invoke(preguntas);
                    }

                    else if (respuesta.comando == "USUARIO_REGISTRADO")
                    {
                        int idUsuario = respuesta.id_usuario;
                        UsuarioGlobal.idUsuario = idUsuario;

                        MessageBox.Show("Usuario registrado con ID: " + idUsuario);
                    }
                }
                else
                {
                    // 🔹 Mensajes tipo texto plano
                    if (mensaje.StartsWith("USUARIO_REGISTRADO:"))
                    {
                        string idStr = mensaje.Split(new char[] { ':' }, 2)[1];
                        int idUsuario = int.Parse(idStr);

                        UsuarioGlobal.idUsuario = idUsuario;

                        MessageBox.Show("Usuario registrado con ID: " + idUsuario);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error procesando mensaje: " + ex.Message);
            }
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

    //Clase extra para correcto funcionamiento
        public class RespuestaServidor
        {
            internal int id_usuario;

            public string comando { get; set; }
            public object datos { get; set; }
        }
    }
}