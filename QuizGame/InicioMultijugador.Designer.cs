namespace QuizGame
{
    partial class InicioMultijugador
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
            this.label1 = new QuizGame.ControlesPersonalizados.FondoRadial();
            this.btn_estaditicas = new QuizGame.BotonesPersonalizados.Boton();
            this.lbEsperando = new System.Windows.Forms.Label();
            this.label1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderColor = System.Drawing.Color.MediumPurple;
            this.label1.CenterColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Controls.Add(this.btn_estaditicas);
            this.label1.Controls.Add(this.lbEsperando);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 450);
            this.label1.TabIndex = 4;
            // 
            // btn_estaditicas
            // 
            this.btn_estaditicas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_estaditicas.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_estaditicas.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_estaditicas.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_estaditicas.BorderRadius = 17;
            this.btn_estaditicas.BorderSize = 0;
            this.btn_estaditicas.FlatAppearance.BorderSize = 0;
            this.btn_estaditicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estaditicas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estaditicas.ForeColor = System.Drawing.Color.White;
            this.btn_estaditicas.Location = new System.Drawing.Point(338, 207);
            this.btn_estaditicas.Name = "btn_estaditicas";
            this.btn_estaditicas.Size = new System.Drawing.Size(124, 63);
            this.btn_estaditicas.TabIndex = 19;
            this.btn_estaditicas.Text = "Iniciar partida ";
            this.btn_estaditicas.TextColor = System.Drawing.Color.White;
            this.btn_estaditicas.UseVisualStyleBackColor = false;
            // 
            // lbEsperando
            // 
            this.lbEsperando.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEsperando.AutoSize = true;
            this.lbEsperando.BackColor = System.Drawing.Color.Transparent;
            this.lbEsperando.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEsperando.Location = new System.Drawing.Point(292, 78);
            this.lbEsperando.Name = "lbEsperando";
            this.lbEsperando.Size = new System.Drawing.Size(223, 46);
            this.lbEsperando.TabIndex = 12;
            this.lbEsperando.Text = "QuizGame";
            this.lbEsperando.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InicioMultijugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Name = "InicioMultijugador";
            this.Text = "InicioMultijugador";
            this.label1.ResumeLayout(false);
            this.label1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesPersonalizados.FondoRadial label1;
        private System.Windows.Forms.Label lbEsperando;
        private BotonesPersonalizados.Boton btn_estaditicas;
    }
}