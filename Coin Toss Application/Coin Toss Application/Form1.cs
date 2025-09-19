using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Toss_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToss_Click(object sender, EventArgs e)
        {
            //Variable to indicate which side is up.
            int sideUp;

            //Create a Random object.
            Random rand = new Random();

            //Get a random integer in the range of 0 through 1.
            // 0 means tails up & 1 means heads up.
            sideUp = rand.Next(2);

            //Display the side that is up.
            if(sideUp == 0)
            {
                //Display tails up.
                pbTail.Visible = true;
                pbHead.Visible = false;
            }

            else
            {
                //Display the heads up.
                pbHead.Visible = true;
                pbTail.Visible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form or end the game.
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //The warm welcome message to play the game.
            MessageBox.Show("WELCOME CLICK THE OK BUTTON TO START PLAYING BUDDY!");
        }
    }
}
