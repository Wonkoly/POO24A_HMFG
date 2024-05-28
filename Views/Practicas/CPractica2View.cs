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

namespace POO24A_HMFG.Views.Practicas
{
    public partial class CPractica2View : UserControl
    {
        //------------------------------------------
        //ATRIBUTOS DE CLASE
        private CServiciosMapasGoogle ServicoMapa;
        private const string LlaveAPIGoogleMaps = "tu api key aqui :)";
        private string longitud, latitud, ubicacion;

        //------------------------------------------
        //CONSTRUCTOR DE CLASE
        public CPractica2View()
        {
            InitializeComponent();
            InicializarLabes();
            ServicoMapa = new CServiciosMapasGoogle(LlaveAPIGoogleMaps);
        }
        private void InicializarLabes()
        {
            lbCordenadas.Text = "Cordenadas: ";
            lbUbicacion.Text = "Ubicacion: ";
            longitud = null; latitud = null; ubicacion = null;
        }

        //------------------------------------------------
        //FUNCION QUE BUSACA LA LOCALIZACION USANDO LA API
        private async Task BuscarLocalizacion()
        {
            InicializarLabes();

            await ServicoMapa.GetDatosGeolocalizacion(tbLugar.Text);

            rtbContenidoLugar.Text = ServicoMapa.GetContenido();

            //Guardamos las cordenadas en las varibles locales
            longitud = ServicoMapa.GetLocalizacion("lng");
            latitud = ServicoMapa.GetLocalizacion("lat");
            ubicacion = ServicoMapa.GetLocalizacion("descripcion");

            lbCordenadas.Text += ServicoMapa.GetLocalizacion("lat-lng");
            lbUbicacion.Text += ubicacion;

            btnExportar.Enabled = true;
        }

        //------------------------------------------------
        //OBTIENE LOS DATOS DE GEOLOGIA 
        private async void btnBuscar_Click_1(object sender, EventArgs e)
        {
            await BuscarLocalizacion();
        }

        private void btnBuscar_MouseEnter(object sender, EventArgs e)
        {
            btnBuscar.Image = Properties.Resources.btnBuscar2;
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            btnBuscar.Image = Properties.Resources.btnBuscar1;
        }

        //------------------------------------------------
        //OBTIENE LOS DATOS DE GEOLOGIA AL DAR ENTER
        private async void tbLugar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && tbLugar.Text != "")
            {
                await BuscarLocalizacion();
            }
        }

        //----------------------------------------------------
        //APARTIR DE LA BUSQUEDA ACTUAL GENERA UN ARCHIVO MKL
        private void btnExportar_Click_1(object sender, EventArgs e)
        {
            string altura = tbAltura.Text;
            ServicoMapa.ExportarLocalizacion(altura);
        }
        private void btnExportar_MouseEnter(object sender, EventArgs e)
        {
            btnExportar.Image = Properties.Resources.btnExportar2;
        }

        private void btnExportar_MouseLeave(object sender, EventArgs e)
        {
            btnExportar.Image = Properties.Resources.btnExportar1;

        }
    }
}
