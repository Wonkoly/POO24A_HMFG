using POO24A_HMFG.Class;
using POO24A_HMFG.Class.ClasesPractica3;
using System;
using System.Windows.Forms;

namespace POO24A_HMFG.Views
{

    public partial class PracticaGame : Form
    {
        CMovil Movil;
        CBloqueador Bloqueador1;
        CBloqueador Bloqueador2;
        CBloqueador Bloqueador3;
        CBloqueador Bloqueador4;

        public PracticaGame()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            KeyPreview = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Movil = new CMovil(15, 15, pnlArea);
            Movil.Activar();
            Movil.Desplazar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crea bloqueadores horizontales.

            Bloqueador1 = new CBloqueador(0, 30, pnlArea, 2);
            Bloqueador1.Activar();

            Bloqueador2 = new CBloqueador(0, pnlArea.Height - 30, pnlArea, 2);
            Bloqueador2.Activar();

            // Crea Bloqueadores verticales.

            Bloqueador3 = new CBloqueador(30, 0, pnlArea, 1);
            Bloqueador3.Activar();

            Bloqueador4 = new CBloqueador(pnlArea.Width - 30, 0, pnlArea, 1);
            Bloqueador4.Activar();

        }
    }
}
