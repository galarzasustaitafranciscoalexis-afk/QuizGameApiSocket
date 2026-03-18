namespace QuizGame
{
    partial class Quiz_Texto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.fondo = new QuizGame.ControlesPersonalizados.FondoRadial();
            this.pregunta = new QuizGame.ControlesPersonalizados.PreguntaControl();
            this.btn_respuesta4 = new QuizGame.BotonesPersonalizados.Boton();
            this.btn_respuesta2 = new QuizGame.BotonesPersonalizados.Boton();
            this.btn_respuesta3 = new QuizGame.BotonesPersonalizados.Boton();
            this.btn_respuesta1 = new QuizGame.BotonesPersonalizados.Boton();
            this.fondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // fondo
            // 
            this.fondo.BorderColor = System.Drawing.Color.MediumPurple;
            this.fondo.CenterColor = System.Drawing.Color.PaleTurquoise;
            this.fondo.Controls.Add(this.pregunta);
            this.fondo.Controls.Add(this.btn_respuesta4);
            this.fondo.Controls.Add(this.btn_respuesta2);
            this.fondo.Controls.Add(this.btn_respuesta3);
            this.fondo.Controls.Add(this.btn_respuesta1);
            this.fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fondo.Location = new System.Drawing.Point(0, 0);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(734, 461);
            this.fondo.TabIndex = 0;
            // 
            // pregunta
            // 
            this.pregunta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pregunta.BorderRadius = 30;
            this.pregunta.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.pregunta.ForeColor = System.Drawing.Color.Black;
            this.pregunta.Location = new System.Drawing.Point(140, 55);
            this.pregunta.Name = "pregunta";
            this.pregunta.Pregunta = "";
            this.pregunta.Size = new System.Drawing.Size(462, 66);
            this.pregunta.TabIndex = 5;
            // 
            // btn_respuesta4
            // 
            this.btn_respuesta4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_respuesta4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_respuesta4.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_respuesta4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_respuesta4.BorderRadius = 40;
            this.btn_respuesta4.BorderSize = 0;
            this.btn_respuesta4.FlatAppearance.BorderSize = 0;
            this.btn_respuesta4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_respuesta4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_respuesta4.ForeColor = System.Drawing.Color.White;
            this.btn_respuesta4.Location = new System.Drawing.Point(452, 185);
            this.btn_respuesta4.Name = "btn_respuesta4";
            this.btn_respuesta4.Size = new System.Drawing.Size(170, 54);
            this.btn_respuesta4.TabIndex = 4;
            this.btn_respuesta4.TextColor = System.Drawing.Color.White;
            this.btn_respuesta4.UseVisualStyleBackColor = false;
            this.btn_respuesta4.Click += new System.EventHandler(this.btn_respuesta4_Click_1);
            // 
            // btn_respuesta2
            // 
            this.btn_respuesta2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_respuesta2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_respuesta2.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_respuesta2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_respuesta2.BorderRadius = 40;
            this.btn_respuesta2.BorderSize = 0;
            this.btn_respuesta2.FlatAppearance.BorderSize = 0;
            this.btn_respuesta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_respuesta2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_respuesta2.ForeColor = System.Drawing.Color.White;
            this.btn_respuesta2.Location = new System.Drawing.Point(452, 304);
            this.btn_respuesta2.Name = "btn_respuesta2";
            this.btn_respuesta2.Size = new System.Drawing.Size(170, 54);
            this.btn_respuesta2.TabIndex = 3;
            this.btn_respuesta2.TextColor = System.Drawing.Color.White;
            this.btn_respuesta2.UseVisualStyleBackColor = false;
            this.btn_respuesta2.Click += new System.EventHandler(this.btn_respuesta2_Click_1);
            // 
            // btn_respuesta3
            // 
            this.btn_respuesta3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_respuesta3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_respuesta3.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_respuesta3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_respuesta3.BorderRadius = 38;
            this.btn_respuesta3.BorderSize = 0;
            this.btn_respuesta3.FlatAppearance.BorderSize = 0;
            this.btn_respuesta3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_respuesta3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_respuesta3.ForeColor = System.Drawing.Color.White;
            this.btn_respuesta3.Location = new System.Drawing.Point(144, 185);
            this.btn_respuesta3.Name = "btn_respuesta3";
            this.btn_respuesta3.Size = new System.Drawing.Size(170, 54);
            this.btn_respuesta3.TabIndex = 2;
            this.btn_respuesta3.TextColor = System.Drawing.Color.White;
            this.btn_respuesta3.UseVisualStyleBackColor = false;
            this.btn_respuesta3.Click += new System.EventHandler(this.btn_respuesta3_Click_1);
            // 
            // btn_respuesta1
            // 
            this.btn_respuesta1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_respuesta1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_respuesta1.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_respuesta1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_respuesta1.BorderRadius = 27;
            this.btn_respuesta1.BorderSize = 0;
            this.btn_respuesta1.FlatAppearance.BorderSize = 0;
            this.btn_respuesta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_respuesta1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_respuesta1.ForeColor = System.Drawing.Color.White;
            this.btn_respuesta1.Location = new System.Drawing.Point(144, 302);
            this.btn_respuesta1.Name = "btn_respuesta1";
            this.btn_respuesta1.Size = new System.Drawing.Size(170, 54);
            this.btn_respuesta1.TabIndex = 0;
            this.btn_respuesta1.TextColor = System.Drawing.Color.White;
            this.btn_respuesta1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_respuesta1.UseVisualStyleBackColor = false;
            this.btn_respuesta1.Click += new System.EventHandler(this.btn_respuesta1_Click_1);
            // 
            // Quiz_Texto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.fondo);
            this.Name = "Quiz_Texto";
            this.Text = "Quiz  Texto";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.fondo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesPersonalizados.FondoRadial fondo;
        private BotonesPersonalizados.Boton btn_respuesta1;
        private BotonesPersonalizados.Boton btn_respuesta4;
        private BotonesPersonalizados.Boton btn_respuesta2;
        private BotonesPersonalizados.Boton btn_respuesta3;
        private ControlesPersonalizados.PreguntaControl pregunta;
    }
}

