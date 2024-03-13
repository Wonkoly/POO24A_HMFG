using POO24A_HMFG.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace POO24A_HMFG.Vistas
{
    public partial class Practica2 : Form
    {
        private CServiciosMapasGoogle ServicoMapa;
        private const string LlaveAPIGoogleMaps = "AIzaSyAqPyie1EMOOceRXH7Nk7fSUBoxuhNv9wI";
        private string longitud, latitud, ubicacion;


        public Practica2()
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
        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            await BuscarLocalizacion();
        }

        //------------------------------------------------
        //OBTIENE LOS DATOS DE GEOLOGIA AL DAR ENTER
        private async void tbLugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && tbLugar.Text != "")
            {
                await BuscarLocalizacion();
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string altura = tbAltura.Text;
            ServicoMapa.ExportarLocalizacion(altura);
        }
    }
}
