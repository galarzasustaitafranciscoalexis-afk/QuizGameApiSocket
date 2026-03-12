using QuizGame.Clases_base_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //
            //eliminar esta parte despues de probar la conexion a la base de datos
            ConexionBD conexion = new ConexionBD();
            //
            conexion.recuperarCategoria();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
            
        }
    }
}
