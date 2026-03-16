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
        /// <summary>
        /// Retorna una lista de 10 preguntas de una categoria especifica
        /// ordenadas al azar
        /// </summary>
        /// <param name="idCategoriaElegida"></param>
        /// <returns></returns>
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
                    //query para recuperar 10 preguntas de una categoria ordenadas al azar de la base de datos
                    string peticion = @"SELECT id_pregunta, texto_pregunta, tipo_respuesta 
                                        FROM pregunta WHERE id_categoria = @idCat ORDER BY RAND() LIMIT 10;";
                    
                    using(MySqlCommand cmd = new MySqlCommand(peticion, conn))
                    {
                        cmd.Parameters.AddWithValue("@idCat", idCategoriaElegida);

                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //Se crea y ensambla el objeto Pregunta con los datos de la fila actual
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

                    //query para obtener las respuestas asignadas a una pregunta especifica 
                    string peticionRespuestas = @"SELECT id_respuesta, texto_respuesta, ruta_imagen, es_correcta 
                                               FROM respuesta WHERE id_pregunta = @idPreg;";

                    using(MySqlCommand cmdResp = new MySqlCommand(peticionRespuestas, conn))
                    {
                        //Preparacion del parámetro fuera del ciclo para ahorrar memoria
                        cmdResp.Parameters.Add("@idPreg", MySqlDbType.Int32);

                        //recorremos las 10 preguntas para buscar sus respuestas asignadas
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
                                        //manejo seguro de nulos, en caso de que texto_respuesta o ruta_imagen sea null
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
            
            return listaPreguntas;
        }

        /// <summary>
        /// metodo que se encarga de hacer la insercion de los resultados de la partida en la tabla partida_detalles
        /// </summary>
        /// <param name="nuevaPartida"></param>
        /// <returns>Un booleano que representa si se guardo o no la partida en la base de datos</returns>
        public bool guardarPartida(Partida nuevaPartida)
        {
            //bandera para saber si fue exitoso o no el guardado
            bool exito = false;

            using(MySqlConnection conn = new MySqlConnection(connCadena))
            {
                try
                {
                    conn.Open();
                    //inicio de la transaccion atomica
                    using(MySqlTransaction transaccion = conn.BeginTransaction())
                    {
                        try
                        {
                            //query para la insercion en la tabla partida
                            string sqlPartida = @"INSERT INTO partida (id_categoria, puntaje_final, fecha) 
                                                    VALUES (@idCat, @puntaje, @fecha);";

                            //id de la partida que generara MySQL
                            long idPartidaGen = 0;

                            using (MySqlCommand cmdPartida = new MySqlCommand(sqlPartida, conn, transaccion))
                            {
                                cmdPartida.Parameters.AddWithValue("@idCat", nuevaPartida.idCategoria);
                                cmdPartida.Parameters.AddWithValue("@puntaje", nuevaPartida.puntajeFinal);
                                cmdPartida.Parameters.AddWithValue("@fecha", nuevaPartida.fecha);

                                //Ejecuta la inserción de la partida
                                cmdPartida.ExecuteNonQuery();
                                //Recupera el id autoincremental recién creado para ligarlo a sus detalles
                                idPartidaGen = cmdPartida.LastInsertedId;
                            }

                            //query para la inserción en la tabla hija partida_detalle
                            string sqlDetalle = @"INSERT INTO partida_detalle (id_partida, id_pregunta, fue_correcta) 
                                                  VALUES (@idPartida, @idPregunta, @fueCorrecta);";

                            using (MySqlCommand cmdDetalle = new MySqlCommand(sqlDetalle, conn, transaccion))
                            {
                                //Definicion de los tipos de parámetros
                                cmdDetalle.Parameters.Add("@idPartida", MySqlDbType.Int32);
                                cmdDetalle.Parameters.Add("@idPregunta", MySqlDbType.Int32);
                                cmdDetalle.Parameters.Add("@fueCorrecta", MySqlDbType.Byte);

                                //Iteramos sobre la lista de respuestas que el jugador acumuló
                                foreach (PartidaDetalle detalle in nuevaPartida.detalles)
                                {
                                    //Vinculamos cada detalle con la partida que acabamos de insertar
                                    cmdDetalle.Parameters["@idPartida"].Value = idPartidaGen;
                                    cmdDetalle.Parameters["@idPregunta"].Value = detalle.idPregunta;
                                    cmdDetalle.Parameters["@fueCorrecta"].Value = detalle.fueCorrecta ? 1:0;

                                    //Ejecuta la inserción del detalle individual
                                    cmdDetalle.ExecuteNonQuery();
                                }
                            }
                            //Si el codigo llega hasta aqui, no hubo ningun error y se guardan los cambios
                            transaccion.Commit();
                            //Actualizamos la bandera
                            exito = true;
                        }
                        catch(MySqlException)
                        {
                            //en caso de algun error, hacemos rollback para deshacer cualquier cambio pendiente 
                            transaccion.Rollback();
                        }
                    }
                }catch(MySqlException e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            return exito;
        }
       
    }
}
