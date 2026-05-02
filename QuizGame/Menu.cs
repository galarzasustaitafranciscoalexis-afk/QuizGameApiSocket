using QuizGame;
using QuizGame.Clases_base_datos;
using QuizGame.ClasesAdicionales;
using QuizGame.Modelos;
using QuizGame.ServicioSocket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class Menu : Form
    {
        int puntos = 0;
        string texto = "Esperando a los demas jugadores";

        public Menu()
        {
            InitializeComponent();
            MessageBox.Show("Id usurario: " + UsuarioGlobal.idUsuario);
            ConexionGlobal.Cliente.OnPreguntasRecibidas += MostrarPreguntas;
            //MessageBox.Show(UsuarioGlobal.idUsuario.ToString());
            //VerificaHost();
            timer.Start();
        }

      

        private void Menu_Load(object sender, EventArgs e)
        {
            ConexionGlobal.Cliente.Enviar("PARTIDA_INICIADA");
        }

        private void btn_cat1_Click_1(object sender, EventArgs e)
        {
            //Eleccion de categoria
            //iniciarJuego(1);
            ConexionGlobal.Cliente.Enviar("INICIAR_PARTIDA:" + 1);
        }

        private void btn_cat2_Click_1(object sender, EventArgs e)
        {
            //Eleccion de categoria
            //iniciarJuego(2);
            ConexionGlobal.Cliente.Enviar("INICIAR_PARTIDA:" + 2);
        }

        private void btn_cat3_Click_1(object sender, EventArgs e)
        {
            //Eleccion de categoria
            //iniciarJuego(3);
            ConexionGlobal.Cliente.Enviar("INICIAR_PARTIDA:" + 3);
        }

        private void btn_cat4_Click_1(object sender, EventArgs e)
        {
            //Eleccion de categoria
            //iniciarJuego(4);
            ConexionGlobal.Cliente.Enviar("INICIAR_PARTIDA:" + 4);
        }

        private void btn_cat5_Click_1(object sender, EventArgs e)
        {
            //Eleccion de categoria
            //iniciarJuego(5);
            ConexionGlobal.Cliente.Enviar("INICIAR_PARTIDA:" + 5);
        }

        private void MostrarPreguntas(List<Pregunta> preguntas)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => MostrarPreguntas(preguntas)));
                return;
            }

            JuegoGlobal.preguntas = preguntas;
            JuegoGlobal.indicePreguntaActual = 0;

            this.Hide();

            if (preguntas[0].tipoRespuesta == "texto")
            {
                Quiz_Texto qt = new Quiz_Texto();
                qt.Show();
            }
            else
            {
                Quiz_Imagen qi = new Quiz_Imagen();
                qi.Show();
            }
        }

        void VerificaHost()
        {

            if (UsuarioGlobal.EsHost == false)
            {
                lbEstado.Text = "El host esta eligiendo categoria";
                BloquearBotones();
            }
            else
            {
                lbEstado.Visible= false;
            }
        }

        void BloquearBotones()
        {
            btn_cat1.Enabled = false;
            btn_cat2.Enabled = false;
            btn_cat3.Enabled = false;
            btn_cat4.Enabled = false;
            btn_cat5.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (UsuarioGlobal.EsHost == false)
            {
                lbEstado.Visible = true;
                BloquearBotones();
                timer.Stop(); 
            }

        }
    }
}
