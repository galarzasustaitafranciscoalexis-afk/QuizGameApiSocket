using QuizGame.ControlesPersonalizados;
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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            string preguntaPrueba = "¿Quién descubrió América en 1492?";
            pregunta.Pregunta = preguntaPrueba;

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
