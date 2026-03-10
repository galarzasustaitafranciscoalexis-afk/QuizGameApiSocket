namespace QuizGame
{
    partial class Quiz_Imagen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fondo = new QuizGame.ControlesPersonalizados.FondoRadial();
            this.imagen_respuesta4 = new QuizGame.ControlesPersonalizados.PictureBoxRedondeado();
            this.imagen_respuesta3 = new QuizGame.ControlesPersonalizados.PictureBoxRedondeado();
            this.imagen_respuesta2 = new QuizGame.ControlesPersonalizados.PictureBoxRedondeado();
            this.imagen_respuesta1 = new QuizGame.ControlesPersonalizados.PictureBoxRedondeado();
            this.pregunta = new QuizGame.ControlesPersonalizados.PreguntaControl();
            this.fondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_respuesta4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_respuesta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_respuesta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_respuesta1)).BeginInit();
            this.SuspendLayout();
            // 
            // fondo
            // 
            this.fondo.BorderColor = System.Drawing.Color.MediumPurple;
            this.fondo.CenterColor = System.Drawing.Color.PaleTurquoise;
            this.fondo.Controls.Add(this.imagen_respuesta4);
            this.fondo.Controls.Add(this.imagen_respuesta3);
            this.fondo.Controls.Add(this.imagen_respuesta2);
            this.fondo.Controls.Add(this.imagen_respuesta1);
            this.fondo.Controls.Add(this.pregunta);
            this.fondo.Location = new System.Drawing.Point(1, -2);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(710, 366);
            this.fondo.TabIndex = 1;
            // 
            // imagen_respuesta4
            // 
            this.imagen_respuesta4.BorderRadius = 30;
            this.imagen_respuesta4.Location = new System.Drawing.Point(521, 158);
            this.imagen_respuesta4.Name = "imagen_respuesta4";
            this.imagen_respuesta4.Size = new System.Drawing.Size(120, 142);
            this.imagen_respuesta4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imagen_respuesta4.TabIndex = 9;
            this.imagen_respuesta4.TabStop = false;
            // 
            // imagen_respuesta3
            // 
            this.imagen_respuesta3.BorderRadius = 30;
            this.imagen_respuesta3.Location = new System.Drawing.Point(365, 158);
            this.imagen_respuesta3.Name = "imagen_respuesta3";
            this.imagen_respuesta3.Size = new System.Drawing.Size(120, 142);
            this.imagen_respuesta3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imagen_respuesta3.TabIndex = 8;
            this.imagen_respuesta3.TabStop = false;
            // 
            // imagen_respuesta2
            // 
            this.imagen_respuesta2.BorderRadius = 30;
            this.imagen_respuesta2.Location = new System.Drawing.Point(211, 158);
            this.imagen_respuesta2.Name = "imagen_respuesta2";
            this.imagen_respuesta2.Size = new System.Drawing.Size(120, 142);
            this.imagen_respuesta2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imagen_respuesta2.TabIndex = 7;
            this.imagen_respuesta2.TabStop = false;
            // 
            // imagen_respuesta1
            // 
            this.imagen_respuesta1.BorderRadius = 30;
            this.imagen_respuesta1.Location = new System.Drawing.Point(57, 158);
            this.imagen_respuesta1.Name = "imagen_respuesta1";
            this.imagen_respuesta1.Size = new System.Drawing.Size(120, 142);
            this.imagen_respuesta1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imagen_respuesta1.TabIndex = 6;
            this.imagen_respuesta1.TabStop = false;
            // 
            // pregunta
            // 
            this.pregunta.BorderRadius = 30;
            this.pregunta.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.pregunta.ForeColor = System.Drawing.Color.Black;
            this.pregunta.Location = new System.Drawing.Point(119, 55);
            this.pregunta.Name = "pregunta";
            this.pregunta.Pregunta = "";
            this.pregunta.Size = new System.Drawing.Size(462, 66);
            this.pregunta.TabIndex = 5;
            // 
            // Quiz_Imagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 355);
            this.Controls.Add(this.fondo);
            this.Name = "Quiz_Imagen";
            this.Text = "Quiz_Imagen";
            this.Load += new System.EventHandler(this.Quiz_Imagen_Load);
            this.fondo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagen_respuesta4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_respuesta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_respuesta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_respuesta1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesPersonalizados.FondoRadial fondo;
        private ControlesPersonalizados.PreguntaControl pregunta;
        private ControlesPersonalizados.PictureBoxRedondeado imagen_respuesta1;
        private ControlesPersonalizados.PictureBoxRedondeado imagen_respuesta4;
        private ControlesPersonalizados.PictureBoxRedondeado imagen_respuesta3;
        private ControlesPersonalizados.PictureBoxRedondeado imagen_respuesta2;
    }
}