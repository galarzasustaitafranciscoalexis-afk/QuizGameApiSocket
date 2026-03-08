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
    public partial class Quiz_Imagen : Form
    {
        public Quiz_Imagen()
        {
            InitializeComponent();
            string preguntaPrueba = "¿Quién descubrió América en 1492?";
            pregunta.Pregunta = preguntaPrueba;
        }

        private void Quiz_Imagen_Load(object sender, EventArgs e)
        {

        }
    }
}
