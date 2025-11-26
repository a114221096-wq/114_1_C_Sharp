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

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFile.FileName);
                saslesListBox.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    line = inputFile.ReadLine();

                    string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length > 2)
                    {
                        string month = parts[0];
                        string salesvalue = parts[1];

                        if (decimal.TryParse(salesvalue, out currentSale))
                        {
                            saslesListBox.Items.Add(string.Format("{0,-15}{1,15}", month, currentSale.ToString("C")));
                            totalSale += currentSale;
                        }
                        else
                        {
                            MessageBox.Show("無法解析銷售額:" + line);
                            inputFile.Close();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("資料格式錯誤:" + line);
                        inputFile.Close();
                        return;
                    }
                }
                inputFile.Close();
                totalLabel.Text = totalSale.ToString("C");
            }

            else
            {
                MessageBox.Show("未選擇檔案");
            }
        }
private void exitButton_Click(object sender, EventArgs e)
{
    // 關閉表單
    this.Close();
}
    }
}
                
