using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QuizGame.ControlesPersonalizados
{
    public class FondoRadial : Panel
    {
        public Color CenterColor { get; set; } = Color.MediumSlateBlue;
        public Color BorderColor { get; set; } = Color.Black;

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddRectangle(this.ClientRectangle);

                using (PathGradientBrush brush = new PathGradientBrush(path))
                {
                    brush.CenterColor = CenterColor;
                    brush.SurroundColors = new Color[] { BorderColor };

                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
            }
        }

        protected override void OnResize(EventArgs e) 
        {
            base.OnResize(e);
            this.Invalidate(); 
        }
    }
}