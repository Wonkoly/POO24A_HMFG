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
    public partial class CMenuInit : UserControl
    {
        public CMenuInit()
        {
            InitializeComponent();

            //Configurar Picturbox como Panel
            fondoGif.Controls.Add(btnMenuPracticas);
            fondoGif.Controls.Add(btnSalir);
            fondoGif.Controls.Add(btnConfig);
            fondoGif.Controls.Add(lbTitulo);
            fondoGif.Controls.Add(label1);

            //Configurar Titulos del los Botones
            btnMenuPracticas.Controls.Add(lbBtnPracticas);
            lbBtnPracticas.Location = new Point(45, 25);
            btnSalir.Controls.Add(lbBtnSalir);
            lbBtnSalir.Location = new Point(65, 25);

        }
    
        //-------------------------------------------------------------
        //BOTON MENU PRACTICAS
        private void btnMenuPracticas_Click(object sender, EventArgs e)
        {
            // Eliminar controles del contenedor principal
            if (Parent != null && Parent.Controls.Count > 0)
            {
                Control parentContainer = Parent.Controls[0];
                parentContainer.Controls.Clear();

                // Crear e inicializar el nuevo control
                CMenuPracticas menuPracticas = new CMenuPracticas();
                menuPracticas.Dock = DockStyle.Fill;

                // Agregar el nuevo control al contenedor principal
                parentContainer.Controls.Add(menuPracticas);
                menuPracticas.Focus();
            }
        }
        private void btnMenuPracticas_MouseEnter(object sender, EventArgs e)
        {
            btnMenuPracticas.Image = Properties.Resources.btnPlantilla2;
        }

        private void btnMenuPracticas_MouseLeave(object sender, EventArgs e)
        {
            btnMenuPracticas.Image = Properties.Resources.btnPlantilla1;
        }

        //-------------------------------------------------------------
        //BOTON MENU SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.Image = Properties.Resources.btnPlantilla2;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.Image = Properties.Resources.btnPlantilla1;
        }

        //-------------------------------------------------------------
        //BOTON MENU CONFIGURACION
        private void btnConfig_Click(object sender, EventArgs e)
        {


        }

        private void btnConfig_MouseEnter(object sender, EventArgs e)
        {
            btnConfig.Image = Properties.Resources.btnConfig2;
        }

        private void btnConfig_MouseLeave(object sender, EventArgs e)
        {
            btnConfig.Image = Properties.Resources.btnConfig1;
        }

    }
}
