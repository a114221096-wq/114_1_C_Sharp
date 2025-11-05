using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy_with_TryParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 嘗試取得使用者輸入的英哩數和加侖數，並計算 MPG（每加侖英哩數）。
            double kms;
            double liters;
            double fuelEconomy;

            if (double.TryParse(milesTextBox.Text, out kms))
            {
                if (double.TryParse(gallonsTextBox.Text, out liters))
                {
                    // 計算每加侖英哩數
                    fuelEconomy = kms / liters;

                    mpgLabel.Text = fuelEconomy.ToString("n2") + "公里/公升";
                }
                else
                {
                    MessageBox.Show("請輸入有效加侖數");
                }
            }
            else
            {
                MessageBox.Show("請輸入有效公里數");
            } 
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
