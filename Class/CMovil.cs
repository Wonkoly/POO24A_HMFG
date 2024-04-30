using POO24A_HMFG.Class.ClasesPersonaje;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace POO24A_HMFG.Class
{
    internal class CMovil : Button 
    {
        //-------------------------------------------------------------------------
        //Atributos.
        //-------------------------------------------------------------------------
        protected Control AreaJuego;
        private int X, Y;
        protected bool Nacio;
        protected bool Muerto;
        private bool Norte;
        private bool Sur;
        protected bool Este;
        protected bool Oeste;
        protected Thread ProcesoVida;
        private int tamanoLetra;

        //-------------------------------------------------------------------------
        //Constructor.
        //-------------------------------------------------------------------------
        public CMovil(int X, int Y, Control AreaJuego)
        {
            this.AreaJuego = AreaJuego;
            this.X = X;
            this.Y = Y;

            //inicializa atributos
            Nacio = false;
            Muerto = false;

            Norte = false;
            Sur = true;
            Este = true;
            Oeste = false;

            // Agrega el movil al area de juegos

            this.AreaJuego.Controls.Add(this);

            //Configura la apariencia del movil
            Location = new Point(this.X, this.Y);
            Width = 30;
            Height = 30;
            BackColor = Color.MediumSlateBlue;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Name = "ML";

            tamanoLetra = 6;
            Font = new Font(FontFamily.GenericMonospace, tamanoLetra);
            ForeColor = Color.White;
    
            //Configura evento mauseClik
            Click += MauseClick; 
        }

        //-------------------------------------------------------------------------
        //Cambia el color del movil.
        //-------------------------------------------------------------------------
        public void Activar()
        {
            Thread ProcesoEjecucion;
            Random Aleatorio;
            Color Color;
            int R;
            int G;
            int B;

            Aleatorio = new Random();
            R = Aleatorio.Next(0, 256);
            G = Aleatorio.Next(0, 256);
            B = Aleatorio.Next(0, 256);
            Color = Color.FromArgb(R, G, B);

            //ProcesoEjecucion = new Thread(() => { });

            ProcesoEjecucion = new Thread(() =>
            {
                Thread.Sleep(1500);
                BackColor = Color;
                Nacio = true;
            });

            ProcesoEjecucion.Start();
        }
        //-------------------------------------------------------------------------
        //Constructor.
        //-------------------------------------------------------------------------
        public void Desplazar()
        {
            int X;
            int Y;
            int Velocidad;
            Random Aleatorio;

            Aleatorio = new Random();
            Velocidad = Aleatorio.Next(11, 50);

            ProcesoVida = new Thread(() =>
            {
                while (!Muerto)
                {
                    if (Nacio)
                    {
                        //Posicion inicial

                        X = Location.X;
                        Y = Location.Y;

                        if (Norte)
                        {
                            Y = Y - 1;
                        }
                        if (Sur)
                        {
                            Y = Y + 1;
                        }
                        if (Este)
                        {
                            X = X + 1;
                        }
                        if (Oeste)
                        {
                            X = X - 1;
                        }

                        //Valdidar Rabote
                        if (Y <= 0)
                        {
                            Norte = false;
                            Sur = true;
                        }

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

                        if (Y >= AreaJuego.Height - Height)
                        {
                            Norte = true;
                            Sur = false;
                        }

                        //Actualizar interfaz desde el subproceso principal
                        if (!IsDisposed && !Disposing && AreaJuego.IsHandleCreated)
                        {
                            if (AreaJuego.InvokeRequired)
                            {
                                AreaJuego.Invoke(new Action(() =>
                                {
                                    Location = new Point(X, Y);
                                    Text = $"{X.ToString()}, {Y.ToString()}";
                                }));
                            }
                            else
                            {
                                Location = new Point(X, Y);
                                Text = $"{X.ToString()}, {Y.ToString()}";
                            }
                        }

                        Thread.Sleep(Velocidad);
                    }
                }
            });

            ProcesoVida.Start();
        }

        private void MauseClick(object sender, EventArgs e)
        {
            //Cambia el tamaño
            Height = (int)(Height * 1.10);
            Width = (int)(Width * 1.10);

            tamanoLetra++;
            Font = new Font(FontFamily.GenericMonospace, tamanoLetra);
        }

        public void invertirDireccion()
        {
            if (Norte)
            {
                Norte = false;
                Sur = true;
            }
            else
            {
                if (Sur)
                {
                    Sur = false;
                    Norte = true;
                }
            }

            if (Este)
            {
                Este = false;
                Oeste = true;
            }
            else
            {
                if (Oeste)
                {
                    Oeste = false;
                    Este = true;
                }
            }
        }
    }
}
