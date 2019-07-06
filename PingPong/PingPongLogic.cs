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
        private int x = 6;
        private int y = 6;


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
            if (firstUp == true && paddle.pictureBox.Top > 0)
            {
                paddle.pictureBox.Top -= 8;
            }

            if (secondUp == true && paddle2.pictureBox.Top > 0)
            {
                paddle2.pictureBox.Top -= 8;
            }

            if (firstDown == true && paddle.pictureBox.Top < paddle.height)
            {
                paddle.pictureBox.Top += 8;
            }

            if (secondDown == true && paddle2.pictureBox.Top < paddle.height)
            {
                paddle2.pictureBox.Top += 8;
            }

        }

        public void CollisionHandler()
        {
            ball.Update(x, y);
            if (ball.pictureBox.Left < 0)
            {
                ball.pictureBox.Left = ball.width / 2;
                x = -x;
            }

            if (ball.pictureBox.Left > ball.width)
            {
                ball.pictureBox.Left = ball.width / 2;
                x = -x;
            }

            if (ball.pictureBox.Top < 0 || ball.pictureBox.Top > ball.height)
            {
                y = -y;
            }

            if (ball.pictureBox.Bounds.IntersectsWith(paddle.pictureBox.Bounds))
            {
                x = -x;
                paddle.score += 1;
            }

            if (ball.pictureBox.Bounds.IntersectsWith(paddle2.pictureBox.Bounds))
            {
                x = -x;
                paddle2.score += 1;
            }
        }

        public int GetScore1()
        {
            return paddle.score;
        }

        public int GetScore2()
        {
            return paddle2.score;
        }
    }
}
