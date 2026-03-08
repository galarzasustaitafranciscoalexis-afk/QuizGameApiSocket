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
    public class PreguntaControl : Control
    {
        private string pregunta = "";
        private int borderRadius = 30;
        private Color backgroundColor = Color.White;
        private Color borderColor = Color.Black;

        public string Pregunta
        {
            get { return pregunta; }
            set
            {
                pregunta = value;
                this.Invalidate();
            }
        }

        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                UpdateRegion();
                this.Invalidate();
            }
        }

        public PreguntaControl()
        {
            this.DoubleBuffered = true;
            this.Font = new Font("Arial", 18, FontStyle.Bold);
            this.ForeColor = Color.Black;
            this.Size = new Size(600, 150);
        }

        private GraphicsPath GetPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int r = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void UpdateRegion()
        {
            using (GraphicsPath path = GetPath(this.ClientRectangle, borderRadius))
            {
                this.Region = new Region(path);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegion();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = this.ClientRectangle;

            using (GraphicsPath path = GetPath(rect, borderRadius))
            using (SolidBrush brush = new SolidBrush(backgroundColor))
            using (Pen pen = new Pen(borderColor, 2))
            {
                e.Graphics.FillPath(brush, path);
                e.Graphics.DrawPath(pen, path);
            }

            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;

            Rectangle textArea = new Rectangle(10, 10, this.Width - 20, this.Height - 20);

            using (SolidBrush textBrush = new SolidBrush(this.ForeColor))
            {
                e.Graphics.DrawString(pregunta, this.Font, textBrush, textArea, formato);
            }
        }
    }
}