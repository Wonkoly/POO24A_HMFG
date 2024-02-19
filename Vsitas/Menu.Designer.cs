namespace POO24A_HMFG
{
    partial class Menu
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
            this.btnHumano = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHumano
            // 
            this.btnHumano.Location = new System.Drawing.Point(311, 90);
            this.btnHumano.Name = "btnHumano";
            this.btnHumano.Size = new System.Drawing.Size(178, 89);
            this.btnHumano.TabIndex = 0;
            this.btnHumano.Text = "Humano";
            this.btnHumano.UseVisualStyleBackColor = true;
            this.btnHumano.Click += new System.EventHandler(this.btnHumano_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 571);
            this.Controls.Add(this.btnHumano);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHumano;
    }
}

