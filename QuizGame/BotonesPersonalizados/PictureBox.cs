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
    public class PictureBoxRedondeado : PictureBox
    {
        private int borderRadius = 30;

        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        private GraphicsPath GetPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            float r = radius;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Width - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Width - r, rect.Height - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Height - r, r, r, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GraphicsPath path = GetPath(this.ClientRectangle, borderRadius);
            this.Region = new Region(path);
        }
    }
}
