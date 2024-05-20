namespace POO24A_HMFG.Views.MenuViews
{
    partial class CMenuPracticas
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CMenuPracticas));
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.btnConfig = new System.Windows.Forms.PictureBox();
            this.pnlMapa = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlDinamico = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPracticaTitulo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cPlayer1 = new POO24A_HMFG.Class.ClasesPersonaje.CPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfig)).BeginInit();
            this.pnlMapa.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Image = global::POO24A_HMFG.Properties.Resources.btnInicio1;
            this.btnInicio.Location = new System.Drawing.Point(1022, 536);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(64, 64);
            this.btnInicio.TabIndex = 8;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            this.btnInicio.MouseEnter += new System.EventHandler(this.btnInicio_MouseEnter);
            this.btnInicio.MouseLeave += new System.EventHandler(this.btnInicio_MouseLeave);
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.Image = global::POO24A_HMFG.Properties.Resources.btnConfig1;
            this.btnConfig.Location = new System.Drawing.Point(1088, 520);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(80, 80);
            this.btnConfig.TabIndex = 7;
            this.btnConfig.TabStop = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            this.btnConfig.MouseEnter += new System.EventHandler(this.btnConfig_MouseEnter);
            this.btnConfig.MouseLeave += new System.EventHandler(this.btnConfig_MouseLeave);
            // 
            // pnlMapa
            // 
            this.pnlMapa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMapa.Controls.Add(this.button2);
            this.pnlMapa.Controls.Add(this.button1);
            this.pnlMapa.Controls.Add(this.cPlayer1);
            this.pnlMapa.Location = new System.Drawing.Point(24, 21);
            this.pnlMapa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlMapa.Name = "pnlMapa";
            this.pnlMapa.Size = new System.Drawing.Size(484, 573);
            this.pnlMapa.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlDinamico
            // 
            this.pnlDinamico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDinamico.BackColor = System.Drawing.Color.Transparent;
            this.pnlDinamico.Location = new System.Drawing.Point(518, 21);
            this.pnlDinamico.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlDinamico.Name = "pnlDinamico";
            this.pnlDinamico.Size = new System.Drawing.Size(637, 459);
            this.pnlDinamico.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::POO24A_HMFG.Properties.Resources.BarraEstado;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lbPracticaTitulo);
            this.panel2.Location = new System.Drawing.Point(518, 488);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 105);
            this.panel2.TabIndex = 12;
            // 
            // lbPracticaTitulo
            // 
            this.lbPracticaTitulo.AutoSize = true;
            this.lbPracticaTitulo.ForeColor = System.Drawing.Color.White;
            this.lbPracticaTitulo.Location = new System.Drawing.Point(100, 47);
            this.lbPracticaTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbPracticaTitulo.Name = "lbPracticaTitulo";
            this.lbPracticaTitulo.Size = new System.Drawing.Size(31, 21);
            this.lbPracticaTitulo.TabIndex = 0;
            this.lbPracticaTitulo.Text = "...";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cPlayer1
            // 
            this.cPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.cPlayer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cPlayer1.BackgroundImage")));
            this.cPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cPlayer1.Location = new System.Drawing.Point(202, 91);
            this.cPlayer1.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.cPlayer1.Name = "cPlayer1";
            this.cPlayer1.Size = new System.Drawing.Size(52, 52);
            this.cPlayer1.TabIndex = 9;
            // 
            // CMenuPracticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImage = global::POO24A_HMFG.Properties.Resources.FondoMenuPracticas;
            this.Controls.Add(this.pnlDinamico);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMapa);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnConfig);
            this.Font = new System.Drawing.Font("Pokemon Classic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.Name = "CMenuPracticas";
            this.Size = new System.Drawing.Size(1180, 620);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfig)).EndInit();
            this.pnlMapa.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnConfig;
        private System.Windows.Forms.PictureBox btnInicio;
        private Class.ClasesPersonaje.CPlayer cPlayer1;
        private System.Windows.Forms.Panel pnlMapa;
        private System.Windows.Forms.Panel pnlDinamico;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbPracticaTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
