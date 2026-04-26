using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizGame.Modelos;

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
