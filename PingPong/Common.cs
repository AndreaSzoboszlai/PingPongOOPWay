using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace PingPong
{
    class Common
    {
        public int height { get; set; }
        public int width { get; set; }

        private int speed;
        public PictureBox pictureBox { get; set; }

        public Common(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public void Update(int newX, int newY)
        {
            pictureBox.Top -= newY;
            pictureBox.Left -= newX;   
        }



    }
}
