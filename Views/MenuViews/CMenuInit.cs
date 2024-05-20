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
            fondoGif.Controls.Add(btnPracticas);
            fondoGif.Controls.Add(btnSalir);
            fondoGif.Controls.Add(btnConfig);
            fondoGif.Controls.Add(layoutTitulo);

        }
    
        //-------------------------------------------------------------
        //BOTON MENU PRACTICAS
        private void btnPracticas_Click(object sender, EventArgs e)
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
        private void btnPracticas_MouseEnter(object sender, EventArgs e)
        {
            //Efecto de boton presionado
            btnPracticas.Image = Properties.Resources.btnPlantilla2;
            btnPracticas.ForeColor = System.Drawing.Color.LightGray;
        }
        private void btnPracticas_MouseLeave(object sender, EventArgs e)
        {
            //Efecto de boton presionado
            btnPracticas.Image = Properties.Resources.btnPlantilla1;
            btnPracticas.ForeColor = System.Drawing.Color.White;
        }

        //-------------------------------------------------------------
        //BOTON MENU SALIR
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnSalir_MouseEnter_1(object sender, EventArgs e)
        {
            btnSalir.Image = Properties.Resources.btnPlantilla2;
            btnSalir.ForeColor = System.Drawing.Color.LightGray;
        }
        private void btnSalir_MouseLeave_1(object sender, EventArgs e)
        {
            btnSalir.Image = Properties.Resources.btnPlantilla1;
            btnSalir.ForeColor = System.Drawing.Color.White;
        }

        //-------------------------------------------------------------
        //BOTON MENU CONFIGURACION
        private void btnConfig_Click_1(object sender, EventArgs e)
        {
            //Abrir un formulario en forma de dialogo en donde se modificara la apariencia

        }
        private void btnConfig_MouseEnter_1(object sender, EventArgs e)
        {
            btnConfig.Image = Properties.Resources.btnConfig2;
        }
        private void btnConfig_MouseLeave_1(object sender, EventArgs e)
        {
            btnConfig.Image = Properties.Resources.btnConfig1;
        }
    }
}
