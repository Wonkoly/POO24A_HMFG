using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace POO24A_HMFG.Class
{
    internal class CServiciosMapasGoogle
    {
        //--------------------------------------------------
        //ATRIBUTOS    
        private HttpClient Cliente;
        private Uri Direccion;
        private HttpResponseMessage RespuestaHttp;
        private XmlDocument DocumentoXml;
        private string ContenidoHttp, Llave, Lugar;
        private string Latitud, Longitud, Ubicacion;
        private const string UriAPIGoogleMaps = "https://maps.googleapis.com/maps/api/geocode/";

        //--------------------------------------------------
        //CONSTRUCTOR
        public CServiciosMapasGoogle(string llave)
        {
            //--- Inicializamos Variables 
            Cliente = null;
            Direccion = null;
            RespuestaHttp = null;
            DocumentoXml = null;
            RespuestaHttp = null;
            Lugar = null;
            Latitud = null;
            Longitud = null;
            Ubicacion = null;

            //--- Cargamos la llave
            this.Llave = llave;

            //--- Instanciamos los objetos necesarios
            Cliente = new HttpClient();
            Direccion = new Uri(UriAPIGoogleMaps);
            Cliente.BaseAddress = Direccion;
            DocumentoXml = new XmlDocument();
        }

        //--------------------------------------------------
        //OBTENIENE DATOS DE GEOLOCALIZACION DE UN LUGAR
        public async Task GetDatosGeolocalizacion(string lugar)
        {
            try
            {
                RespuestaHttp = await Cliente.GetAsync("xml?address=" + lugar + "&key=" + Llave);
                ContenidoHttp = await RespuestaHttp.Content.ReadAsStringAsync();
                MessageBox.Show("Cordenadas Obtenidas con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar conectar con el servidor: " + ex.Message);
            }
        }

        //----------------------------------------------------------------
        //OBTENIENE EL CONTENIDO DE LA CONSULTA A LA API EN FORMATO XML
        public string GetContenido()
        {
            return ContenidoHttp;
        }

        //----------------------------------------------------------------
        //OBTENIENE UNICAMENTE LAS CORDENADAS DEL LUGAR BUSCADO
        public string GetLocalizacion(string parametro)
        {
            //- Variables Locales
            string lat_long, lat, lng, lugar, resultado;
            XmlNode statusNode, lugarNode, localiNode, latNode, lngNode;

            //- Inicializamos un resultado con un string vacio para evitar el null
            resultado = "";

            try
            {
                //- Cargamos el ContenidoHttp en un Xml 
                DocumentoXml.LoadXml(ContenidoHttp);
                statusNode = DocumentoXml.SelectSingleNode("//status");

                if (statusNode != null && statusNode.InnerText == "OK")
                {
                    //- Cargamos el nodo loaction
                    localiNode = DocumentoXml.SelectSingleNode("//location");

                    if (localiNode != null)
                    {
                        latNode = localiNode.SelectSingleNode("lat");
                        lngNode = localiNode.SelectSingleNode("lng");
                        lugarNode = DocumentoXml.SelectSingleNode("//result/formatted_address");

                        switch (parametro)
                        {
                            case "lat":
                                lat = latNode.InnerText;
                                Latitud = lat;
                                return lat;
                            case "lng":
                                lng = lngNode.InnerText;
                                Longitud = lng;
                                return lng;
                            case "lat-lng":
                                lat_long = $"{latNode.InnerText} {lngNode.InnerText}";
                                return lat_long;
                            case "descripcion":
                                lugar = lugarNode.InnerText;
                                Ubicacion = lugar;
                                return lugar;
                        }
                    }
                }
                else
                {
                    MessageBox.Show(
                        "No se encontro el lugar",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro: {ex}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            return resultado;
        }

        public void ExportarLocalizacion(string altura)
        {
            try
            {
                string kmlContenido = $@"<?xml version=""1.0"" encoding=""UTF-8""?>
                                         <kml xmlns=""http://www.opengis.net/kml/2.2""> 
                                            <Placemark>
                                                <name>{Ubicacion}</name>
                                                <description>{Ubicacion}</description>
                                                <Point>
                                                    <extrude>1</extrude>
                                                    <altitudeMode>relativeToGround</altitudeMode>
                                                    <coordinates>{Longitud},{Latitud},{altura}m</coordinates>
                                                </Point>
                                            </Placemark>
                                          </kml>";

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos KML (*.kml)|*.kml";
                saveFileDialog.Title = "Guardar archivo KML";
                saveFileDialog.ShowDialog();

                // Guardar el archivo KML si el usuario selecciona una ubicación
                if (saveFileDialog.FileName != "")
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        sw.Write(kmlContenido);
                    }
                    MessageBox.Show(
                        "Archivo KML generado y guardado exitosamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al Generar o Guardar Archivo KML.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
    }
}
