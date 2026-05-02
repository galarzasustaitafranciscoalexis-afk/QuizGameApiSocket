namespace QuizGame
{
    partial class Ganadores
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
            this.btn_estadisticas = new QuizGame.BotonesPersonalizados.Boton();
            this.lbTercerLugar = new System.Windows.Forms.Label();
            this.lbSegundoLugar = new System.Windows.Forms.Label();
            this.lbPrimerLugar = new System.Windows.Forms.Label();
            this.btnPuntos2 = new QuizGame.BotonesPersonalizados.Boton();
            this.btnPuntos1 = new QuizGame.BotonesPersonalizados.Boton();
            this.btnPuntos3 = new QuizGame.BotonesPersonalizados.Boton();
            this.label1 = new System.Windows.Forms.Label();
            this.fondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // fondo
            // 
            this.fondo.BorderColor = System.Drawing.Color.MediumPurple;
            this.fondo.CenterColor = System.Drawing.Color.PaleTurquoise;
            this.fondo.Controls.Add(this.btn_estadisticas);
            this.fondo.Controls.Add(this.lbTercerLugar);
            this.fondo.Controls.Add(this.lbSegundoLugar);
            this.fondo.Controls.Add(this.lbPrimerLugar);
            this.fondo.Controls.Add(this.btnPuntos2);
            this.fondo.Controls.Add(this.btnPuntos1);
            this.fondo.Controls.Add(this.btnPuntos3);
            this.fondo.Controls.Add(this.label1);
            this.fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fondo.Location = new System.Drawing.Point(0, 0);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(780, 454);
            this.fondo.TabIndex = 2;
            // 
            // btn_estadisticas
            // 
            this.btn_estadisticas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_estadisticas.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_estadisticas.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_estadisticas.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_estadisticas.BorderRadius = 17;
            this.btn_estadisticas.BorderSize = 0;
            this.btn_estadisticas.FlatAppearance.BorderSize = 0;
            this.btn_estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estadisticas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estadisticas.ForeColor = System.Drawing.Color.White;
            this.btn_estadisticas.Location = new System.Drawing.Point(626, 224);
            this.btn_estadisticas.Name = "btn_estadisticas";
            this.btn_estadisticas.Size = new System.Drawing.Size(124, 36);
            this.btn_estadisticas.TabIndex = 18;
            this.btn_estadisticas.Text = "Estadisticas";
            this.btn_estadisticas.TextColor = System.Drawing.Color.White;
            this.btn_estadisticas.UseVisualStyleBackColor = false;
            this.btn_estadisticas.Click += new System.EventHandler(this.btn_estadisticas_Click);
            // 
            // lbTercerLugar
            // 
            this.lbTercerLugar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTercerLugar.AutoSize = true;
            this.lbTercerLugar.BackColor = System.Drawing.Color.Transparent;
            this.lbTercerLugar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTercerLugar.Location = new System.Drawing.Point(117, 185);
            this.lbTercerLugar.Name = "lbTercerLugar";
            this.lbTercerLugar.Size = new System.Drawing.Size(156, 33);
            this.lbTercerLugar.TabIndex = 17;
            this.lbTercerLugar.Text = "Ganador3";
            // 
            // lbSegundoLugar
            // 
            this.lbSegundoLugar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSegundoLugar.AutoSize = true;
            this.lbSegundoLugar.BackColor = System.Drawing.Color.Transparent;
            this.lbSegundoLugar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSegundoLugar.Location = new System.Drawing.Point(482, 158);
            this.lbSegundoLugar.Name = "lbSegundoLugar";
            this.lbSegundoLugar.Size = new System.Drawing.Size(156, 33);
            this.lbSegundoLugar.TabIndex = 16;
            this.lbSegundoLugar.Text = "Ganador2";
            // 
            // lbPrimerLugar
            // 
            this.lbPrimerLugar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPrimerLugar.AutoSize = true;
            this.lbPrimerLugar.BackColor = System.Drawing.Color.Transparent;
            this.lbPrimerLugar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrimerLugar.Location = new System.Drawing.Point(304, 108);
            this.lbPrimerLugar.Name = "lbPrimerLugar";
            this.lbPrimerLugar.Size = new System.Drawing.Size(156, 33);
            this.lbPrimerLugar.TabIndex = 15;
            this.lbPrimerLugar.Text = "Ganador1";
            // 
            // btnPuntos2
            // 
            this.btnPuntos2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPuntos2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPuntos2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPuntos2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPuntos2.BorderRadius = 40;
            this.btnPuntos2.BorderSize = 0;
            this.btnPuntos2.FlatAppearance.BorderSize = 0;
            this.btnPuntos2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPuntos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuntos2.ForeColor = System.Drawing.Color.White;
            this.btnPuntos2.Location = new System.Drawing.Point(459, 194);
            this.btnPuntos2.Name = "btnPuntos2";
            this.btnPuntos2.Size = new System.Drawing.Size(146, 248);
            this.btnPuntos2.TabIndex = 14;
            this.btnPuntos2.Text = "100";
            this.btnPuntos2.TextColor = System.Drawing.Color.White;
            this.btnPuntos2.UseVisualStyleBackColor = false;
            // 
            // btnPuntos1
            // 
            this.btnPuntos1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPuntos1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPuntos1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPuntos1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPuntos1.BorderRadius = 40;
            this.btnPuntos1.BorderSize = 0;
            this.btnPuntos1.FlatAppearance.BorderSize = 0;
            this.btnPuntos1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPuntos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuntos1.ForeColor = System.Drawing.Color.White;
            this.btnPuntos1.Location = new System.Drawing.Point(279, 144);
            this.btnPuntos1.Name = "btnPuntos1";
            this.btnPuntos1.Size = new System.Drawing.Size(146, 298);
            this.btnPuntos1.TabIndex = 13;
            this.btnPuntos1.Text = "100";
            this.btnPuntos1.TextColor = System.Drawing.Color.White;
            this.btnPuntos1.UseVisualStyleBackColor = false;
            // 
            // btnPuntos3
            // 
            this.btnPuntos3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPuntos3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPuntos3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPuntos3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPuntos3.BorderRadius = 40;
            this.btnPuntos3.BorderSize = 0;
            this.btnPuntos3.FlatAppearance.BorderSize = 0;
            this.btnPuntos3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPuntos3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuntos3.ForeColor = System.Drawing.Color.White;
            this.btnPuntos3.Location = new System.Drawing.Point(95, 221);
            this.btnPuntos3.Name = "btnPuntos3";
            this.btnPuntos3.Size = new System.Drawing.Size(146, 221);
            this.btnPuntos3.TabIndex = 12;
            this.btnPuntos3.Text = "100";
            this.btnPuntos3.TextColor = System.Drawing.Color.White;
            this.btnPuntos3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 55);
            this.label1.TabIndex = 11;
            this.label1.Text = "Podio";
            // 
            // Ganadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 454);
            this.Controls.Add(this.fondo);
            this.Name = "Ganadores";
            this.Text = "Ganadores";
            this.fondo.ResumeLayout(false);
            this.fondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesPersonalizados.FondoRadial fondo;
        private System.Windows.Forms.Label label1;
        private BotonesPersonalizados.Boton btnPuntos2;
        private BotonesPersonalizados.Boton btnPuntos1;
        private BotonesPersonalizados.Boton btnPuntos3;
        private System.Windows.Forms.Label lbPrimerLugar;
        private System.Windows.Forms.Label lbSegundoLugar;
        private System.Windows.Forms.Label lbTercerLugar;
        private BotonesPersonalizados.Boton btn_estadisticas;
    }
}