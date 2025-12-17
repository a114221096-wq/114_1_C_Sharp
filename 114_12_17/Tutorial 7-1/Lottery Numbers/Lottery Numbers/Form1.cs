using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
           const int SIZE = 5;
            int[] lotteryNumbers = new int[SIZE];
            Label[] labels = new Label[SIZE] { firstLabel, secondLabel, thirdLabel, fourthLabel, fifthLabel };
            Random rand = new Random();

            for (int i = 0; i < SIZE; i++)
            {
                lotteryNumbers[i] = rand.Next(1, 71); // Generate numbers between 1 and 70
            }

            // Display the generated numbers in the labels
            firstLabel.Text = lotteryNumbers[0].ToString();
            secondLabel.Text = lotteryNumbers[1].ToString();
            thirdLabel.Text = lotteryNumbers[2].ToString();
            fourthLabel.Text = lotteryNumbers[3].ToString();
            fifthLabel.Text = lotteryNumbers[4].ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
