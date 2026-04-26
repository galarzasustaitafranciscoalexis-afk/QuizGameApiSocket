using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Modelos
{
    public class Pregunta
    {
        [JsonProperty("id_pregunta")]
        public int idPregunta { get; set; }

        [JsonProperty("texto_pregunta")]
        public string textoPregunta { get; set; }

        [JsonProperty("tipo_respuesta")]
        public string tipoRespuesta { get; set; }

        [JsonProperty("respuestas")]
        public List<Respuesta> respuestas { get; set; }
    }
}
