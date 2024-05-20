namespace POO24A_HMFG.Views.Practicas
{
    partial class CPractica2View
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
            this.tbLugar = new System.Windows.Forms.TextBox();
            this.rtbContenidoLugar = new System.Windows.Forms.RichTextBox();
            this.tbAltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUbicacion = new System.Windows.Forms.Label();
            this.lbCordenadas = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLugar
            // 
            this.tbLugar.Font = new System.Drawing.Font("Pokemon Classic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLugar.Location = new System.Drawing.Point(3, 8);
            this.tbLugar.Name = "tbLugar";
            this.tbLugar.Size = new System.Drawing.Size(224, 40);
            this.tbLugar.TabIndex = 2;
            this.tbLugar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLugar_KeyPress_1);
            // 
            // rtbContenidoLugar
            // 
            this.rtbContenidoLugar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbContenidoLugar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbContenidoLugar.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbContenidoLugar.Location = new System.Drawing.Point(3, 52);
            this.rtbContenidoLugar.Name = "rtbContenidoLugar";
            this.rtbContenidoLugar.Size = new System.Drawing.Size(631, 333);
            this.rtbContenidoLugar.TabIndex = 3;
            this.rtbContenidoLugar.Text = "";
            // 
            // tbAltura
            // 
            this.tbAltura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAltura.Font = new System.Drawing.Font("Pokemon Classic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAltura.Location = new System.Drawing.Point(482, 8);
            this.tbAltura.Name = "tbAltura";
            this.tbAltura.Size = new System.Drawing.Size(103, 40);
            this.tbAltura.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pokemon Classic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Altura:";
            // 
            // lbUbicacion
            // 
            this.lbUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUbicacion.AutoSize = true;
            this.lbUbicacion.Location = new System.Drawing.Point(6, 398);
            this.lbUbicacion.Name = "lbUbicacion";
            this.lbUbicacion.Size = new System.Drawing.Size(123, 21);
            this.lbUbicacion.TabIndex = 12;
            this.lbUbicacion.Text = "Ubicacion: ";
            // 
            // lbCordenadas
            // 
            this.lbCordenadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCordenadas.AutoSize = true;
            this.lbCordenadas.Location = new System.Drawing.Point(6, 429);
            this.lbCordenadas.Name = "lbCordenadas";
            this.lbCordenadas.Size = new System.Drawing.Size(152, 21);
            this.lbCordenadas.TabIndex = 11;
            this.lbCordenadas.Text = "Cordenadas: ";
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.Image = global::POO24A_HMFG.Properties.Resources.btnExportar1;
            this.btnExportar.Location = new System.Drawing.Point(590, 6);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(40, 40);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.TabStop = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click_1);
            this.btnExportar.MouseEnter += new System.EventHandler(this.btnExportar_MouseEnter);
            this.btnExportar.MouseLeave += new System.EventHandler(this.btnExportar_MouseLeave);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::POO24A_HMFG.Properties.Resources.btnBuscar1;
            this.btnBuscar.Location = new System.Drawing.Point(233, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 40);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            this.btnBuscar.MouseEnter += new System.EventHandler(this.btnBuscar_MouseEnter);
            this.btnBuscar.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            // 
            // CPractica2View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbUbicacion);
            this.Controls.Add(this.lbCordenadas);
            this.Controls.Add(this.tbAltura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.rtbContenidoLugar);
            this.Controls.Add(this.tbLugar);
            this.Font = new System.Drawing.Font("Pokemon Classic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CPractica2View";
            this.Size = new System.Drawing.Size(637, 459);
            ((System.ComponentModel.ISupportInitialize)(this.btnExportar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLugar;
        private System.Windows.Forms.RichTextBox rtbContenidoLugar;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.PictureBox btnExportar;
        private System.Windows.Forms.TextBox tbAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUbicacion;
        private System.Windows.Forms.Label lbCordenadas;
    }
}
