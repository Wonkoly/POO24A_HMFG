using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO24A_HMFG.Clases
{
    //------------------------------------------------------------------------
    //Clase que crea humanos xd
    //HMFG 30/01/2024
    //------------------------------------------------------------------------
    public class CHumano
    {
        //-------------------------------------------------------------------------
        // Atributos.
        //-------------------------------------------------------------------------
        private string Nombre;
        private string ApellidoPaterno;
        private string ApellidoMaterno;
        private DateTime FechaNacimiento;
        private int Estatura;
        private Color ColorPiel;
        private double Peso;
        private string CURP;
        private Color ColorOjos;
        private int TipoCabello;
        private Color ColorCabello;
        private int TipoSangre;
        private int Nacionalidad;
        private int TallaRopa;
        private List<int> Alergias;
        private int Ocupaciones;
        private int EstadoCivil;
        private List<int> Enfermedades;
        private int SexoNacimiento;
        private int OrientacionSexual;
        private int GeneroSexual;

        //-------------------------------------------------------------------------
        // Constructor.
        //-------------------------------------------------------------------------
        public CHumano(DateTime FechaNacimiento, int SexoNacimiento, int Estatura, double Peso)
        {
            //Recibe parametros.
            this.FechaNacimiento = FechaNacimiento;
            this.SexoNacimiento = SexoNacimiento;
            this.Estatura = Estatura;
            this.Peso = Peso;

            //Inicializa Atributos.
            Nombre = "";
            ApellidoPaterno = "";
            ApellidoMaterno = "";
            Nacionalidad = 125; // Por defecto un humano nace mexicano.
        }
        //-------------------------------------------------------------------------
        // Provoca que el humano hable.
        //-------------------------------------------------------------------------
        // Valor de retorno(int):
        // 0 = Exito.
        // 1 = Error tipo 1: no hablo por ...
        // 2 = Error tipo 2: No hablo por ...
        public int Habla(string Frase)
        {
            int ValorRetorno = 0;

            // Algoritmo para hablar.

            return ValorRetorno; // Hablo con exito.
        }
        //-------------------------------------------------------------------------
        // Provoca que el humano llore.
        //-------------------------------------------------------------------------
        // Valor de retorno (bool):
        // True = Exito.
        // False = No pudo llorar.
        public bool Llora(int NivelDolor)
        {
            bool ValorRetorno = true;

            // Algoritmo para llorar.

            return ValorRetorno;
        }
        //-------------------------------------------------------------------------
        //
        //-------------------------------------------------------------------------
        public int Camina(int NumPasos)
        {
            return 0;
        }
        //-------------------------------------------------------------------------
        //
        //-------------------------------------------------------------------------
        public bool Grita(int Motivo)
        {
            return false;
        }
        //-------------------------------------------------------------------------
        //
        //-------------------------------------------------------------------------
        private int come()
        {
            return 0;
        }
        //-------------------------------------------------------------------------
        //
        //-------------------------------------------------------------------------
        public bool Rie(int NivelRisa)
        {
            return true;
        }
        //-------------------------------------------------------------------------
        //
        //-------------------------------------------------------------------------    
        private void parpadear(int NumVeces)
        {

        }
        //-------------------------------------------------------------------------
        //
        //-------------------------------------------------------------------------
        public int Muere(int Causal, int NivelRiesgo)
        {
            return 0;
        }
        //-------------------------------------------------------------------------
        //
        //-------------------------------------------------------------------------
        private bool Nada(int Tipo, DateTime Tiempo)
        {
            return true;
        }
        //-------------------------------------------------------------------------
        //
        //-------------------------------------------------------------------------
        public bool Defeca(int Cantidad, int Tipo, int NivelIntensidad)
        {
            return false;
        }
        //-------------------------------------------------------------------------
        //
        //-------------------------------------------------------------------------
        private int Respira(int Frecuencia)
        {
            return 0;
        }
        //-------------------------------------------------------------------------
        //
        //-------------------------------------------------------------------------
        public int Escribe(int Texto)
        {
            return 0;
        }
        //-------------------------------------------------------------------------
        //
        //-------------------------------------------------------------------------=
        public bool Crece(int NivelCrecimiento)
        {
            return true;
        }
        //-------------------------------------------------------------------------
        //
        //-------------------------------------------------------------------------
        public bool Orina(Color Color, int Cantidad, int NivelIntensidad)
        {
            return true;
        }
        //-------------------------------------------------------------------------
        //
        //-------------------------------------------------------------------------
        public int Reproduce(int Causal, int NivelIntensidad, CHumano Humano)
        {
            return 0;
        }
        //-------------------------------------------------------------------------
        //
        //-------------------------------------------------------------------------
        public int RelacionSexual(int Causal, int NivelIntensidad, List<CHumano> Humanos)
        {
            return 0;
        }
    }
}
