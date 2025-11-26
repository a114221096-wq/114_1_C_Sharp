using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        // Declare instance variables to keep track of heads and tails count.
        private int headsCount;
        private int tailsCount;

        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            // Create a random number generator.
            Random random = new Random();

            // Generate a random number, either 0 or 1.
            int coinSide = random.Next(0, 2);

            // If the number is 0, display heads; otherwise, display tails.
            if (coinSide == 0)
            {
                headsPictureBox.Visible = true;
                tailsPictureBox.Visible = false;

                // Increment the heads count and update the label.
                headsCount++;
                headsCountLabel.Text = headsCount.ToString();
            }
            else
            {
                headsPictureBox.Visible = false;
                tailsPictureBox.Visible = true;

                // Increment the tails count and update the label.
                tailsCount++;
                tailsCountLabel.Text = tailsCount.ToString();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
