using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal INTEREST_RATE = 0.005m; // 月利率為 0.5%。
            decimal startingBalance;
            int months;
            int count = 1;

            if (decimal.TryParse(startingBalTextBox.Text, out startingBalance))
            {
                if (int.TryParse(monthsTextBox.Text, out months) && months > 0)
                {
                    for (count = 1; count <= months; count++)
                    {
                        startingBalance *= (1 + INTEREST_RATE);
                        detailListBox.Items.Add("第 " + count + " 個月結餘: " + startingBalance.ToString("c2"));
                        count++;


                    }
                    endingBalanceLabel.Text = startingBalance.ToString("C2");
                }
                else
                {
                    MessageBox.Show("請輸入有效的月份數（正整數）。", "輸入錯誤");
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的起始餘額。", "輸入錯誤");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除 TextBoxes 和 endingBalanceLabel 控制項的內容。
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";

            // 重設焦點。
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}

