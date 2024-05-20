using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO24A_HMFG.Class.ClasesPractica3
{
    internal class CMovil : Button
    {
        //-------------------------------------------------------------------------
        //Atributos
        protected Control AreaJuego;
        private int X, Y, Velocidad;
        protected bool Nacio;
        protected bool Muerto;
        private bool Norte;
        private bool Sur;
        protected bool Este;
        protected bool Oeste;
        private int TamañoLetra, TamañoCubo;
        protected Thread ProcesoVida;

        //-------------------------------------------------------------------------
        //Constructor
        public CMovil(int X, int Y, Control AreaJuego)
        {
            this.AreaJuego = AreaJuego;
            this.X = X;
            this.Y = Y;

            //inicializa atributos
            Nacio = false;
            Muerto = false;

            Random random = new Random();

            Norte = (random.Next(2) == 0);
            Sur = !Norte;
            Este = (random.Next(2) == 0);
            Oeste = !Este;

            // Agrega el movil al area de juegos

            this.AreaJuego.Controls.Add(this);

            //Configura la apariencia del movil

            Location = new Point(this.X, this.Y);
            Width = 30;
            Height = 30;
            BackColor = Color.MediumSlateBlue;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;

            DateTime localDate = DateTime.Now;
            Name = localDate.Second.ToString() + localDate.Millisecond.ToString();

            // Configura letra inicial.

            TamañoLetra = 6;
            Font = new Font(FontFamily.GenericSerif, TamañoLetra);
            ForeColor = Color.White;

            // Configura evento mouseclick.

            Click += new System.EventHandler(MouseClic);
        }

        //-------------------------------------------------------------------------
        //Cambia el color del movil
        public virtual void Activar()
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

            ProcesoEjecucion = new Thread(() =>
            {
                Thread.Sleep(1500);
                BackColor = Color;
                Nacio = true;
            });

            ProcesoEjecucion.Start();
        }

        //-------------------------------------------------------------------------
        //Constructor
        public void Desplazar()
        {
            int X;
            int Y;
            int Velocidad;
            Random Aleatorio;

            Aleatorio = new Random();
            Velocidad = 1;

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

                        // Validar Rebote entre moviles.
                        int XTrabajo;
                        int YTrabajo;

                        foreach (Control Control in AreaJuego.Controls)
                        {
                            if (Control is CMovil)
                            {
                                CMovil Movil = (CMovil)Control;

                                if (Name != Movil.Name)
                                {
                                    XTrabajo = Movil.Location.X;
                                    YTrabajo = Movil.Location.Y;

                                    //Choque por el norte
                                    int AlturaMovil;
                                    int AnchoMovil;
                                    int Tolerancia;

                                    AlturaMovil = Movil.Height;
                                    AnchoMovil = Movil.Width;
                                    Tolerancia = AnchoMovil - 2;

                                    if ((Y <= YTrabajo + AlturaMovil) && (Y > YTrabajo + Tolerancia) && (((X >= XTrabajo) && (X <= XTrabajo + AnchoMovil)) ||
                                    ((X + Width >= XTrabajo) && (X + Width <= XTrabajo + AnchoMovil))))
                                    {
                                        Norte = false;
                                        Sur = true;
                                    }

                                    //Choque por el sur
                                    if ((Y + Height >= YTrabajo) && (Y + Height < YTrabajo + AlturaMovil - Tolerancia) && (((X >= XTrabajo) &&
                                    (X <= XTrabajo + AnchoMovil)) || ((X + Width >= XTrabajo) && (X + Width <= XTrabajo + AnchoMovil))))
                                    {
                                        Sur = false;
                                        Norte = true;
                                    }

                                    //Choque por el este.
                                    if ((X + Width >= XTrabajo) && (X + Width < XTrabajo + AnchoMovil - Tolerancia) && (((Y >= YTrabajo) && (Y <= YTrabajo + AlturaMovil))
                                    || ((Y + Height >= YTrabajo) && (Y + Height <= YTrabajo + AlturaMovil))))
                                    {
                                        Este = false;
                                        Oeste = true;
                                    }

                                    //Choque por el oeste.
                                    if ((X <= XTrabajo + AnchoMovil) && (X > XTrabajo + Tolerancia) && (((Y >= YTrabajo) && (Y <= YTrabajo + AlturaMovil)) ||
                                    ((Y + Height >= YTrabajo) && (Y + Height <= YTrabajo + AlturaMovil))))
                                    {
                                        Oeste = false;
                                        Este = true;
                                    }
                                }
                            }

                            // Valida rebote.

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

                            // Actualiza la nueva ubicacion.
                            Location = new Point(X, Y);
                            Thread.Sleep(Velocidad);
                        }
                    }
                }
            });

            ProcesoVida.Start();
        }

        private void MouseClic(object sender, EventArgs e)
        {
            // Cambia el tamaño

            Height = (int)(Height * 1.10);
            Width = (int)(Width * 1.10);

            TamañoLetra++;

            Font = new Font(FontFamily.GenericSerif, TamañoLetra);
        }

        //-------------------------------------------------------------------------
        // Invierte la Direccion de despazamiento del movil.
        //-------------------------------------------------------------------------

        public void InvierteDireccion()
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

        //-------------------------------------------------------------------------
        // Cambia la direccion del movil debido a un choque
        public void RebotaPorChoque()
        {
            if (Norte && Este)
            {
                Norte = false;
                Sur = true;
                Este = true;
                Oeste = false;
            }
            else
            {
                Norte = true;
                Sur = false;
                Este = false;
                Oeste = true;
            }

            if (Sur && Este)
            {
                Norte = false;
                Sur = true;
                Este = true;
                Oeste = false;
            }
            else
            {
                Norte = true;
                Sur = false;
                Este = false;
                Oeste = true;
            }
        }

        //-------------------------------------------------------------------------
        // Termina el hilo de ejecucion de la pelota.
        protected override void Dispose(bool disposing)
        {
            Muerto = true;
        }
    }
}
