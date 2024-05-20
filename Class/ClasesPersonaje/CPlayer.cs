using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO24A_HMFG.Class.ClasesPersonaje
{
    public partial class CPlayer : UserControl
    {
        //------------------------------------
        //VARIABLES DE CLASE
        private int speed = 10;
        private int frameIndex = 0;

        //Coleccion de Imagenes de Movimiento
        private Image[] moveDown =
        {
            Properties.Resources.D1,
            Properties.Resources.D2,
            Properties.Resources.D3,
            Properties.Resources.D4
        };

        private Image[] moveUp =
        {
            Properties.Resources.U1,
            Properties.Resources.U2,
            Properties.Resources.U3,
            Properties.Resources.U4
        };

        private Image[] moveLeft =
        {
            Properties.Resources.L1,
            Properties.Resources.L2,
            Properties.Resources.L3,
            Properties.Resources.L4
        };

        private Image[] moveRight =
        {
            Properties.Resources.R1,
            Properties.Resources.R2,
            Properties.Resources.R3,
            Properties.Resources.R4
        };

        public CPlayer()
        {
            InitializeComponent();
        }

        //------------------------------------
        //MOVIMIENTO DEL PERSONAJE
        protected void Mover(int deltaX, int deltaY)
        {
            this.Location = new Point(Location.X + deltaX, Location.Y + deltaY);
        }
        private void CPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    InitAnimation("UP");
                    Mover(0, -speed);
                    break;
                case Keys.S:
                    InitAnimation("DOWN");
                    Mover(0, speed);
                    break;
                case Keys.A:
                    InitAnimation("LEFT");
                    Mover(-speed, 0);
                    break;
                case Keys.D:
                    InitAnimation("RIGHT");
                    Mover(speed, 0);
                    break;
            }
        }

        //------------------------------------
        //ANIMACIONES DE MOVIMIENTO
        protected void InitAnimation(string direccion)
        {
            switch (direccion)
            {
                case "UP":
                    timerFrame.Tick += animationTimer_Up;
                    timerFrame.Start();
                    break;
                case "DOWN":
                    timerFrame.Tick += animationTimer_Down;
                    timerFrame.Start();
                    break;
                case "RIGHT":
                    timerFrame.Tick += animationTimer_Right;
                    timerFrame.Start();
                    break;
                case "LEFT":
                    timerFrame.Tick += animationTimer_Left;
                    timerFrame.Start();
                    break;
            }
        }
        //Animacion Caminar hacia la Deracha
        protected void animationTimer_Right(Object sender, EventArgs e)
        {
            frameIndex = (frameIndex + 1) % moveRight.Length;
            Image newImage = ResizeImage(moveRight[frameIndex], this.Size);
            this.BackgroundImage = newImage;
        }
        //Animacion Caminar hacia Arriba
        protected void animationTimer_Up(Object sender, EventArgs e)
        {
            frameIndex = (frameIndex + 1) % moveUp.Length;
            Image newImage = ResizeImage(moveUp[frameIndex], this.Size);
            this.BackgroundImage = newImage;
        }
        //Animacion Caminar hacia Abajo
        protected void animationTimer_Down(Object sender, EventArgs e)
        {
            frameIndex = (frameIndex + 1) % moveDown.Length;
            Image newImage = ResizeImage(moveDown[frameIndex], this.Size);
            this.BackgroundImage = newImage;
        }
        //Animacion Caminar hacia Izquierda
        protected void animationTimer_Left(Object sender, EventArgs e)
        {
            frameIndex = (frameIndex + 1) % moveLeft.Length;
            Image newImage = ResizeImage(moveLeft[frameIndex], this.Size);
            this.BackgroundImage = newImage;
        }
        //Funcion para redimencionar la Imagen del personaje
        protected Image ResizeImage(Image imagen, Size nuevoTamano)
        {
            return new Bitmap(imagen, nuevoTamano);
        }

        //-------------------------------------
        //DETECTAR COLICIONES EN GENERAL

    }
}
