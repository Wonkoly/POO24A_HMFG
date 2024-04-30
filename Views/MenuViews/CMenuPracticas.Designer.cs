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
            this.btnP2 = new System.Windows.Forms.Button();
            this.btnP1 = new System.Windows.Forms.Button();
            this.cPlayer1 = new POO24A_HMFG.Class.ClasesPersonaje.CPlayer();
            this.pnlDinamico = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbIconoPractica = new System.Windows.Forms.PictureBox();
            this.lbPracticaTitulo = new System.Windows.Forms.Label();
            this.btnP3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfig)).BeginInit();
            this.pnlMapa.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoPractica)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Image = global::POO24A_HMFG.Properties.Resources.btnInicio1;
            this.btnInicio.Location = new System.Drawing.Point(1010, 536);
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
            this.btnConfig.Location = new System.Drawing.Point(1080, 520);
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
            this.pnlMapa.Controls.Add(this.btnP3);
            this.pnlMapa.Controls.Add(this.btnP2);
            this.pnlMapa.Controls.Add(this.btnP1);
            this.pnlMapa.Controls.Add(this.cPlayer1);
            this.pnlMapa.Location = new System.Drawing.Point(22, 18);
            this.pnlMapa.Name = "pnlMapa";
            this.pnlMapa.Size = new System.Drawing.Size(530, 582);
            this.pnlMapa.TabIndex = 10;
            // 
            // btnP2
            // 
            this.btnP2.Location = new System.Drawing.Point(194, 524);
            this.btnP2.Name = "btnP2";
            this.btnP2.Size = new System.Drawing.Size(140, 41);
            this.btnP2.TabIndex = 11;
            this.btnP2.Text = "Practica 2";
            this.btnP2.UseVisualStyleBackColor = true;
            this.btnP2.Click += new System.EventHandler(this.btnP2_Click);
            // 
            // btnP1
            // 
            this.btnP1.Location = new System.Drawing.Point(48, 524);
            this.btnP1.Name = "btnP1";
            this.btnP1.Size = new System.Drawing.Size(140, 41);
            this.btnP1.TabIndex = 10;
            this.btnP1.Text = "Practica 1";
            this.btnP1.UseVisualStyleBackColor = true;
            this.btnP1.Click += new System.EventHandler(this.btnP1_Click);
            // 
            // cPlayer1
            // 
            this.cPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.cPlayer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cPlayer1.BackgroundImage")));
            this.cPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cPlayer1.Location = new System.Drawing.Point(208, 63);
            this.cPlayer1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cPlayer1.Name = "cPlayer1";
            this.cPlayer1.Size = new System.Drawing.Size(32, 32);
            this.cPlayer1.TabIndex = 9;
            // 
            // pnlDinamico
            // 
            this.pnlDinamico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDinamico.BackColor = System.Drawing.Color.Transparent;
            this.pnlDinamico.Location = new System.Drawing.Point(558, 18);
            this.pnlDinamico.Name = "pnlDinamico";
            this.pnlDinamico.Size = new System.Drawing.Size(602, 496);
            this.pnlDinamico.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::POO24A_HMFG.Properties.Resources.BarraEstado;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pbIconoPractica);
            this.panel2.Controls.Add(this.lbPracticaTitulo);
            this.panel2.Location = new System.Drawing.Point(562, 520);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 80);
            this.panel2.TabIndex = 12;
            // 
            // pbIconoPractica
            // 
            this.pbIconoPractica.Location = new System.Drawing.Point(21, 18);
            this.pbIconoPractica.Name = "pbIconoPractica";
            this.pbIconoPractica.Size = new System.Drawing.Size(40, 40);
            this.pbIconoPractica.TabIndex = 1;
            this.pbIconoPractica.TabStop = false;
            // 
            // lbPracticaTitulo
            // 
            this.lbPracticaTitulo.AutoSize = true;
            this.lbPracticaTitulo.ForeColor = System.Drawing.Color.White;
            this.lbPracticaTitulo.Location = new System.Drawing.Point(86, 34);
            this.lbPracticaTitulo.Name = "lbPracticaTitulo";
            this.lbPracticaTitulo.Size = new System.Drawing.Size(31, 21);
            this.lbPracticaTitulo.TabIndex = 0;
            this.lbPracticaTitulo.Text = "...";
            // 
            // btnP3
            // 
            this.btnP3.Location = new System.Drawing.Point(340, 524);
            this.btnP3.Name = "btnP3";
            this.btnP3.Size = new System.Drawing.Size(140, 41);
            this.btnP3.TabIndex = 12;
            this.btnP3.Text = "Practica 3";
            this.btnP3.UseVisualStyleBackColor = true;
            this.btnP3.Click += new System.EventHandler(this.btnP3_Click);
            // 
            // CMenuPracticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImage = global::POO24A_HMFG.Properties.Resources.FondoMenuPracticas;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDinamico);
            this.Controls.Add(this.pnlMapa);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnConfig);
            this.Font = new System.Drawing.Font("Pokemon Classic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CMenuPracticas";
            this.Size = new System.Drawing.Size(1180, 620);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfig)).EndInit();
            this.pnlMapa.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoPractica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnConfig;
        private System.Windows.Forms.PictureBox btnInicio;
        private Class.ClasesPersonaje.CPlayer cPlayer1;
        private System.Windows.Forms.Panel pnlMapa;
        private System.Windows.Forms.Panel pnlDinamico;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnP2;
        private System.Windows.Forms.Button btnP1;
        private System.Windows.Forms.PictureBox pbIconoPractica;
        private System.Windows.Forms.Label lbPracticaTitulo;
        private System.Windows.Forms.Button btnP3;
    }
}
