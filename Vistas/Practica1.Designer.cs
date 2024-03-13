namespace POO24A_HMFG.Vsitas
{
    partial class Practica1
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.tabPracticas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.tbMonitos = new System.Windows.Forms.TabPage();
            this.pnlPrincipal.SuspendLayout();
            this.tabPracticas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaNombres)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPrincipal.BackColor = System.Drawing.Color.Ivory;
            this.pnlPrincipal.Controls.Add(this.tabPracticas);
            this.pnlPrincipal.Location = new System.Drawing.Point(84, 63);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1082, 544);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // tabPracticas
            // 
            this.tabPracticas.Controls.Add(this.tabPage1);
            this.tabPracticas.Controls.Add(this.tbMonitos);
            this.tabPracticas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPracticas.Location = new System.Drawing.Point(0, 0);
            this.tabPracticas.Name = "tabPracticas";
            this.tabPracticas.SelectedIndex = 0;
            this.tabPracticas.Size = new System.Drawing.Size(1082, 544);
            this.tabPracticas.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Ivory;
            this.tabPage1.Controls.Add(this.dgvTablaNombres);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1074, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tabla";
            // 
            // dgvTablaNombres
            // 
            this.dgvTablaNombres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTablaNombres.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTablaNombres.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
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
            this.dgvTablaNombres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTablaNombres.Location = new System.Drawing.Point(3, 3);
            this.dgvTablaNombres.Name = "dgvTablaNombres";
            this.dgvTablaNombres.RowHeadersWidth = 51;
            this.dgvTablaNombres.RowTemplate.Height = 24;
            this.dgvTablaNombres.Size = new System.Drawing.Size(1068, 504);
            this.dgvTablaNombres.TabIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            // 
            // colApellidoP
            // 
            this.colApellidoP.HeaderText = "Apellido Paterno";
            this.colApellidoP.MinimumWidth = 6;
            this.colApellidoP.Name = "colApellidoP";
            // 
            // colApellidoM
            // 
            this.colApellidoM.HeaderText = "Apellido Materno";
            this.colApellidoM.MinimumWidth = 6;
            this.colApellidoM.Name = "colApellidoM";
            // 
            // colFechaN
            // 
            this.colFechaN.HeaderText = "Fecha Nacimiento";
            this.colFechaN.MinimumWidth = 6;
            this.colFechaN.Name = "colFechaN";
            // 
            // colEdad
            // 
            this.colEdad.HeaderText = "Edad";
            this.colEdad.MinimumWidth = 6;
            this.colEdad.Name = "colEdad";
            // 
            // colSexo
            // 
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.MinimumWidth = 6;
            this.colSexo.Name = "colSexo";
            // 
            // colEstatura
            // 
            this.colEstatura.HeaderText = "Estatura";
            this.colEstatura.MinimumWidth = 6;
            this.colEstatura.Name = "colEstatura";
            // 
            // colPeso
            // 
            this.colPeso.HeaderText = "Peso";
            this.colPeso.MinimumWidth = 6;
            this.colPeso.Name = "colPeso";
            // 
            // colRFC
            // 
            this.colRFC.HeaderText = "RFC";
            this.colRFC.MinimumWidth = 6;
            this.colRFC.Name = "colRFC";
            // 
            // colDepartamento
            // 
            this.colDepartamento.HeaderText = "Departamento";
            this.colDepartamento.MinimumWidth = 6;
            this.colDepartamento.Name = "colDepartamento";
            // 
            // tbMonitos
            // 
            this.tbMonitos.Location = new System.Drawing.Point(4, 30);
            this.tbMonitos.Name = "tbMonitos";
            this.tbMonitos.Padding = new System.Windows.Forms.Padding(3);
            this.tbMonitos.Size = new System.Drawing.Size(1074, 488);
            this.tbMonitos.TabIndex = 1;
            this.tbMonitos.Text = "Monitos";
            this.tbMonitos.UseVisualStyleBackColor = true;
            // 
            // Practica1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pnlPrincipal);
            this.Font = new System.Drawing.Font("Pokemon Classic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Practica1";
            this.Text = "Practica1";
            this.pnlPrincipal.ResumeLayout(false);
            this.tabPracticas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaNombres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.TabControl tabPracticas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tbMonitos;
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
    }
}