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
            this.fondoRadial1 = new QuizGame.ControlesPersonalizados.FondoRadial();
            this.pregunta = new QuizGame.ControlesPersonalizados.PreguntaControl();
            this.btn_respuesta4 = new QuizGame.BotonesPersonalizados.Boton();
            this.btn_respuesta2 = new QuizGame.BotonesPersonalizados.Boton();
            this.btn_respuesta3 = new QuizGame.BotonesPersonalizados.Boton();
            this.btn_respuesta1 = new QuizGame.BotonesPersonalizados.Boton();
            this.fondoRadial1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fondoRadial1
            // 
            this.fondoRadial1.BorderColor = System.Drawing.Color.MediumPurple;
            this.fondoRadial1.CenterColor = System.Drawing.Color.PaleTurquoise;
            this.fondoRadial1.Controls.Add(this.pregunta);
            this.fondoRadial1.Controls.Add(this.btn_respuesta4);
            this.fondoRadial1.Controls.Add(this.btn_respuesta2);
            this.fondoRadial1.Controls.Add(this.btn_respuesta3);
            this.fondoRadial1.Controls.Add(this.btn_respuesta1);
            this.fondoRadial1.Location = new System.Drawing.Point(-2, -4);
            this.fondoRadial1.Name = "fondoRadial1";
            this.fondoRadial1.Size = new System.Drawing.Size(699, 362);
            this.fondoRadial1.TabIndex = 0;
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
            // btn_respuesta4
            // 
            this.btn_respuesta4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_respuesta4.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_respuesta4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_respuesta4.BorderRadius = 40;
            this.btn_respuesta4.BorderSize = 0;
            this.btn_respuesta4.FlatAppearance.BorderSize = 0;
            this.btn_respuesta4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_respuesta4.ForeColor = System.Drawing.Color.White;
            this.btn_respuesta4.Location = new System.Drawing.Point(431, 229);
            this.btn_respuesta4.Name = "btn_respuesta4";
            this.btn_respuesta4.Size = new System.Drawing.Size(150, 40);
            this.btn_respuesta4.TabIndex = 4;
            this.btn_respuesta4.Text = "Respuesta 4";
            this.btn_respuesta4.TextColor = System.Drawing.Color.White;
            this.btn_respuesta4.UseVisualStyleBackColor = false;
            // 
            // btn_respuesta2
            // 
            this.btn_respuesta2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_respuesta2.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_respuesta2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_respuesta2.BorderRadius = 40;
            this.btn_respuesta2.BorderSize = 0;
            this.btn_respuesta2.FlatAppearance.BorderSize = 0;
            this.btn_respuesta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_respuesta2.ForeColor = System.Drawing.Color.White;
            this.btn_respuesta2.Location = new System.Drawing.Point(431, 170);
            this.btn_respuesta2.Name = "btn_respuesta2";
            this.btn_respuesta2.Size = new System.Drawing.Size(150, 40);
            this.btn_respuesta2.TabIndex = 3;
            this.btn_respuesta2.Text = "Respuesta 2";
            this.btn_respuesta2.TextColor = System.Drawing.Color.White;
            this.btn_respuesta2.UseVisualStyleBackColor = false;
            // 
            // btn_respuesta3
            // 
            this.btn_respuesta3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_respuesta3.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_respuesta3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_respuesta3.BorderRadius = 40;
            this.btn_respuesta3.BorderSize = 0;
            this.btn_respuesta3.FlatAppearance.BorderSize = 0;
            this.btn_respuesta3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_respuesta3.ForeColor = System.Drawing.Color.White;
            this.btn_respuesta3.Location = new System.Drawing.Point(123, 229);
            this.btn_respuesta3.Name = "btn_respuesta3";
            this.btn_respuesta3.Size = new System.Drawing.Size(150, 40);
            this.btn_respuesta3.TabIndex = 2;
            this.btn_respuesta3.Text = "Respuesta 3";
            this.btn_respuesta3.TextColor = System.Drawing.Color.White;
            this.btn_respuesta3.UseVisualStyleBackColor = false;
            // 
            // btn_respuesta1
            // 
            this.btn_respuesta1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_respuesta1.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_respuesta1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_respuesta1.BorderRadius = 40;
            this.btn_respuesta1.BorderSize = 0;
            this.btn_respuesta1.FlatAppearance.BorderSize = 0;
            this.btn_respuesta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_respuesta1.ForeColor = System.Drawing.Color.White;
            this.btn_respuesta1.Location = new System.Drawing.Point(123, 170);
            this.btn_respuesta1.Name = "btn_respuesta1";
            this.btn_respuesta1.Size = new System.Drawing.Size(150, 40);
            this.btn_respuesta1.TabIndex = 0;
            this.btn_respuesta1.Text = "Respueta 1";
            this.btn_respuesta1.TextColor = System.Drawing.Color.White;
            this.btn_respuesta1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_respuesta1.UseVisualStyleBackColor = false;
            // 
            // Quiz_Texto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 357);
            this.Controls.Add(this.fondoRadial1);
            this.Name = "Quiz_Texto";
            this.Text = "Quiz  Texto";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.fondoRadial1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesPersonalizados.FondoRadial fondoRadial1;
        private BotonesPersonalizados.Boton btn_respuesta1;
        private BotonesPersonalizados.Boton btn_respuesta4;
        private BotonesPersonalizados.Boton btn_respuesta2;
        private BotonesPersonalizados.Boton btn_respuesta3;
        private ControlesPersonalizados.PreguntaControl pregunta;
    }
}

