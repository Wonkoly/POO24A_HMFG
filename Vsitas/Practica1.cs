using POO24A_HMFG.Clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace POO24A_HMFG.Vsitas
{
    //-------------------------------------------------------------------------
    // Clase que representa a una persona tanto del genero femenino como masculino.
    // HMFG. 13/02/24.
    //-------------------------------------------------------------------------
    public partial class Practica1 : Form
    {
        //---------------------------------------------------------------------
        //ATRIBUTOS
        CCuerpo Monito;
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

        //---------------------------------------------------------------------
        //CONSTRUCTOR
        public Practica1()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            CPersona Persona;
            DateTime FechaNacimiento;
            r = new Random();
            int sexo, pesoEntero, estatura, ano, mes, dia;
            double peso;
            string nombreAleatorio, apellidoAleatorioP, apellidoAleatorioM;
            Point posicion;

            for (int i = 0; i < 100; i++)
            {
                sexo = r.Next(2);
                ano = r.Next(2000, 2024);
                mes = r.Next(1, 13);
                dia = r.Next(1, 29);
                estatura = r.Next(20, 36);
                peso = r.NextDouble();
                pesoEntero = r.Next(2, 4);
                peso = pesoEntero + peso;
                posicion = new Point(r.Next(0, 995), r.Next(0, 559));
    
                //Generamos nombres y apellidos aleatorios
                if (sexo == 0)
                {
                    nombreAleatorio = nombresFemeninos[r.Next(nombresFemeninos.Count)];
                }
                else
                {
                    nombreAleatorio = nombresMasculinos[r.Next(nombresMasculinos.Count)];
                }
                apellidoAleatorioM = apellidos[r.Next(apellidos.Count)];
                apellidoAleatorioP = apellidos[r.Next(apellidos.Count)];

                FechaNacimiento = new DateTime(ano, mes, dia);


                Persona = new CPersona(nombreAleatorio, apellidoAleatorioP, apellidoAleatorioM, FechaNacimiento, sexo, estatura, peso, posicion);
                int edad = Persona.GetDatosExtendidos().CalcularEdad();
                dgvTablaNombres.Rows.Add();
                dgvTablaNombres.Rows[i].Cells[0].Value = Persona.GetNombre();
                dgvTablaNombres.Rows[i].Cells[1].Value = Persona.GetApellidoPaterno();
                dgvTablaNombres.Rows[i].Cells[2].Value = Persona.GetApellidoMaterno();
                dgvTablaNombres.Rows[i].Cells[3].Value = Persona.GetDatosExtendidos().GetFechaNacimiento("yyyy/MM/dd");
                dgvTablaNombres.Rows[i].Cells[4].Value = edad;
                dgvTablaNombres.Rows[i].Cells[5].Value = Persona.GetDatosExtendidos().GetSexoNacimiento();
                dgvTablaNombres.Rows[i].Cells[6].Value = Persona.GetDatosExtendidos().GetEstatura();
                dgvTablaNombres.Rows[i].Cells[7].Value = Persona.GetDatosExtendidos().GetPeso();

                if (sexo == 0){
                    dgvTablaNombres.Rows[i].Cells[5].Style.BackColor = Color.Pink;
                    dgvTablaNombres.Rows[i].Cells[0].Style.BackColor = Color.Pink;
                }else{
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


                tbMonitos.Controls.Add(Persona);
            }
        }



        private void btnMonito_Click(object sender, EventArgs e)
        {
            Monito = new CCuerpo(new Point(100, 200));
            tbMonitos.Controls.Add(Monito);
        }
    }
}
