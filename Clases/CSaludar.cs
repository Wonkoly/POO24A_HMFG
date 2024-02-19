using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO24A_HMFG.Clases
{
    //-------------------------------------------------------------------------
    // Clase para construir objetos saludadores.
    // FGHM. 23/01/2024
    //-------------------------------------------------------------------------
    public class CSaludar
    {
        //-------------------------------------------------------------------------
        // Atributos.
        //-------------------------------------------------------------------------
        private string Mensaje;

        //-------------------------------------------------------------------------
        // Constructor.
        //-------------------------------------------------------------------------
        public CSaludar(string Mensaje)
        {
            this.Mensaje = Mensaje;
        }
        //-------------------------------------------------------------------------
        // Genera saludo.
        //-------------------------------------------------------------------------
        public void GeneraSaludo()
        {
            MessageBox.Show("Hola Mundo. " + Mensaje);
        }
    }
}
