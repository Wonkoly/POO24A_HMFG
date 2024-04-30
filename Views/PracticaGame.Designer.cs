namespace POO24A_HMFG.Views
{
    partial class PracticaGame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCrearBloqueador = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlArea = new System.Windows.Forms.PictureBox();
            this.btnJugadoresLaterales = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlArea)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnJugadoresLaterales);
            this.panel1.Controls.Add(this.btnCrearBloqueador);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 94);
            this.panel1.TabIndex = 0;
            // 
            // btnCrearBloqueador
            // 
            this.btnCrearBloqueador.Location = new System.Drawing.Point(521, 22);
            this.btnCrearBloqueador.Name = "btnCrearBloqueador";
            this.btnCrearBloqueador.Size = new System.Drawing.Size(193, 46);
            this.btnCrearBloqueador.TabIndex = 1;
            this.btnCrearBloqueador.Text = "Crea Jugador";
            this.btnCrearBloqueador.UseVisualStyleBackColor = true;
            this.btnCrearBloqueador.Click += new System.EventHandler(this.btnCrearBloqueador_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Movil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPrincipal.Controls.Add(this.pnlArea);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 94);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1262, 579);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // pnlArea
            // 
            this.pnlArea.Image = global::POO24A_HMFG.Properties.Resources.FondoMenuPracticas;
            this.pnlArea.Location = new System.Drawing.Point(12, 14);
            this.pnlArea.Name = "pnlArea";
            this.pnlArea.Size = new System.Drawing.Size(1238, 551);
            this.pnlArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnlArea.TabIndex = 0;
            this.pnlArea.TabStop = false;
            // 
            // btnJugadoresLaterales
            // 
            this.btnJugadoresLaterales.Location = new System.Drawing.Point(745, 17);
            this.btnJugadoresLaterales.Name = "btnJugadoresLaterales";
            this.btnJugadoresLaterales.Size = new System.Drawing.Size(193, 56);
            this.btnJugadoresLaterales.TabIndex = 2;
            this.btnJugadoresLaterales.Text = "Jugadores Laterales";
            this.btnJugadoresLaterales.UseVisualStyleBackColor = true;
            this.btnJugadoresLaterales.Click += new System.EventHandler(this.btnJugadoresLaterales_Click);
            // 
            // PracticaGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Pokemon Classic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "PracticaGame";
            this.Text = "PracticaGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PracticaGame_KeyDown);
            this.panel1.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button btnCrearBloqueador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pnlArea;
        private System.Windows.Forms.Button btnJugadoresLaterales;
    }
}