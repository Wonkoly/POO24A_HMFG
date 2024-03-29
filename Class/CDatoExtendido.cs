using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO24A_HMFG.Class
{
    internal class CDatoExtendido
    {
        //----- ATRIBUTOS:
        private DateTime FechaNacimiento;
        private int SexoNacimiento;
        private int Estatura;
        private double Peso;
        private int edad;
        public CDatoExtendido(DateTime fechaNacimeinto, int sexoNacimiento, int estatura, double peso)
        {
            this.FechaNacimiento = fechaNacimeinto;
            this.SexoNacimiento = sexoNacimiento;
            this.Estatura = estatura;
            this.Peso = peso;
        }

        public DateTime GetFechaNacimiento()
        {
            return FechaNacimiento;
        }
        public int GetSexoNacimiento()
        {
            return SexoNacimiento;
        }
        public int GetEstatura()
        {
            return Estatura;
        }
        public double GetPeso()
        {
            return Peso;
        }
        public String GetFechaNacimiento(string Formato)
        {
            return FechaNacimiento.ToString(Formato);
        }
        public int CalcularEdad()
        {
            DateTime fechaActual, fechaNacimiento;
            fechaActual = DateTime.Today;
            fechaNacimiento = FechaNacimiento;

            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Restar un año si la fecha actual es anterior al día del cumpleaños
            if (fechaNacimiento.Date > fechaActual.Date.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }
    }
}
