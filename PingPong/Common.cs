using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    class Common
    {
        public int Height { get; set; }
        public int Width { get; set; }

        private int speed;
        public PictureBox pictureBox { get; set; }

        public Common(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }

        public void Update(int newX, int newY)
        {
            pictureBox.Top -= newX;
            pictureBox.Left -= newY;   
        }

        public void CollisionHandler()
        {

        }
    }
}
