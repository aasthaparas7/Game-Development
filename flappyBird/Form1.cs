using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappyBird
{
    public partial class fBird : Form
    {
        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;
        public fBird()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gametimerEvent(object sender, EventArgs e)
        {
            bird.Top += gravity;
            uppipe.Left -= pipeSpeed;
            downpipe.Left -= pipeSpeed;
            scoretext.Text = "Score" +score;
            if(downpipe.Left< - 50)
            {
                downpipe.Left = 850;
                score++;
            }
            if (uppipe.Left<-80)
            {
                uppipe.Left = 800;
                score++;
            }

            if(bird.Bounds.IntersectsWith(downpipe.Bounds)||
                bird.Bounds.IntersectsWith(uppipe.Bounds)||
                bird.Bounds.IntersectsWith(ground.Bounds) || bird.Top < -25
                )
            {
                endGame();
            }

            if(score>5)
            {
                pipeSpeed = 15;
            }
           
        }

        private void gamekeydown(object sender, KeyEventArgs e)
        {

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                gravity = -15;

            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;

            }
        }

        private void endGame()
        {
            gametimer.Stop();
            scoretext.Text += "\n GAME OVER!!!!";
        }

        private void scoretext_Click(object sender, EventArgs e)
        {

        }
    }

}
