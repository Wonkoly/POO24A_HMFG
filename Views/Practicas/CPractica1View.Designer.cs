namespace POO24A_HMFG.Views.Practicas
{
    partial class CPractica1View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTablaNombres = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEjecutar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaNombres)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTablaNombres
            // 
            this.dgvTablaNombres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTablaNombres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTablaNombres.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTablaNombres.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvTablaNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaNombres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTablaNombres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaNombres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colApellidoP,
            this.colApellidoM,
            this.colFechaN,
            this.colEdad,
            this.colSexo,
            this.colEstatura,
            this.colPeso,
            this.colRFC,
            this.colDepartamento});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablaNombres.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTablaNombres.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvTablaNombres.Location = new System.Drawing.Point(0, 0);
            this.dgvTablaNombres.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvTablaNombres.Name = "dgvTablaNombres";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaNombres.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTablaNombres.RowHeadersWidth = 51;
            this.dgvTablaNombres.RowTemplate.Height = 24;
            this.dgvTablaNombres.Size = new System.Drawing.Size(637, 361);
            this.dgvTablaNombres.TabIndex = 1;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 85;
            // 
            // colApellidoP
            // 
            this.colApellidoP.HeaderText = "Apellido Paterno";
            this.colApellidoP.MinimumWidth = 6;
            this.colApellidoP.Name = "colApellidoP";
            this.colApellidoP.Width = 125;
            // 
            // colApellidoM
            // 
            this.colApellidoM.HeaderText = "Apellido Materno";
            this.colApellidoM.MinimumWidth = 6;
            this.colApellidoM.Name = "colApellidoM";
            this.colApellidoM.Width = 127;
            // 
            // colFechaN
            // 
            this.colFechaN.HeaderText = "Fecha Nacimiento";
            this.colFechaN.MinimumWidth = 6;
            this.colFechaN.Name = "colFechaN";
            this.colFechaN.Width = 133;
            // 
            // colEdad
            // 
            this.colEdad.HeaderText = "Edad";
            this.colEdad.MinimumWidth = 6;
            this.colEdad.Name = "colEdad";
            this.colEdad.Width = 69;
            // 
            // colSexo
            // 
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.MinimumWidth = 6;
            this.colSexo.Name = "colSexo";
            this.colSexo.Width = 67;
            // 
            // colEstatura
            // 
            this.colEstatura.HeaderText = "Estatura";
            this.colEstatura.MinimumWidth = 6;
            this.colEstatura.Name = "colEstatura";
            this.colEstatura.Width = 85;
            // 
            // colPeso
            // 
            this.colPeso.HeaderText = "Peso";
            this.colPeso.MinimumWidth = 6;
            this.colPeso.Name = "colPeso";
            this.colPeso.Width = 68;
            // 
            // colRFC
            // 
            this.colRFC.HeaderText = "RFC";
            this.colRFC.MinimumWidth = 6;
            this.colRFC.Name = "colRFC";
            this.colRFC.Width = 63;
            // 
            // colDepartamento
            // 
            this.colDepartamento.HeaderText = "Departamento";
            this.colDepartamento.MinimumWidth = 6;
            this.colDepartamento.Name = "colDepartamento";
            this.colDepartamento.Width = 122;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEjecutar.BackColor = System.Drawing.Color.Transparent;
            this.btnEjecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEjecutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjecutar.FlatAppearance.BorderSize = 0;
            this.btnEjecutar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEjecutar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjecutar.Font = new System.Drawing.Font("Pokemon Classic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEjecutar.Image = global::POO24A_HMFG.Properties.Resources.btnPlantilla1;
            this.btnEjecutar.Location = new System.Drawing.Point(184, 369);
            this.btnEjecutar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(273, 80);
            this.btnEjecutar.TabIndex = 14;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = false;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click_1);
            this.btnEjecutar.MouseEnter += new System.EventHandler(this.btnEjecutar_MouseEnter);
            this.btnEjecutar.MouseLeave += new System.EventHandler(this.btnEjecutar_MouseLeave);
            // 
            // CPractica1View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.dgvTablaNombres);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CPractica1View";
            this.Size = new System.Drawing.Size(637, 459);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaNombres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTablaNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartamento;
        private System.Windows.Forms.Button btnEjecutar;
    }
}
