using QuizGame.ClasesAdicionales;
using QuizGame.ControlesPersonalizados;
using QuizGame.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class Quiz_Texto : Form
    {
        int tiempo;
        bool respuesta;

        public Quiz_Texto()
        {
            InitializeComponent();
            tiempo = 10;
            respuesta = false;
            //ConexionGlobal.Cliente.OnPreguntasRecibidas += MostrarPreguntas;
            mostrarPregunta();
            TiempoEspera.Start();
        }
        //Metodo para cargar las preguntas y respuestas a sus respectivos contenedores
        void mostrarPregunta()
        {
            if (JuegoGlobal.preguntas == null || JuegoGlobal.preguntas.Count == 0)
                return;

            if (JuegoGlobal.indicePreguntaActual >= JuegoGlobal.preguntas.Count)
                return;

            Pregunta p = JuegoGlobal.preguntas[JuegoGlobal.indicePreguntaActual];

            //Mostrar texto pregunta
            pregunta.Pregunta = p.textoPregunta;

            //Asignar respuestas a botones
            if (p.respuestas != null && p.respuestas.Count >= 4)
            {
                btn_respuesta1.Text = p.respuestas[0].textoRespuesta;
                btn_respuesta2.Text = p.respuestas[1].textoRespuesta;
                btn_respuesta3.Text = p.respuestas[2].textoRespuesta;
                btn_respuesta4.Text = p.respuestas[3].textoRespuesta;

                // Guardar respuesta en Tag
                btn_respuesta1.Tag = p.respuestas[0];
                btn_respuesta2.Tag = p.respuestas[1];
                btn_respuesta3.Tag = p.respuestas[2];
                btn_respuesta4.Tag = p.respuestas[3];
            }
        }

        //Verificar la respuesta
        void verificarRespuesta(object sender)
        {
            respuesta = true;
            lbEsperando.Visible = true;
            bloquearBotones();
            Button boton = (Button)sender;
            Respuesta r = (Respuesta)boton.Tag;

            if (r.esCorrecta)
                JuegoGlobal.puntaje += 10;

            PartidaDetalle detalle = new PartidaDetalle();
            detalle.idPregunta = JuegoGlobal.preguntas[JuegoGlobal.indicePreguntaActual].idPregunta;
            detalle.fueCorrecta = r.esCorrecta;
            JuegoGlobal.detallesAcumulados.Add(detalle);

           
        }


        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_respuesta1_Click_1(object sender, EventArgs e)
        {
            //Informacion de oton presionado
            verificarRespuesta(sender);
        }

        private void btn_respuesta2_Click_1(object sender, EventArgs e)
        {
            //Informacion de oton presionado
            verificarRespuesta(sender);
        }

        private void btn_respuesta3_Click_1(object sender, EventArgs e)
        {
            //Informacion de oton presionado
            verificarRespuesta(sender);
        }

        private void btn_respuesta4_Click_1(object sender, EventArgs e)
        {
            //Informacion de oton presionado
            verificarRespuesta(sender);
        }

        private void MostrarPreguntas(List<Pregunta> preguntas)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => MostrarPreguntas(preguntas)));
                return;
            }

            Console.WriteLine("===== PREGUNTAS RECIBIDAS =====");

            foreach (Pregunta p in preguntas)
            {
                Console.WriteLine("ID: " + p.idPregunta);
                Console.WriteLine("Pregunta: " + p.textoPregunta);
                Console.WriteLine("Tipo: " + p.tipoRespuesta);

                Console.WriteLine("Respuestas:");

                foreach (Respuesta r in p.respuestas)
                {
                    Console.WriteLine(" - " + r.textoRespuesta +
                                      " | Correcta: " + r.esCorrecta);
                }

                Console.WriteLine("--------------------------------");
            }

            // Guardar preguntas
            JuegoGlobal.preguntas = preguntas;
            JuegoGlobal.indicePreguntaActual = 0;

            //mostrarPregunta();
        }

        private void TiempoEspera_Tick(object sender, EventArgs e)
        {
            tiempo--;
            lbContador.Text = tiempo.ToString();

            if (tiempo == 0)
            {
                TiempoEspera.Stop();
                if (respuesta == false)
                {
                    PartidaDetalle detalle = new PartidaDetalle();
                    detalle.idPregunta = JuegoGlobal.preguntas[JuegoGlobal.indicePreguntaActual].idPregunta;
                    detalle.fueCorrecta = false;
                    JuegoGlobal.detallesAcumulados.Add(detalle);
                }
                JuegoGlobal.indicePreguntaActual++;
                this.Close();
                ControlJuego.mostrarSiguientePregunta(this);

            }
           
        }

        void bloquearBotones()
        {
            btn_respuesta1.Enabled = false;
            btn_respuesta2.Enabled = false;
            btn_respuesta3.Enabled = false;
            btn_respuesta4.Enabled = false;
        }
    }
}
