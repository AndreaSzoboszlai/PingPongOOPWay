using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    class Common
    {
        private int posX;
        private int posY;
        private int height;
        private int width;
        private int speed;

        public Common(int posX, int posY, int height, int width)
        {
            this.posX = posX;
            this.posY = posY;
            this.height = height;
            this.width = width;
        }

        public void Update(int newX, int newY)
        {
            posX += newX;
            posY += newY;   
        }

        public void CollisionHandler()
        {

        }
    }
}
