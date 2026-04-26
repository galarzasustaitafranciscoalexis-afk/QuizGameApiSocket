using QuizGame.ClasesAdicionales;
using QuizGame.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class InicioMultijugador : Form
    {
        public InicioMultijugador()
        {
            InitializeComponent();
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            string nombre = UserName.Text.Trim();

            if (nombre == "")
            {
                MessageBox.Show("Ingresa un nombre de usuario",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                UserName.Focus();
                return;
            }

            UsuarioGlobal.NombreUsuario = nombre;
            bool conectado = ConexionGlobal.Cliente.Conectar();

            if (conectado)
            {
                MessageBox.Show("Conectado al servidor correctamente.");

                Menu ventana = new Menu();
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No fue posible conectar con el servidor.");
            }
        }

    }    
}

