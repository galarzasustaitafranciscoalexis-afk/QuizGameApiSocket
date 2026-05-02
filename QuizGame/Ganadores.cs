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
    public partial class Ganadores : Form
    {
        public Ganadores()
        {
            InitializeComponent();
        }



        private void btn_estadisticas_Click(object sender, EventArgs e)
        {
            Estadisticas stats = new Estadisticas();
            stats.StartPosition = FormStartPosition.Manual;
            stats.Bounds = this.Bounds;

            stats.Show();
            this.Close();
        }


        public void LLenarPodio(List<Dictionary<string, object>> datos)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => LLenarPodio(datos)));
                return;
            }

            if (datos.Count >= 1)
            {
               lbPrimerLugar.Text = datos[0]["nombre"].ToString();
               btnPuntos1.Text = datos[0]["puntaje_final"].ToString();
            }
            if (datos.Count >= 2)
            {
                lbSegundoLugar.Text = datos[1]["nombre"].ToString();
                btnPuntos2.Text = datos[1]["puntaje_final"].ToString();
            }
            if (datos.Count >= 3)
            {
                lbTercerLugar.Text = datos[2]["nombre"].ToString();
                btnPuntos3.Text = datos[2]["puntaje_final"].ToString();
            }
        }
    }
}
