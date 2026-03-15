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
        public Quiz_Texto()
        {
            InitializeComponent();
            mostrarPregunta();

        }
        //Metodo para cargar las preguntas y respuestas a sus respectivos contenedores
        void mostrarPregunta()
        {
            //Arreglo vacio?
            if (JuegoGlobal.preguntas.Count == 0)
                return;

            //Obtener las preguntas de un indice
            Pregunta p = JuegoGlobal.preguntas[JuegoGlobal.indicePreguntaActual];

            //Mostrar la pregunta en pantalla
            pregunta.Pregunta = p.textoPregunta;
            
            //MessageBox.Show("Respuestas: " + p.respuestas.Count); Comprobacion de respuestas cargadas por pregunta

            //Aisiganar las respuestas a los botones
            if (p.respuestas.Count >= 4)
            {
                btn_respuesta1.Text = p.respuestas[0].textoRespuesta;
                btn_respuesta2.Text = p.respuestas[1].textoRespuesta;
                btn_respuesta3.Text = p.respuestas[2].textoRespuesta;
                btn_respuesta4.Text = p.respuestas[3].textoRespuesta;

                //Guarda informacion de la respuesta seleccionada
                btn_respuesta1.Tag = p.respuestas[0];
                btn_respuesta2.Tag = p.respuestas[1];
                btn_respuesta3.Tag = p.respuestas[2];
                btn_respuesta4.Tag = p.respuestas[3];
            }
        }

        //Verificar la respuesta
        void verificarRespuesta(object sender)
        {
            //Boton presionado (cast) 
            Button boton = (Button)sender;

            //Informacion de la respuesta (texto_respuesta, es_correcta)
            Respuesta r = (Respuesta)boton.Tag;

            //Puntaje 
            if (r.esCorrecta) 
                JuegoGlobal.puntaje+= 10;

            //Avanzar a la siguiente pregunta
            JuegoGlobal.indicePreguntaActual++;

            //Llamada al formulario imagen o texto
            ControlJuego.mostrarSiguientePregunta(this);
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
    }
}
