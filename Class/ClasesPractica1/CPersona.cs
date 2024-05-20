using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO24A_HMFG.Class
{
    internal class CPersona
    {
        //-------------------------------------------------------------------------
        // Atributos.
        protected string Nombre;
        protected string ApellidoPaterno;
        protected string ApellidoMaterno;
        protected DateTime FechaNacimiento;
        private int SexoNacimiento;
        private int Estatura;
        private double Peso;
        private string CURP;

        //-------------------------------------------------------------------------
        // Constructor.
        public CPersona(string Nombre, string ApellidoPaterno, string ApellidoMaterno,
                        DateTime FechaNacimiento, int SexoNacimiento, int Estatura,
                        double Peso)
        {
            //Recibe parametros.
            this.Nombre = Nombre;
            this.ApellidoPaterno = ApellidoPaterno;
            this.ApellidoMaterno = ApellidoMaterno;
            this.FechaNacimiento = FechaNacimiento;
            this.SexoNacimiento = SexoNacimiento;
            this.Estatura = Estatura;
            this.Peso = Peso;
        }

        //-------------------------------------------------------------------------
        // Obtiene el Nombre.
        public string GetNombre()
        {
            return Nombre;
        }

        //-------------------------------------------------------------------------
        // Obtiene el Apellido Paterno.
        public string GetApellidoPaterno()
        {
            return ApellidoPaterno;
        }

        //-------------------------------------------------------------------------
        // Obtiene el Apellido Materno.
        public string GetApellidoMaterno()
        {
            return ApellidoMaterno;
        }

        //-------------------------------------------------------------------------
        // Obtiene los datos extendidos.
        public CDatoExtendido GetDatosExtendidos()
        {
            CDatoExtendido DatoExtendido;

            DatoExtendido = new CDatoExtendido(FechaNacimiento, SexoNacimiento, Estatura, Peso);

            return DatoExtendido;
        }
    }
}
