using POO24A_HMFG.Class.ClasesPersonaje;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO24A_HMFG.Class
{
    internal class CJugador : CMovil
    {
        private string tipoBloqueador;
       

        public CJugador(int X, int Y, Control AreaJuego, string tipoBloquedor) : base(X, Y, AreaJuego)
        {
            this.tipoBloqueador = tipoBloquedor;
        
            if(tipoBloquedor == "Horizontal")
            {
                //Configura la apariencia del movil
                Location = new Point(X, Y);
                Width = 250;
                Height = 15;
            }

            if(tipoBloquedor == "Vertical")
            {
                //Configura la apariencia del movil
                Location = new Point(X, Y);
                Width = 15;
                Height = 250;
            }


            BackColor = Color.MediumSlateBlue;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Name = "BL";

        }
        //-------------------------------------------------------------------------
        //Constructor.
        //-------------------------------------------------------------------------
        public void Desplazar()
        {
            int X;
            int Y;
            int Velocidad;

            Velocidad = 0;

            ProcesoVida = new Thread(() =>
            {
                while (!Muerto)
                {
                    if (Nacio)
                    {
                        //Posicion inicial

                        X = Location.X;
                        Y = Location.Y;


                        if (Este)
                        {
                            X = X + 1;
                        }
                        if (Oeste)
                        {
                            X = X - 1;
                        }

                        // Valida rebote.
                        if (X <= 0)
                        {
                            Este = true;
                            Oeste = false;
                        }

                        if (X >= AreaJuego.Width - Width)
                        {
                            Este = false;
                            Oeste = true;
                        }


                        // Validar Rebote entre si.



                        // Actualiza la nueva ubicacion.
                        Location = new Point(X, Y);
                        Thread.Sleep(Velocidad);
                    }
                }
            });

            ProcesoVida.Start();
        }

        public void Desplazar(int direccion)
        {
            int X, Y;

            //Posicion
            X = Location.X;
            Y = Location.Y;

            //Mover la pinche barra
            switch (tipoBloqueador)
            {
                case "Horizontal":
                    if (direccion == 1)
                    {
                        X = X - 20;
                    }

                    if (direccion == 2)
                    {
                        X = X + 20;
                    }
                    break;

                case "Vertical":
                    if (direccion == 1)
                    {
                        Y = Y - 20;
                    }

                    if (direccion == 2)
                    {
                        Y = Y + 20;
                    }
                    break;
            }

            Location = new Point(X, Y);

        }
    }
}
