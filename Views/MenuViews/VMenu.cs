using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO24A_HMFG.Views.MenuViews
{
    public partial class VMenu : Form
    {
        public VMenu()
        {
            InitializeComponent();

            //Cargar CMenuInit
            CMenuInit menuInit = new CMenuInit();
            menuInit.Dock = DockStyle.Fill;
            pnlContenido.Controls.Clear();
            pnlContenido.Controls.Add(menuInit);

            CheckForIllegalCrossThreadCalls = false;
            KeyPreview = true;

        }

        public void mostrarMenuPracticas()
        {
            CMenuPracticas menuPracticas = new CMenuPracticas();
            menuPracticas.Dock = DockStyle.Fill;
            pnlContenido.Controls.Clear();
            pnlContenido.Controls.Add(menuPracticas);

        }


    }
}
