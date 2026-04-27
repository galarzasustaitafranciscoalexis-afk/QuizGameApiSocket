namespace QuizGame
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.fondo = new QuizGame.ControlesPersonalizados.FondoRadial();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cat5 = new QuizGame.BotonesPersonalizados.Boton();
            this.btn_cat4 = new QuizGame.BotonesPersonalizados.Boton();
            this.btn_cat3 = new QuizGame.BotonesPersonalizados.Boton();
            this.btn_cat2 = new QuizGame.BotonesPersonalizados.Boton();
            this.btn_cat1 = new QuizGame.BotonesPersonalizados.Boton();
            this.lbEstado = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.fondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // fondo
            // 
            this.fondo.BorderColor = System.Drawing.Color.MediumPurple;
            this.fondo.CenterColor = System.Drawing.Color.PaleTurquoise;
            this.fondo.Controls.Add(this.lbEstado);
            this.fondo.Controls.Add(this.label1);
            this.fondo.Controls.Add(this.btn_cat5);
            this.fondo.Controls.Add(this.btn_cat4);
            this.fondo.Controls.Add(this.btn_cat3);
            this.fondo.Controls.Add(this.btn_cat2);
            this.fondo.Controls.Add(this.btn_cat1);
            this.fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fondo.Location = new System.Drawing.Point(0, 0);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(750, 467);
            this.fondo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menú";
            // 
            // btn_cat5
            // 
            this.btn_cat5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cat5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_cat5.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_cat5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_cat5.BorderRadius = 40;
            this.btn_cat5.BorderSize = 0;
            this.btn_cat5.FlatAppearance.BorderSize = 0;
            this.btn_cat5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cat5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat5.ForeColor = System.Drawing.Color.White;
            this.btn_cat5.Location = new System.Drawing.Point(248, 362);
            this.btn_cat5.Name = "btn_cat5";
            this.btn_cat5.Size = new System.Drawing.Size(247, 40);
            this.btn_cat5.TabIndex = 4;
            this.btn_cat5.Text = "Tecnología";
            this.btn_cat5.TextColor = System.Drawing.Color.White;
            this.btn_cat5.UseVisualStyleBackColor = false;
            this.btn_cat5.Click += new System.EventHandler(this.btn_cat5_Click_1);
            // 
            // btn_cat4
            // 
            this.btn_cat4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cat4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_cat4.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_cat4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_cat4.BorderRadius = 40;
            this.btn_cat4.BorderSize = 0;
            this.btn_cat4.FlatAppearance.BorderSize = 0;
            this.btn_cat4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cat4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat4.ForeColor = System.Drawing.Color.White;
            this.btn_cat4.Location = new System.Drawing.Point(248, 290);
            this.btn_cat4.Name = "btn_cat4";
            this.btn_cat4.Size = new System.Drawing.Size(247, 40);
            this.btn_cat4.TabIndex = 3;
            this.btn_cat4.Text = "Astronomía";
            this.btn_cat4.TextColor = System.Drawing.Color.White;
            this.btn_cat4.UseVisualStyleBackColor = false;
            this.btn_cat4.Click += new System.EventHandler(this.btn_cat4_Click_1);
            // 
            // btn_cat3
            // 
            this.btn_cat3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cat3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_cat3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_cat3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_cat3.BorderRadius = 40;
            this.btn_cat3.BorderSize = 0;
            this.btn_cat3.FlatAppearance.BorderSize = 0;
            this.btn_cat3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cat3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat3.ForeColor = System.Drawing.Color.White;
            this.btn_cat3.Location = new System.Drawing.Point(248, 227);
            this.btn_cat3.Name = "btn_cat3";
            this.btn_cat3.Size = new System.Drawing.Size(247, 40);
            this.btn_cat3.TabIndex = 2;
            this.btn_cat3.Text = "Música";
            this.btn_cat3.TextColor = System.Drawing.Color.White;
            this.btn_cat3.UseVisualStyleBackColor = false;
            this.btn_cat3.Click += new System.EventHandler(this.btn_cat3_Click_1);
            // 
            // btn_cat2
            // 
            this.btn_cat2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cat2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_cat2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_cat2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_cat2.BorderRadius = 40;
            this.btn_cat2.BorderSize = 0;
            this.btn_cat2.FlatAppearance.BorderSize = 0;
            this.btn_cat2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cat2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat2.ForeColor = System.Drawing.Color.White;
            this.btn_cat2.Location = new System.Drawing.Point(248, 163);
            this.btn_cat2.Name = "btn_cat2";
            this.btn_cat2.Size = new System.Drawing.Size(247, 40);
            this.btn_cat2.TabIndex = 1;
            this.btn_cat2.Text = "Literatura";
            this.btn_cat2.TextColor = System.Drawing.Color.White;
            this.btn_cat2.UseVisualStyleBackColor = false;
            this.btn_cat2.Click += new System.EventHandler(this.btn_cat2_Click_1);
            // 
            // btn_cat1
            // 
            this.btn_cat1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cat1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_cat1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_cat1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_cat1.BorderRadius = 40;
            this.btn_cat1.BorderSize = 0;
            this.btn_cat1.FlatAppearance.BorderSize = 0;
            this.btn_cat1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cat1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat1.ForeColor = System.Drawing.Color.White;
            this.btn_cat1.Location = new System.Drawing.Point(248, 101);
            this.btn_cat1.Name = "btn_cat1";
            this.btn_cat1.Size = new System.Drawing.Size(247, 40);
            this.btn_cat1.TabIndex = 0;
            this.btn_cat1.Text = "Historia";
            this.btn_cat1.TextColor = System.Drawing.Color.White;
            this.btn_cat1.UseVisualStyleBackColor = false;
            this.btn_cat1.Click += new System.EventHandler(this.btn_cat1_Click_1);
            // 
            // lbEstado
            // 
            this.lbEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbEstado.AutoSize = true;
            this.lbEstado.BackColor = System.Drawing.Color.Transparent;
            this.lbEstado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.Location = new System.Drawing.Point(148, 426);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(459, 32);
            this.lbEstado.TabIndex = 6;
            this.lbEstado.Text = "Esperando a los demas jugadores";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 467);
            this.Controls.Add(this.fondo);
            this.Name = "Menu";
            this.Text = "3";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.fondo.ResumeLayout(false);
            this.fondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesPersonalizados.FondoRadial fondo;
        private BotonesPersonalizados.Boton btn_cat1;
        private BotonesPersonalizados.Boton btn_cat5;
        private BotonesPersonalizados.Boton btn_cat4;
        private BotonesPersonalizados.Boton btn_cat3;
        private BotonesPersonalizados.Boton btn_cat2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Timer timer;
    }
}