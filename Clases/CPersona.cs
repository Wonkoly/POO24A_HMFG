using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO24A_HMFG.Clases
{
    //-------------------------------------------------------------------------
    // Clase que representa a una persona tanto del genero femenino como masculino.
    // HMFG. 06/02/24.
    //-------------------------------------------------------------------------
    internal class CPersona : CCuerpo
    {
        //-------------------------------------------------------------------------
        // Atributos.
        //-------------------------------------------------------------------------
        private string Nombre;
        private string ApellidoPaterno;
        private string ApellidoMaterno;
        private DateTime FechaNacimiento;
        private int SexoNacimiento;
        private int Estatura;
        private double Peso;
        private string CURP;

        //-------------------------------------------------------------------------
        // Constructor.
        //-------------------------------------------------------------------------
        public CPersona(string Nombre, string ApellidoPaterno, string ApellidoMaterno,
                        DateTime FechaNacimiento, int SexoNacimiento, int Estatura,
                        double Peso, Point posicion) : base(posicion)
        {
            //Recibe parametros.
            this.Nombre = Nombre;
            this.ApellidoPaterno = ApellidoPaterno;
            this.ApellidoMaterno = ApellidoMaterno;
            this.FechaNacimiento = FechaNacimiento;
            this.SexoNacimiento = SexoNacimiento;
            this.Estatura = Estatura;
            this.Peso = Peso;

            //Eventos de las personas
            this.MouseEnter += CPersona_MauseEnter;
            this.MouseLeave += CPersona_MauseLeave;
        }
        private void CPersona_MauseEnter(object sender, EventArgs e)
        {

        }
        private void CPersona_MauseLeave(object sender, EventArgs e)
        {

        }
        //-------------------------------------------------------------------------
        // Obtiene el Nombre.
        //-------------------------------------------------------------------------
        public string GetNombre()
        {
            return Nombre;
        }
        //-------------------------------------------------------------------------
        // Obtiene el Apellido Paterno.
        //-------------------------------------------------------------------------
        public string GetApellidoPaterno()
        {
            return ApellidoPaterno;
        }
        //-------------------------------------------------------------------------
        // Obtiene el Apellido Materno.
        //-------------------------------------------------------------------------
        public string GetApellidoMaterno()
        {
            return ApellidoMaterno;
        }
        //-------------------------------------------------------------------------
        // Obtiene los datos extendidos.
        //-------------------------------------------------------------------------
        public CDatoExtendido GetDatosExtendidos()
        {
            CDatoExtendido DatoExtendido;

            DatoExtendido = new CDatoExtendido(FechaNacimiento, SexoNacimiento, Estatura, Peso);

            return DatoExtendido;
        }
    }
}
