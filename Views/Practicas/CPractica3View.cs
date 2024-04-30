using POO24A_HMFG.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO24A_HMFG.Views.Practicas
{
    public partial class CPractica3View : UserControl
    {
        //Variables Gobales
        Random rnd;
        CMovil Movil;
        public CPractica3View()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {

            rnd = new Random();
            CMovil Movil;

            Movil = new CMovil(rnd.Next(20, pnlArea.Size.Width), rnd.Next(20, pnlArea.Size.Height), pnlArea);
            Movil.Activar();
            Movil.Desplazar();
        }

        private void btnCambiarDireccion_Click(object sender, EventArgs e)
        {
            foreach (Control Control in pnlArea.Controls)
            {
                if (!(Control is CJugador))
                {
                    ((CMovil)Control).invertirDireccion();
                }
            }
        }
    }
}
