using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace POO24A_HMFG.Clases
{
    internal class CCuerpo : PictureBox
    {
        //------- Atributos --------------------------------------------------------------------------//
        public int Velicidad { get; set; } = 10;

        int frameIndex = 0;
        private Timer timerFrame;
        private Random random;
        private bool autoMove;

        //Coleccion de Imagenes de movimiento
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


        public CCuerpo(Point posicion)
        {
            //Inicializacion de Caracteristicas del monito
            this.BackColor = Color.Transparent;
            this.Size = new Size(64, 64);
            this.Location = posicion;

            timerFrame = new Timer();
            timerFrame.Interval = 100;
            timerFrame.Tick += MoverMonito;

            random = new Random();

            timerFrame.Start();
        }



        //------- Movimiento del personaje --------------------------------------------------------------------------//
        public void MoveUp()
        {
            this.Top -= Velicidad;
            InitAnimation("UP");
        }
        public void MoveDown()
        {
            this.Top += Velicidad;
            InitAnimation("DOWN");
        }
        public void MoveLeft()
        {
            this.Left -= Velicidad;
            InitAnimation("LEFT");
        }
        public void MoveRight()
        {
            this.Left += Velicidad;
            InitAnimation("RIGHT");
        }

        // Método para mover el monito automáticamente
        private void MoverMonito(object sender, EventArgs e)
        {
            // Generar una dirección aleatoria
            int direccion = random.Next(4); // 0: Arriba, 1: Abajo, 2: Izquierda, 3: Derecha

            // Mover el monito en la dirección generada
            switch (direccion)
            {
                case 0:
                    MoveUp();
                    break;
                case 1:
                    MoveDown();
                    break;
                case 2:
                    MoveLeft();
                    break;
                case 3:
                    MoveRight();
                    break;
            }
        }

        //------- Animaciones --------------------------------------------------------------------------//
        private void InitAnimation(string direccion)
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

        private void animationTimer_Right(Object sender, EventArgs e)
        {
            frameIndex = (frameIndex + 1) % moveRight.Length;
            Image newImage = ResizeImage(moveRight[frameIndex], this.Size);
            this.Image = newImage;
        }
        private void animationTimer_Up(Object sender, EventArgs e)
        {
            frameIndex = (frameIndex + 1) % moveUp.Length;
            Image newImage = ResizeImage(moveUp[frameIndex], this.Size);
            this.Image = newImage;
        }
        private void animationTimer_Down(Object sender, EventArgs e)
        {
            frameIndex = (frameIndex + 1) % moveDown.Length;
            Image newImage = ResizeImage(moveDown[frameIndex], this.Size);
            this.Image = newImage;
        }
        private void animationTimer_Left(Object sender, EventArgs e)
        {
            frameIndex = (frameIndex + 1) % moveLeft.Length;
            Image newImage = ResizeImage(moveLeft[frameIndex], this.Size);
            this.Image = newImage;
        }

        private Image ResizeImage(Image imagen, Size nuevoTamano)
        {
            return new Bitmap(imagen, nuevoTamano);
        }
    }
}

