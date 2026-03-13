using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Modelos
{
    internal class PartidaDetalle
    {
        public int idPartidaDetalle { get; set; }
        public int idPartida { get; set; } // llave foranea
        public int idPregunta { get; set; } // llave foranea
        public bool fueCorrecta { get; set; } //
    }
}
