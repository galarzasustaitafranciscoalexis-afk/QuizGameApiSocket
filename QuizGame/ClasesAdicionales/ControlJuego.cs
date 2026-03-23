using QuizGame.Clases_base_datos;
using QuizGame.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizGame.ClasesAdicionales;

namespace QuizGame.ClasesAdicionales
{
    public static class ControlJuego
    {
        //Carga la pantalla corespondiente al tipo de pregunta
        public static void mostrarSiguientePregunta(Form formActual)
        {
            //juego terminado
            if (JuegoGlobal.indicePreguntaActual >= JuegoGlobal.preguntas.Count)
            {
                //  ===================================================
                //  Guardar la partida y sus detalles en la base de datos
                //  ====================================================
                Partida partidaTerminada = new Partida();
                partidaTerminada.idCategoria = JuegoGlobal.categoriaActual;
                partidaTerminada.puntajeFinal = JuegoGlobal.puntaje;
                partidaTerminada.fecha = DateTime.Now;
                partidaTerminada.detalles = JuegoGlobal.detallesAcumulados;

                ConexionBD db = new ConexionBD();
                if (!db.guardarPartida(partidaTerminada))
                {
                    MessageBox.Show("Hubo un problema al guardar el resultado en la base de datos., " +
                        "Error de conexión");
                }

                //Limpiar los arreglos de la partida (Lista de preguntas y lista de historial), quitar message box

                // Mostrar ventana de estadísticas
                Estadisticas stats = new Estadisticas();
                stats.StartPosition = FormStartPosition.Manual;
                stats.Bounds = formActual.Bounds;

                stats.Show();

                // Cerrar formulario actual
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

            siguiente.StartPosition = FormStartPosition.Manual;
            siguiente.Bounds = formActual.Bounds;

            siguiente.Show();
            formActual.Hide();
        }
    }
}
