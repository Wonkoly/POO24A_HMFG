using POO24A_HMFG.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO24A_HMFG.Views
{
    public partial class PracticaGame : Form
    {
        //Variables Globales
        Random rnd;
        private CJugador J1, J2, JP1;
        public PracticaGame()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rnd = new Random();
            CMovil Movil;

            Movil = new CMovil(rnd.Next(20, pnlArea.Size.Width), rnd.Next(20, pnlArea.Size.Height), pnlArea);
            Movil.Activar();
            Movil.Desplazar();
        }

        private void btnCrearBloqueador_Click(object sender, EventArgs e)
        {

            J1 = new CJugador(0,30, pnlArea, "Horizontal");
            J1.Activar();
            ////J1.Desplazar();

            J2 = new CJugador(0, pnlArea.Height - 30, pnlArea, "Horizontal");
            J2.Activar();
            //J1.Desplazar();
            
            JP1 = new CJugador(30, 0, pnlArea, "Vertical");
            JP1.Activar();


            JP1 = new CJugador(pnlArea.Width - 30, 0, pnlArea, "Vertical");
            JP1.Activar();
        }

        private void btnJugadoresLaterales_Click(object sender, EventArgs e)
        {


        }

        private void PracticaGame_KeyDown(object sender, KeyEventArgs e)
        {
            
            if(e.KeyValue == 'A')
            {
                J1.Desplazar(1);   
            }

            if(e.KeyValue == 'D')
            {

                J1.Desplazar(2);   
            }

            if(e.KeyValue == 'J')
            {

                J2.Desplazar(1);   
            }

            if(e.KeyValue == 'L')
            {

                J2.Desplazar(2);   
            }
        }
    }
}
