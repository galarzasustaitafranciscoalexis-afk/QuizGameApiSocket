using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace QuizGame.Clases
{
    internal class ConexionBD
    {
        MySqlConnection conn;
        public ConexionBD()
        {
            conn = new MySqlConnection("server=localhost;user=root;database=quiz_game;port=3306;password=root;");
        }

        public void recuperarCategoria()
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM categoria";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader["id_categoria"] + " - " + reader["nombre_categoria"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
