using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    class Paddle : Common
    {
        public int score { get; set; }

        public Paddle(int height, int width) : base(height, width)
        {
            this.score = 0;
        }


    }
}
