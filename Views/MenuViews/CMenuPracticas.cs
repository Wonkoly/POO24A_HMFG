using POO24A_HMFG.Views.Practicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO24A_HMFG.Views.MenuViews
{
    public partial class CMenuPracticas : UserControl
    {
        //--------------------------------------------------------
        //ATRIBUTOS DE CLASE
        private Timer carouselTimer;
        private string labelText = "...";
        private int currentIndex = 0;

        public CMenuPracticas()
        { 
            InitializeComponent();

            //Acomodo del Texto
            lbPracticaTitulo.Size = new Size(200, 21);

            AnimacionTexto();
            cPlayer1.Focus();
        }

        private void AnimacionTexto()
        {
            // Inicializa el Timer para controlar la animación del carrusel
            carouselTimer = new Timer();
            carouselTimer.Interval = 55; // Intervalo en milisegundos entre movimientos del texto
            carouselTimer.Tick += CarouselTimer_Tick;
        }
        private void CarouselTimer_Tick(object sender, EventArgs e)
        {
            // Mueve el texto horizontalmente
            currentIndex++;
            if (currentIndex >= labelText.Length)
            {
                currentIndex = 0; // Reinicia el carrusel al llegar al final del texto
            }
            lbPracticaTitulo.Text = labelText.Substring(currentIndex) + labelText.Substring(0, currentIndex);
        }

        //-------------------------------------------------------------
        //BOTON MENU INICIO
        private void btnInicio_Click(object sender, EventArgs e)
        {
            // Eliminar controles del contenedor principal
            if (Parent != null && Parent.Controls.Count > 0)
            {
                Control parentContainer = Parent.Controls[0];
                parentContainer.Controls.Clear();

                // Crear e inicializar el nuevo control
                CMenuInit menuPracticas = new CMenuInit();
                menuPracticas.Dock = DockStyle.Fill;

                // Agregar el nuevo control al contenedor principal
                parentContainer.Controls.Add(menuPracticas);
            }
        }
        private void btnInicio_MouseEnter(object sender, EventArgs e)
        {
            btnInicio.Image = Properties.Resources.btnInicio2;
        }

        private void btnInicio_MouseLeave(object sender, EventArgs e)
        {
            btnInicio.Image = Properties.Resources.btnInicio1;
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

        //-------------------------------------------------------------
        //BOTON PRACTICA 1 (CALIS)
        private void btnP1_Click(object sender, EventArgs e)
        {
            CPractica1View practica1 = new CPractica1View();
            practica1.Dock = DockStyle.Fill;
            pnlDinamico.Controls.Clear();
            pnlDinamico.Controls.Add(practica1);
            labelText = "Practica 1: Creacion de Personas Aleatorias.   ";
            carouselTimer.Start();
        }

        //-------------------------------------------------------------
        //BOTON PRACTICA 2 (CALIS)
        private void btnP2_Click(object sender, EventArgs e)
        {
            CPractica2View practica2 = new CPractica2View();
            practica2.Dock = DockStyle.Fill;
            pnlDinamico.Controls.Clear();
            pnlDinamico.Controls.Add(practica2);
            labelText = "Practica 2: Buscador de Ubicaciones con Google Maps API.   ";
            carouselTimer.Start();
        }
    }
}
