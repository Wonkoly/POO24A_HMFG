using POO24A_HMFG.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace POO24A_HMFG.Views.Practicas
{
    public partial class CPractica1View : UserControl
    {
        //---------------------------------------------------------------------
        //ATRIBUTOS
        Random r;

        // Lista de nombres masculinos
        List<string> nombresMasculinos = new List<string>
        {
            "Juan",
            "Pedro",
            "Luis",
            "Carlos",
            "Gael",
            "Martin",
            "Jose",
            "Paul",
            "Sebastian",
            "Damian"
        };

        // Lista de nombres femeninos
        List<string> nombresFemeninos = new List<string>
        {
            "María",
            "Ana",
            "Laura",
            "Sofía",
            "Claudia",
            "Paula",
            "Fabiola",
            "Luisa",
            "Karen"
        };

        // Lista de apellidos
        List<string> apellidos = new List<string>
        {
            "García",
            "Martínez",
            "Hernández",
            "López",
            "Carrillo",
            "Esparza",
            "Magaña",
            "Fornica"
        };

        Dictionary<int, string> Departamentos = new Dictionary<int, string>
        {
            { 1, "RH" },
            { 2, "Ventas" },
            { 3, "Mantenimiento" },
            { 4, "Administracion"},
            { 5, "Operaciones"},
            { 6, "Personal"},
            { 7, "Nada"}
        };

        //---------------------------------------------------------------------
        //CONSTRUCTOR
        public CPractica1View()
        {
            InitializeComponent();

        }

        //---------------------------------------------------------------------
        //BOTON EJECUTAR
        private void btnEjecutar_Click_1(object sender, EventArgs e)
        {
            //------------------------------------------------------------------
            // Variables
            CPersona Persona;
            DateTime FechaNacimiento;
            r = new Random();
            int sexo, pesoEntero, estatura, ano, mes, dia, departamento, tipoPersona, edad;
            double peso;
            string nombreAleatorio, apellidoAleatorioP, apellidoAleatorioM;

            //------------------------------------------------------------------
            // Inicio de Ciclo para llenar la tablita :3
            for (int i = 0; i < 100; i++)
            {

                //------------------------------------------------------------------
                // Inicilaizamos datos de la persona de manera aleatoria
                sexo = r.Next(2);
                ano = r.Next(2000, 2024);
                mes = r.Next(1, 13);
                dia = r.Next(1, 29);
                estatura = r.Next(20, 36);
                peso = r.NextDouble();
                pesoEntero = r.Next(2, 4);
                peso = pesoEntero + peso;
                FechaNacimiento = new DateTime(ano, mes, dia);
                departamento = r.Next(1, Departamentos.Count);
                tipoPersona = r.Next(2);

                //------------------------------------------------------------------
                // Generamos nombres deacuerdo a su sexo
                if (sexo == 0)
                {
                    nombreAleatorio = nombresFemeninos[r.Next(nombresFemeninos.Count)];
                }
                else
                {
                    nombreAleatorio = nombresMasculinos[r.Next(nombresMasculinos.Count)];
                }

                //------------------------------------------------------------------
                // Generamos apellidos
                apellidoAleatorioM = apellidos[r.Next(apellidos.Count)];
                apellidoAleatorioP = apellidos[r.Next(apellidos.Count)];

                //------------------------------------------------------------------
                // Generamos apellidos
                if (tipoPersona == 0)
                {
                    Persona = new CPersona(nombreAleatorio, apellidoAleatorioP, apellidoAleatorioM, FechaNacimiento, sexo, estatura, peso);
                }
                else
                {
                    Persona = new CColaborador(nombreAleatorio, apellidoAleatorioP, apellidoAleatorioM, FechaNacimiento, sexo, estatura, peso, departamento);
                }

                //------------------------------------------------------------------
                // Llenamos la tabla con lo datos
                edad = Persona.GetDatosExtendidos().CalcularEdad();
                dgvTablaNombres.Rows.Add();
                dgvTablaNombres.Rows[i].Cells[0].Value = Persona.GetNombre();
                dgvTablaNombres.Rows[i].Cells[1].Value = Persona.GetApellidoPaterno();
                dgvTablaNombres.Rows[i].Cells[2].Value = Persona.GetApellidoMaterno();
                dgvTablaNombres.Rows[i].Cells[3].Value = Persona.GetDatosExtendidos().GetFechaNacimiento("yyyy/MM/dd");
                dgvTablaNombres.Rows[i].Cells[4].Value = edad;

                dgvTablaNombres.Rows[i].Cells[6].Value = Persona.GetDatosExtendidos().GetEstatura();
                dgvTablaNombres.Rows[i].Cells[7].Value = Persona.GetDatosExtendidos().GetPeso();


                if (Persona.GetType() == typeof(CColaborador))
                {

                    dgvTablaNombres.Rows[i].Cells[8].Value = ((CColaborador)Persona).GetRFC();
                    dgvTablaNombres.Rows[i].Cells[9].Value = Departamentos[((CColaborador)Persona).GetDepartamento()];

                    dgvTablaNombres.Rows[i].Cells[8].Style.BackColor = Color.Aqua;
                    dgvTablaNombres.Rows[i].Cells[9].Style.BackColor = Color.Aqua;
                }


                if (sexo == 0)
                {
                    dgvTablaNombres.Rows[i].Cells[5].Value = "Femenino";
                    dgvTablaNombres.Rows[i].Cells[5].Style.BackColor = Color.Pink;
                    dgvTablaNombres.Rows[i].Cells[0].Style.BackColor = Color.Pink;
                }
                else
                {
                    dgvTablaNombres.Rows[i].Cells[5].Value = "Masculino";
                    dgvTablaNombres.Rows[i].Cells[5].Style.BackColor = Color.AliceBlue;
                    dgvTablaNombres.Rows[i].Cells[0].Style.BackColor = Color.AliceBlue;
                }

                if (apellidoAleatorioP == apellidoAleatorioM)
                {
                    dgvTablaNombres.Rows[i].Cells[1].Style.BackColor = Color.LightYellow;
                    dgvTablaNombres.Rows[i].Cells[2].Style.BackColor = Color.LightYellow;
                }

                if (peso >= 3.5)
                {
                    dgvTablaNombres.Rows[i].Cells[7].Style.BackColor = Color.Coral;
                }

                if (edad >= 18)
                {
                    dgvTablaNombres.Rows[i].Cells[4].Style.BackColor = Color.LightGreen;
                }
            }
        }

        private void btnEjecutar_MouseEnter(object sender, EventArgs e)
        {
            btnEjecutar.Image = Properties.Resources.btnPlantilla2;
            btnEjecutar.ForeColor = Color.LightGray;
        }

        private void btnEjecutar_MouseLeave(object sender, EventArgs e)
        {
            btnEjecutar.Image = Properties.Resources.btnPlantilla1;
            btnEjecutar.ForeColor = Color.White;
        }
    }
}
