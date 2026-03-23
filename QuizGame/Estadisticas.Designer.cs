namespace QuizGame
{
    partial class Estadisticas
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
            this.btn_cat1 = new QuizGame.BotonesPersonalizados.Boton();
            this.label1 = new System.Windows.Forms.Label();
            this.Estadistica = new QuizGame.ControlesPersonalizados.PictureBoxRedondeado();
            this.fondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Estadistica)).BeginInit();
            this.SuspendLayout();
            // 
            // fondo
            // 
            this.fondo.BorderColor = System.Drawing.Color.MediumPurple;
            this.fondo.CenterColor = System.Drawing.Color.PaleTurquoise;
            this.fondo.Controls.Add(this.btn_cat1);
            this.fondo.Controls.Add(this.label1);
            this.fondo.Controls.Add(this.Estadistica);
            this.fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fondo.Location = new System.Drawing.Point(0, 0);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(800, 450);
            this.fondo.TabIndex = 1;
            // 
            // btn_cat1
            // 
            this.btn_cat1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cat1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_cat1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_cat1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_cat1.BorderRadius = 17;
            this.btn_cat1.BorderSize = 0;
            this.btn_cat1.FlatAppearance.BorderSize = 0;
            this.btn_cat1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cat1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat1.ForeColor = System.Drawing.Color.White;
            this.btn_cat1.Location = new System.Drawing.Point(641, 214);
            this.btn_cat1.Name = "btn_cat1";
            this.btn_cat1.Size = new System.Drawing.Size(124, 36);
            this.btn_cat1.TabIndex = 12;
            this.btn_cat1.Text = "Menú";
            this.btn_cat1.TextColor = System.Drawing.Color.White;
            this.btn_cat1.UseVisualStyleBackColor = false;
            this.btn_cat1.Click += new System.EventHandler(this.btn_cat1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 55);
            this.label1.TabIndex = 11;
            this.label1.Text = "Estadísticas";
            // 
            // Estadistica
            // 
            this.Estadistica.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Estadistica.BorderRadius = 30;
            this.Estadistica.Location = new System.Drawing.Point(40, 74);
            this.Estadistica.Name = "Estadistica";
            this.Estadistica.Size = new System.Drawing.Size(595, 364);
            this.Estadistica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Estadistica.TabIndex = 10;
            this.Estadistica.TabStop = false;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fondo);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            this.fondo.ResumeLayout(false);
            this.fondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Estadistica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesPersonalizados.FondoRadial fondo;
        private ControlesPersonalizados.PictureBoxRedondeado Estadistica;
        private System.Windows.Forms.Label label1;
        private BotonesPersonalizados.Boton btn_cat1;
    }
}