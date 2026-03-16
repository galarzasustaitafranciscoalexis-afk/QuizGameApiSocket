using QuizGame.Clases_base_datos;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        void iniciarJuego(int categoria)
        {
            ConexionBD db = new ConexionBD();

            JuegoGlobal.categoriaActual = categoria;

            JuegoGlobal.preguntas = db.preguntasAleatorias(categoria);

            //Verificacion de las preguntas cargadas con sus respuestas 
            foreach (Pregunta p in JuegoGlobal.preguntas)
            {
                Console.WriteLine("Pregunta: " + p.textoPregunta);

                foreach (Respuesta r in p.respuestas)
                {
                    Console.WriteLine("   Respuesta: " + r.textoRespuesta +
                                      " Correcta: " + r.esCorrecta);
                }
            }

            //Inicializacion de las variables globales (poscion de la pregunta en el arreglo y puntuacion)
            JuegoGlobal.indicePreguntaActual = 0;

            JuegoGlobal.puntaje = 0;

            ControlJuego.mostrarSiguientePregunta(this);
        }


        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_cat1_Click_1(object sender, EventArgs e)
        {
            //Eleccion de categoria
            iniciarJuego(1);
        }

        private void btn_cat2_Click_1(object sender, EventArgs e)
        {
            //Eleccion de categoria
            iniciarJuego(2);
        }

        private void btn_cat3_Click_1(object sender, EventArgs e)
        {
            //Eleccion de categoria
            iniciarJuego(3);
        }

        private void btn_cat4_Click_1(object sender, EventArgs e)
        {
            //Eleccion de categoria
            iniciarJuego(4);
        }

        private void btn_cat5_Click_1(object sender, EventArgs e)
        {
            //Eleccion de categoria
            iniciarJuego(5);
        }
    }
}
