using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cups_To_Ounces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The CupsToOunces method accepts a number
        // of cups as an argument and returns the
        // equivalent number of fluid ounces.
     

        private void convertButton_Click(object sender, EventArgs e)
        {
            double cups;       // To hold cups
            double ounces;

            if (double.TryParse(cupsTextBox.Text, out cups))
            {
                // Call the CupsToOunces method to
                // perform the conversion.
                ounces = CupsToOunces(cups);
                // Display the result.
                ouncesLabel.Text = ounces.ToString("F2") + " 液量盎司";
            }
            else
            {
                // Display an error message.
                MessageBox.Show("請輸入有效的數字以表示杯數。");
            }
        }
        private double CupsToOunces(double cups)
        {
            return cups * 8.0;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
