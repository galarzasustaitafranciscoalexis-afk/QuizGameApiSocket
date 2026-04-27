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
            this.name = new System.Windows.Forms.Label();
            this.UserName = new QuizGame.ControlesPersonalizados.TextBoxRedondeado();
            this.btn_multi = new QuizGame.BotonesPersonalizados.Boton();
            this.lbEsperando = new System.Windows.Forms.Label();
            this.label1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderColor = System.Drawing.Color.MediumPurple;
            this.label1.CenterColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Controls.Add(this.name);
            this.label1.Controls.Add(this.UserName);
            this.label1.Controls.Add(this.btn_multi);
            this.label1.Controls.Add(this.lbEsperando);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 450);
            this.label1.TabIndex = 4;
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(194, 185);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(80, 22);
            this.name.TabIndex = 21;
            this.name.Text = "Usuario";
            this.name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserName
            // 
            this.UserName.BorderRadius = 20;
            this.UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(292, 185);
            this.UserName.Multiline = true;
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(223, 22);
            this.UserName.TabIndex = 20;
            this.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // btn_multi
            // 
            this.btn_multi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_multi.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_multi.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_multi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_multi.BorderRadius = 17;
            this.btn_multi.BorderSize = 0;
            this.btn_multi.Enabled = false;
            this.btn_multi.FlatAppearance.BorderSize = 0;
            this.btn_multi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_multi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multi.ForeColor = System.Drawing.Color.White;
            this.btn_multi.Location = new System.Drawing.Point(333, 242);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(124, 63);
            this.btn_multi.TabIndex = 19;
            this.btn_multi.Text = "Iniciar partida ";
            this.btn_multi.TextColor = System.Drawing.Color.White;
            this.btn_multi.UseVisualStyleBackColor = false;
            this.btn_multi.Click += new System.EventHandler(this.btn_multi_Click);
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
        private BotonesPersonalizados.Boton btn_multi;
        private System.Windows.Forms.Label name;
        private ControlesPersonalizados.TextBoxRedondeado UserName;
    }
}