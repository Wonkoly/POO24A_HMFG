namespace POO24A_HMFG.Views.Practicas
{
    partial class CPractica3View
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
            this.ContenedorSplit = new System.Windows.Forms.SplitContainer();
            this.pnlArea = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnCambiarDireccion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ContenedorSplit)).BeginInit();
            this.ContenedorSplit.Panel1.SuspendLayout();
            this.ContenedorSplit.Panel2.SuspendLayout();
            this.ContenedorSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlArea)).BeginInit();
            this.SuspendLayout();
            // 
            // ContenedorSplit
            // 
            this.ContenedorSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorSplit.Location = new System.Drawing.Point(0, 0);
            this.ContenedorSplit.Name = "ContenedorSplit";
            // 
            // ContenedorSplit.Panel1
            // 
            this.ContenedorSplit.Panel1.BackColor = System.Drawing.Color.LightGray;
            this.ContenedorSplit.Panel1.Controls.Add(this.pnlArea);
            this.ContenedorSplit.Panel1MinSize = 250;
            // 
            // ContenedorSplit.Panel2
            // 
            this.ContenedorSplit.Panel2.Controls.Add(this.btnCambiarDireccion);
            this.ContenedorSplit.Panel2.Controls.Add(this.btnPlay);
            this.ContenedorSplit.Panel2MinSize = 100;
            this.ContenedorSplit.Size = new System.Drawing.Size(602, 496);
            this.ContenedorSplit.SplitterDistance = 471;
            this.ContenedorSplit.SplitterWidth = 5;
            this.ContenedorSplit.TabIndex = 0;
            // 
            // pnlArea
            // 
            this.pnlArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlArea.Location = new System.Drawing.Point(0, 0);
            this.pnlArea.Name = "pnlArea";
            this.pnlArea.Size = new System.Drawing.Size(471, 496);
            this.pnlArea.TabIndex = 0;
            this.pnlArea.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlay.Location = new System.Drawing.Point(0, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(126, 44);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnCambiarDireccion
            // 
            this.btnCambiarDireccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCambiarDireccion.Location = new System.Drawing.Point(0, 44);
            this.btnCambiarDireccion.Name = "btnCambiarDireccion";
            this.btnCambiarDireccion.Size = new System.Drawing.Size(126, 63);
            this.btnCambiarDireccion.TabIndex = 1;
            this.btnCambiarDireccion.Text = "Cambiar Direccion";
            this.btnCambiarDireccion.UseVisualStyleBackColor = true;
            this.btnCambiarDireccion.Click += new System.EventHandler(this.btnCambiarDireccion_Click);
            // 
            // CPractica3View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContenedorSplit);
            this.Font = new System.Drawing.Font("Pokemon Classic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CPractica3View";
            this.Size = new System.Drawing.Size(602, 496);
            this.ContenedorSplit.Panel1.ResumeLayout(false);
            this.ContenedorSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContenedorSplit)).EndInit();
            this.ContenedorSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer ContenedorSplit;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox pnlArea;
        private System.Windows.Forms.Button btnCambiarDireccion;
    }
}
