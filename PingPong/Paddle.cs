using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    class Paddle : Common
    {
        public int score { get; set; }
        private string key;

        public Paddle(string key, int posX, int posY, int height, int width) : base(posX, posY, height, width)
        {
            this.score = 0;
            this.key = key;
        }

    }
}
