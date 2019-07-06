using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PingPong;


namespace PingPonOOPWay
{
    public partial class PingPong : Form
    {
        PingPongLogic logic;
        public PingPong()
        {
            InitializeComponent();
            logic = new PingPongLogic(350, 650);
            logic.SetMovingObjects(PlayerA, PlayerB, ball);
        }


        private void keyIsDown(object sender, KeyEventArgs e)
        {
            logic.keyIsDown(e);
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            logic.keyIsUp(e);
        }
        private void timerTick(object sender, EventArgs e)
        {
            p1Score.Text = "Player 1 Score: " + logic.GetScore1();
            p2Score.Text = "Player 1 Score: " + logic.GetScore2();
            logic.paddleMove();
            logic.CollisionHandler();
            if (logic.GetScore1() > 25 || logic.GetScore2() > 25)
            {
                gameTimer.Stop();
                MessageBox.Show("Game over");
            }
        }
    }
}
