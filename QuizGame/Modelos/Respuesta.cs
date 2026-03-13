using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Modelos
{
    internal class Respuesta
    {
        public int idRespuesta { get; set; }
        public int idPregunta { get; set; } // llave foranea
        public string textoRespuesta { get; set; }
        public string rutaImagen { get; set; }
        public bool esCorrecta { get; set; }
    }
}
