using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Modelos
{
    public class Respuesta
    {
        [JsonProperty("id_respuesta")]
        public int idRespuesta { get; set; }

        [JsonProperty("texto_respuesta")]
        public string textoRespuesta { get; set; }

        [JsonProperty("ruta_imagen")]
        public string rutaImagen { get; set; }

        [JsonProperty("es_correcta")]
        public bool esCorrecta { get; set; }
    }
}
