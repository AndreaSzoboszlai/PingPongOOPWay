using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public class PingPongLogic
    {
        private Paddle paddle;
        private Paddle paddle2;
        private Ball ball;
        private bool firstUp;
        private bool firstDown;
        private bool secondUp;
        private bool secondDown;
        public PictureBox pictureBoxBall { get; set; }
        public PictureBox pictureBoxPaddle1 { get; set; }
        public PictureBox pictureBoxPaddle2 { get; set; }


        public PingPongLogic(int height, int width)
        {
            paddle = new Paddle(height, width);
            paddle2 = new Paddle(height, width);
            ball = new Ball(height, width);
        }

        public void SetMovingObjects(PictureBox p1, PictureBox p2, PictureBox p3)
        {
            paddle.pictureBox = p1;
            paddle2.pictureBox = p2;
            ball.pictureBox = p3;
        }

        public void UpdateBallPostition(int newX, int newY)
        {
            ball.Update(newX, newY);
        }

        public void keyIsDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                secondDown = true;
            }

            if (e.KeyCode == Keys.S)
            {
                firstDown = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                secondUp = true;
            }

            if (e.KeyCode == Keys.W)
            {
                firstUp = true;
            }
        }

        public void keyIsUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                secondDown = false;
            }

            if (e.KeyCode == Keys.S)
            {
                firstDown = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                secondUp = false;
            }

            if (e.KeyCode == Keys.W)
            {
                firstUp = false;
            }
        }

        public void paddleMove()
        {
            if (firstUp == true && pictureBoxPaddle1.Top > 0)
            {
                pictureBoxPaddle1.Top -= 8;
            }

            if (secondUp == true && pictureBoxPaddle2.Top > 0)
            {
                pictureBoxPaddle2.Top -= 8;
            }

            if (firstDown == true && pictureBoxPaddle1.Top < paddle.Height)
            {
                pictureBoxPaddle1.Top += 8;
            }

            if (secondDown == true && pictureBoxPaddle1.Top < paddle.Height)
            {
                pictureBoxPaddle2.Top += 8;
            }
        }
    }
}
