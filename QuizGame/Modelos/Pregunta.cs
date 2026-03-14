using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Modelos
{
    public class Pregunta
    {
        public int idPregunta { get; set; }
        public int idCategoria { get; set; }
        public string textoPregunta { get; set; }
        public string tipoRespuesta { get; set; } // texto o imagen

        public List<Respuesta> respuestas { get; set; } = new List<Respuesta>();
    }
}
