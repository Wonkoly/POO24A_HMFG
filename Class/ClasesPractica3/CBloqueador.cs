using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO24A_HMFG.Class.ClasesPractica3
{
    internal class CBloqueador : CMovil
    {
        //-------------------------------------------------------------------------
        //Atributos.
        //-------------------------------------------------------------------------

        private int Tipo; // 1 = Bloqueador verticale, 2 = Bloqueador horizontal.

        //-------------------------------------------------------------------------
        //Constructor.
        //-------------------------------------------------------------------------

        public CBloqueador(int X, int Y, Control AreaJuego, int Tipo) : base(X, Y, AreaJuego)
        {
            //Configura la apariencia del movil

            this.Tipo = Tipo;

            if (Tipo == 1)
            {
                Width = 5;
                Height = 200;
            }
            if (Tipo == 2)
            {
                Width = 200;
                Height = 5;
            }

            BackColor = Color.MediumSlateBlue;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Name = "BL";
        }

        //-------------------------------------------------------------------------
        // Desplaza el Bloqueador
        //-------------------------------------------------------------------------
        public void Desplazar()
        {
            int X;
            int Y;
            int Velocidad;

            Velocidad = 2;

            ProcesoVida = new Thread(() =>
            {
                while (!Muerto)
                {
                    if (Nacio)
                    {
                        //Posicion Inicial.

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

                        // Actualiza la nueva ubicacion.

                        Location = new Point(X, Y);
                        Thread.Sleep(Velocidad);
                    }
                }
            });

            ProcesoVida.Start();
        }

        //-------------------------------------------------------------------------
        // Desplaza el Bloqueador.
        // Direccion = 1, Desplazar a la izquierda.
        // Direccion = 2, Desplazar a la derecha.
        //-------------------------------------------------------------------------
        public void Desplazar(int Direccion)
        {
            int X;
            int Y;

            // Posicion Inicial.

            X = Location.X;
            Y = Location.Y;

            // Calucla Desplazamiento.
            if (Tipo == 1)
            {
                if (Direccion == 1)
                {
                    Y = Y - 20;
                }
                if (Direccion == 2)
                {
                    Y = Y + 20;
                }
            }

            if (Tipo == 2)
            {
                if (Direccion == 1)
                {
                    X = X - 20;
                }
                if (Direccion == 2)
                {
                    X = X + 20;
                }
            }

            // Actualiza la nueva ubicacion.

            Location = new Point(X, Y);
        }

        public override void Activar()
        { 
            Thread ProcesoEjecucion;

            ProcesoEjecucion = new Thread(() =>
            {
                Thread.Sleep(1500);
                BackColor = Color.Red;
                Nacio = true;
            });

            ProcesoEjecucion.Start();
        }

    }
}
