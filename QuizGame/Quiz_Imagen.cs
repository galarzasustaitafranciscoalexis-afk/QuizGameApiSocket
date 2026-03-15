using QuizGame.ClasesAdicionales;
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
    public partial class Quiz_Imagen : Form
    {
        public Quiz_Imagen()
        {
            InitializeComponent();
            mostrarPregunta();

        }

        //Mismo funcionamiento que Quiz_Texto
        void mostrarPregunta()
        {
            Pregunta p = JuegoGlobal.preguntas[JuegoGlobal.indicePreguntaActual];

            pregunta.Pregunta = p.textoPregunta;

            imagen_respuesta1.ImageLocation = p.respuestas[0].rutaImagen;
            imagen_respuesta2.ImageLocation = p.respuestas[1].rutaImagen;
            imagen_respuesta3.ImageLocation = p.respuestas[2].rutaImagen;
            imagen_respuesta4.ImageLocation = p.respuestas[3].rutaImagen;

            imagen_respuesta1.Tag = p.respuestas[0];
            imagen_respuesta2.Tag = p.respuestas[1];
            imagen_respuesta3.Tag = p.respuestas[2];
            imagen_respuesta4.Tag = p.respuestas[3];
        }

        void verificarRespuesta(object sender)
        {
            PictureBox pic = (PictureBox)sender;

            Respuesta r = (Respuesta)pic.Tag;

            if (r.esCorrecta)
            {
                JuegoGlobal.puntaje+= 10;
                MessageBox.Show("Correcto");
            }
            else
                MessageBox.Show("Incorrecto");

            JuegoGlobal.indicePreguntaActual++;

            ControlJuego.mostrarSiguientePregunta(this);
        }

        private void imagen_respuesta1_Click(object sender, EventArgs e)
        {
            verificarRespuesta(sender);
        }

        private void imagen_respuesta2_Click(object sender, EventArgs e)
        {
            verificarRespuesta(sender);
        }

        private void imagen_respuesta3_Click(object sender, EventArgs e)
        {
            verificarRespuesta(sender);
        }

        private void imagen_respuesta4_Click(object sender, EventArgs e)
        {
            verificarRespuesta(sender);
        }
        private void Quiz_Imagen_Load(object sender, EventArgs e)
        {

        }
    }
}
