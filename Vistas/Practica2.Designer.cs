namespace POO24A_HMFG.Vistas
{
    partial class Practica2
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
            this.tbLugar = new System.Windows.Forms.TextBox();
            this.rtbContenidoLugar = new System.Windows.Forms.RichTextBox();
            this.lbCordenadas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUbicacion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExportar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.tbAltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLugar
            // 
            this.tbLugar.Font = new System.Drawing.Font("Pokemon Classic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLugar.Location = new System.Drawing.Point(78, 39);
            this.tbLugar.Name = "tbLugar";
            this.tbLugar.Size = new System.Drawing.Size(313, 35);
            this.tbLugar.TabIndex = 1;
            this.tbLugar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLugar_KeyPress);
            // 
            // rtbContenidoLugar
            // 
            this.rtbContenidoLugar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbContenidoLugar.Location = new System.Drawing.Point(31, 82);
            this.rtbContenidoLugar.Name = "rtbContenidoLugar";
            this.rtbContenidoLugar.Size = new System.Drawing.Size(990, 508);
            this.rtbContenidoLugar.TabIndex = 0;
            this.rtbContenidoLugar.Text = "";
            // 
            // lbCordenadas
            // 
            this.lbCordenadas.AutoSize = true;
            this.lbCordenadas.Location = new System.Drawing.Point(18, 33);
            this.lbCordenadas.Name = "lbCordenadas";
            this.lbCordenadas.Size = new System.Drawing.Size(152, 21);
            this.lbCordenadas.TabIndex = 3;
            this.lbCordenadas.Text = "Cordenadas: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.lbUbicacion);
            this.panel1.Controls.Add(this.lbCordenadas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 631);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 122);
            this.panel1.TabIndex = 5;
            // 
            // lbUbicacion
            // 
            this.lbUbicacion.AutoSize = true;
            this.lbUbicacion.Location = new System.Drawing.Point(18, 71);
            this.lbUbicacion.Name = "lbUbicacion";
            this.lbUbicacion.Size = new System.Drawing.Size(123, 21);
            this.lbUbicacion.TabIndex = 5;
            this.lbUbicacion.Text = "Ubicacion: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1060, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 631);
            this.panel2.TabIndex = 6;
            // 
            // btnExportar
            // 
            this.btnExportar.BackgroundImage = global::POO24A_HMFG.Properties.Resources.exportar1;
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Location = new System.Drawing.Point(975, 35);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(40, 40);
            this.btnExportar.TabIndex = 7;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackgroundImage = global::POO24A_HMFG.Properties.Resources.busqueda;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(32, 34);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(40, 40);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // tbAltura
            // 
            this.tbAltura.Font = new System.Drawing.Font("Pokemon Classic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAltura.Location = new System.Drawing.Point(821, 41);
            this.tbAltura.Name = "tbAltura";
            this.tbAltura.Size = new System.Drawing.Size(139, 35);
            this.tbAltura.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(730, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Altura:";
            // 
            // Practica2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAltura);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.tbLugar);
            this.Controls.Add(this.rtbContenidoLugar);
            this.Font = new System.Drawing.Font("Pokemon Classic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Practica2";
            this.Text = "Practica2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox tbLugar;
        private System.Windows.Forms.RichTextBox rtbContenidoLugar;
        private System.Windows.Forms.Label lbCordenadas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lbUbicacion;
        private System.Windows.Forms.TextBox tbAltura;
        private System.Windows.Forms.Label label1;
    }
}