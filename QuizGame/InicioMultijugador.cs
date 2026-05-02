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
            bool conectado = ConexionGlobal.Cliente.Conectar();
            UsuarioGlobal.NombreUsuario = nombre;

            if (conectado)
            {

                ConexionGlobal.Cliente.Enviar("REGISTRAR_USUARIO:" + nombre);

                Menu ventana = new Menu();
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No fue posible conectar con el servidor.");
            }
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            if (UserName.Text == "")
            {
                btn_multi.Enabled = false; 
                return;
            }
            else
            {
                btn_multi.Enabled = true;
            }
        }
    }
}

