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
            this.btnEjecutar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaNombres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEjecutar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTablaNombres
            // 
            this.dgvTablaNombres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvTablaNombres.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTablaNombres.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvTablaNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.dgvTablaNombres.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvTablaNombres.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvTablaNombres.Location = new System.Drawing.Point(0, 0);
            this.dgvTablaNombres.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvTablaNombres.Name = "dgvTablaNombres";
            this.dgvTablaNombres.RowHeadersWidth = 51;
            this.dgvTablaNombres.RowTemplate.Height = 24;
            this.dgvTablaNombres.Size = new System.Drawing.Size(602, 421);
            this.dgvTablaNombres.TabIndex = 1;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 121;
            // 
            // colApellidoP
            // 
            this.colApellidoP.HeaderText = "Apellido Paterno";
            this.colApellidoP.MinimumWidth = 6;
            this.colApellidoP.Name = "colApellidoP";
            this.colApellidoP.Width = 196;
            // 
            // colApellidoM
            // 
            this.colApellidoM.HeaderText = "Apellido Materno";
            this.colApellidoM.MinimumWidth = 6;
            this.colApellidoM.Name = "colApellidoM";
            this.colApellidoM.Width = 196;
            // 
            // colFechaN
            // 
            this.colFechaN.HeaderText = "Fecha Nacimiento";
            this.colFechaN.MinimumWidth = 6;
            this.colFechaN.Name = "colFechaN";
            this.colFechaN.Width = 203;
            // 
            // colEdad
            // 
            this.colEdad.HeaderText = "Edad";
            this.colEdad.MinimumWidth = 6;
            this.colEdad.Name = "colEdad";
            this.colEdad.Width = 93;
            // 
            // colSexo
            // 
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.MinimumWidth = 6;
            this.colSexo.Name = "colSexo";
            this.colSexo.Width = 95;
            // 
            // colEstatura
            // 
            this.colEstatura.HeaderText = "Estatura";
            this.colEstatura.MinimumWidth = 6;
            this.colEstatura.Name = "colEstatura";
            this.colEstatura.Width = 139;
            // 
            // colPeso
            // 
            this.colPeso.HeaderText = "Peso";
            this.colPeso.MinimumWidth = 6;
            this.colPeso.Name = "colPeso";
            this.colPeso.Width = 93;
            // 
            // colRFC
            // 
            this.colRFC.HeaderText = "RFC";
            this.colRFC.MinimumWidth = 6;
            this.colRFC.Name = "colRFC";
            this.colRFC.Width = 84;
            // 
            // colDepartamento
            // 
            this.colDepartamento.HeaderText = "Departamento";
            this.colDepartamento.MinimumWidth = 6;
            this.colDepartamento.Name = "colDepartamento";
            this.colDepartamento.Width = 193;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(224, 428);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(129, 50);
            this.btnEjecutar.TabIndex = 2;
            this.btnEjecutar.TabStop = false;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // CPractica1View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.dgvTablaNombres);
            this.Font = new System.Drawing.Font("Pokemon Classic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CPractica1View";
            this.Size = new System.Drawing.Size(602, 496);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaNombres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEjecutar)).EndInit();
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
        private System.Windows.Forms.PictureBox btnEjecutar;
    }
}
