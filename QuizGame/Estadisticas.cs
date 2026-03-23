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
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            Estadistica.Paint += DibujarEstadisticas;
        }

        private void DibujarEstadisticas(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int y = 10;
            int margenX = 10;
            int anchoMax = Estadistica.Width - 20;

            Font tituloFont = new Font("Arial", 12, FontStyle.Bold);
            Font textoFont = new Font("Arial", 10);

            g.DrawString("Correctas:", tituloFont, Brushes.Purple, margenX, y);
            y += 30;

            foreach (var detalle in JuegoGlobal.detallesAcumulados)
            {
                if (detalle.fueCorrecta)
                {
                    var pregunta = JuegoGlobal.preguntas
                        .FirstOrDefault(p => p.idPregunta == detalle.idPregunta);

                    if (pregunta != null)
                    {
                        SizeF size = g.MeasureString(pregunta.textoPregunta, textoFont, anchoMax);

                        g.DrawString("• " + pregunta.textoPregunta,
                            textoFont,
                            Brushes.Black,
                            new RectangleF(margenX + 10, y, anchoMax, size.Height));

                        y += (int)size.Height + 5;
                    }
                }
            }

            y += 20;

            g.DrawString("Incorrectas:", tituloFont, Brushes.Purple, margenX, y);
            y += 30;

            foreach (var detalle in JuegoGlobal.detallesAcumulados)
            {
                if (!detalle.fueCorrecta)
                {
                    var pregunta = JuegoGlobal.preguntas
                        .FirstOrDefault(p => p.idPregunta == detalle.idPregunta);

                    if (pregunta != null)
                    {
                        SizeF size = g.MeasureString(pregunta.textoPregunta, textoFont, anchoMax);

                        g.DrawString("• " + pregunta.textoPregunta,
                            textoFont,
                            Brushes.Black,
                            new RectangleF(margenX + 10, y, anchoMax, size.Height));

                        y += (int)size.Height + 5;
                    }
                }
            }
    
            y += 30;

            Font puntajeFont = new Font("Arial", 14, FontStyle.Bold);
            string textoPuntaje = "Puntaje Final: " + JuegoGlobal.puntaje;
            SizeF sizePuntaje = g.MeasureString(textoPuntaje, puntajeFont);
            float xCentro = (Estadistica.Width - sizePuntaje.Width) / 2;
            g.DrawString(textoPuntaje, puntajeFont, Brushes.DarkBlue, xCentro, y);
        }

        private void btn_cat1_Click(object sender, EventArgs e)
        {
            JuegoGlobal.indicePreguntaActual = 0;
            JuegoGlobal.puntaje = 0;
            JuegoGlobal.preguntas.Clear();
            JuegoGlobal.detallesAcumulados.Clear();

            Menu menu = new Menu();
            menu.Show();

            this.Close();
        }
    }
}
