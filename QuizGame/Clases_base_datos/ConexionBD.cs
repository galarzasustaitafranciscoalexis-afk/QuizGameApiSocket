using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using QuizGame.Modelos;

namespace QuizGame.Clases_base_datos
{
    internal class ConexionBD
    {
        private string connCadena;

        public ConexionBD()
        {
            connCadena = "server=localhost;user=root;database=quiz_game;port=3306;password=root;";
        }
        //retorna una lista de preguntas ordenadas al azar
        public List<Pregunta> preguntasAleatorias(int idCategoriaElegida)
        {
            //lista para guardar las 10 preguntas
            List<Pregunta> listaPreguntas = new List<Pregunta>();

            //using se asegura de cerrar la conexion y liberar recursos
            using (MySqlConnection conn = new MySqlConnection(connCadena))
            {
                try
                {
                    conn.Open();
                    string peticion = @"SELECT id_pregunta, texto_pregunta, tipo_respuesta 
                                        FROM pregunta WHERE id_categoria = @idCat ORDER BY RAND() LIMIT 10;";
                    
                    using(MySqlCommand cmd = new MySqlCommand(peticion, conn))
                    {
                        cmd.Parameters.AddWithValue("@idCat", idCategoriaElegida);

                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Pregunta nuevaPregunta = new Pregunta
                                {
                                    idPregunta = Convert.ToInt32(reader["id_pregunta"]),
                                    idCategoria = idCategoriaElegida,
                                    textoPregunta = reader["texto_pregunta"].ToString(),
                                    tipoRespuesta = reader["tipo_respuesta"].ToString()
                                };
                                //agrega la pregunta seleccionada a la lista
                                listaPreguntas.Add(nuevaPregunta);
                            }
                        }
                    }

                    string peticionRespuestas = @"SELECT id_respuesta, texto_respuesta, ruta_imagen, es_correcta 
                                               FROM respuesta WHERE id_pregunta = @idPreg;";

                    using(MySqlCommand cmdResp = new MySqlCommand(peticionRespuestas, conn))
                    {
                        cmdResp.Parameters.Add("@idPreg", MySqlDbType.Int32);

                        foreach(Pregunta preguntaActual in listaPreguntas)
                        {
                            cmdResp.Parameters["@idPreg"].Value = preguntaActual.idPregunta;

                            using(MySqlDataReader readerResp = cmdResp.ExecuteReader())
                            {
                                while (readerResp.Read())
                                {
                                    Respuesta nuevaRespuesta = new Respuesta
                                    {
                                        idRespuesta = Convert.ToInt32(readerResp["id_respuesta"]),
                                        idPregunta = preguntaActual.idPregunta,
                                        //manejo de nulos
                                        textoRespuesta = readerResp["texto_respuesta"] != DBNull.Value ?
                                                        readerResp["texto_respuesta"].ToString() : null,

                                        rutaImagen = readerResp["ruta_imagen"] != DBNull.Value ? readerResp["ruta_imagen"].ToString() : null,
                                        esCorrecta = Convert.ToBoolean(readerResp["es_correcta"])
                                    };

                                    //agregar la respuesta a la pregunta actual
                                    preguntaActual.respuestas.Add(nuevaRespuesta);
                                }
                            }
                        }
                    }

                }catch(MySqlException e)
                {
                    MessageBox.Show("Error al cargar las preguntas" + e.Message);
                }
            }
            //se encarga de ordenar al azar las preguntas de la lista
            //listaPreguntas = listaPreguntas.OrderBy(x => Guid.NewGuid()).ToList();
            return listaPreguntas;
        }
       
    }
}
