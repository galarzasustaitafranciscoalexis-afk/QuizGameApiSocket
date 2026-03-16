using QuizGame.ClasesAdicionales;
using QuizGame.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            //string ruta1 = Application.StartupPath + "\\" + p.respuestas[0].rutaImagen;
            //string ruta = Path.Combine(Application.StartupPath, p.respuestas[0].rutaImagen);
            //MessageBox.Show(ruta);

            imagen_respuesta1.Image = Image.FromFile(Path.Combine(Application.StartupPath, p.respuestas[0].rutaImagen));
            imagen_respuesta2.Image = Image.FromFile(Path.Combine(Application.StartupPath, p.respuestas[1].rutaImagen));
            imagen_respuesta3.Image = Image.FromFile(Path.Combine(Application.StartupPath, p.respuestas[2].rutaImagen));
            imagen_respuesta4.Image = Image.FromFile(Path.Combine(Application.StartupPath, p.respuestas[3].rutaImagen));

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
                JuegoGlobal.puntaje+= 10;

            //  =========================================================================
            //  Guardar el detalle de esta pregunta para la insercion en la base de datos
            //  =========================================================================
            PartidaDetalle detalle = new PartidaDetalle();
            detalle.idPregunta = JuegoGlobal.preguntas[JuegoGlobal.indicePreguntaActual].idPregunta;
            detalle.fueCorrecta = r.esCorrecta;
            JuegoGlobal.detallesAcumulados.Add(detalle);

            JuegoGlobal.indicePreguntaActual++;

            ControlJuego.mostrarSiguientePregunta(this);
        }

        private void Quiz_Imagen_Load(object sender, EventArgs e)
        {

        }

        private void imagen_respuesta1_Click_1(object sender, EventArgs e)
        {
            verificarRespuesta(sender);
        }

        private void imagen_respuesta2_Click_1(object sender, EventArgs e)
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
    }
}
