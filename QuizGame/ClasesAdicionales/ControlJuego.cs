using Newtonsoft.Json;
using QuizGame.Clases_base_datos;
using QuizGame.ClasesAdicionales;
using QuizGame.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            //juego terminado
            if (JuegoGlobal.indicePreguntaActual >= JuegoGlobal.preguntas.Count)
            {

                var partidaFinal = new
                {
                    comando = "FINALIZAR_PARTIDA",
                    id_partida = JuegoGlobal.idPartida,
                    id_usuario = UsuarioGlobal.idUsuario,
                    puntaje_final = JuegoGlobal.puntaje,

                    detalles = JuegoGlobal.detallesAcumulados.Select(d => new
                    {
                        id_pregunta = d.idPregunta,
                        fue_correcta = d.fueCorrecta
                    }).ToList()
                };

                string jsonPartida = JsonConvert.SerializeObject(partidaFinal);
                ConexionGlobal.Cliente.Enviar(jsonPartida + "\n");

                Ganadores podio = new Ganadores();
                podio.StartPosition = FormStartPosition.Manual;
                podio.Bounds = formActual.Bounds;

                podio.Show();

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
