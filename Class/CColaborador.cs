using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO24A_HMFG.Class
{
    internal class CColaborador : CPersona
    {
        //-------------------------------------------------------------------------
        // Atributos.
        //-------------------------------------------------------------------------
        private int Departamento; //1 = RR.HH. , 2 Ventas, 3 = Mantenimiento. 

        //-------------------------------------------------------------------------
        // Constructor.
        //-------------------------------------------------------------------------
        public CColaborador(string Nombre, string ApellidoPaterno, string ApellidoMaterno, DateTime FechaNacimiento,
        int SexoNacimiento, int Estatura, double Peso, int Departamento) : base(Nombre, ApellidoPaterno,
        ApellidoPaterno, FechaNacimiento, SexoNacimiento, Estatura, Peso)
        {
            this.Departamento = Departamento;
        }
        //-------------------------------------------------------------------------
        // Obtiene el RFC del colaborador.
        //-------------------------------------------------------------------------
        public string GetRFC()
        {
            string RFC;

            RFC = ApellidoPaterno.Substring(0, 2);
            RFC = ApellidoMaterno.Substring(0, 1);
            RFC = Nombre.Substring(0, 1);
            RFC = RFC + GetDatosExtendidos().GetFechaNacimiento("yyMMdd");
            RFC = RFC + "xyz";
            RFC = RFC.ToUpper();

            return RFC;
        }
        //-------------------------------------------------------------------------
        // Obtiene el RFC del colaborador.
        //-------------------------------------------------------------------------
        public int GetDepartamento()
        {
            return this.Departamento;
        }
    }
}
