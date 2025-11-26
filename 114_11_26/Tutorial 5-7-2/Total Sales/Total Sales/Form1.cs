using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            decimal totalSale = 0.0m;
            decimal currentSale = 0.0m;
            string line;
            try
            {
                inputFile = File.OpenText("Sales.txt");
                saslesListBox.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    if (decimal.TryParse(line = inputFile.ReadLine(), out currentSale))
                    {
                        saslesListBox.Items.Add(line);
                        totalSale += currentSale;
                    }
                    else
                    {
                        MessageBox.Show("無法解析銷售額:" + line);
                        break;
                    }
                }
                inputFile.Close();
                totalLabel.Text = totalSale.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤" + ex.Message);
                return;
            }
            }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
