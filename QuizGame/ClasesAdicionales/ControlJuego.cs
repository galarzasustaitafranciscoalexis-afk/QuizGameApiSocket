using QuizGame.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame.ClasesAdicionales
{
    public static class ControlJuego
    {
        //Carga la pantalla corespondiente al tipo de pregunta
        public static void mostrarSiguientePregunta(Form formActual)
        {
            if (JuegoGlobal.indicePreguntaActual >= JuegoGlobal.preguntas.Count)
            {
                MessageBox.Show("Juego terminado\nPuntaje: " + JuegoGlobal.puntaje);

                //Reiniciar variables del juego
                JuegoGlobal.indicePreguntaActual = 0;
                JuegoGlobal.puntaje = 0;
                JuegoGlobal.preguntas.Clear();

                //Menú
                Menu menu = new Menu();
                menu.Show();

                formActual.Close();
                return;
            }

            //Categoria escogida
            Pregunta p = JuegoGlobal.preguntas[JuegoGlobal.indicePreguntaActual];

            Form siguiente;

            //Carga la pantalla adecuada a cada tipo de pregunta
            if (p.tipoRespuesta == "texto")
                siguiente = new Quiz_Texto();
            else
                siguiente = new Quiz_Imagen();

            siguiente.Show();
            formActual.Hide();
        }
    }
}
