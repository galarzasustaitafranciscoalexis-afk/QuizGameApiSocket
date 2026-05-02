using QuizGame.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.ClasesAdicionales
{
    public static class JuegoGlobal
    {
        //Lista simple de preguntas
        public static List<Pregunta> preguntas = new List<Pregunta>();
        //Guarda id_pregunta, id_categoria,textp_pregunta, tipo-respuesta

        //Pocision de pregunta del arreglo
        public static int indicePreguntaActual = 0;

        //Puntaje
        public static int puntaje = 0;

        //Id de categoria escogida
        public static int categoriaActual = 0;
        
        //lista para el historial de partida
        public static List<PartidaDetalle> detallesAcumulados = new List<PartidaDetalle>();

        //Guarda id_detalle, id_partida, id_pregunta, fue_correcta
        public static int idPartida=0;
    }
}
