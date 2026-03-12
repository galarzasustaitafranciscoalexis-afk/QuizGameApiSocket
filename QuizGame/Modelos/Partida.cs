using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Modelos
{
    internal class Partida
    {
        public int idPartida { get; set; } 
        public int idCategoria { get; set; } // llave foranea
        public int puntajeFinal { get; set; }
        public DateTime fecha { get; set; }
        public List<PartidaDetalle> detalles { get; set; } = new List<PartidaDetalle>();
    }
}
