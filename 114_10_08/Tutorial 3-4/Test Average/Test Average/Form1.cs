using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    // 表單主要類別：處理三個測驗分數的輸入、計算平均值與按鈕事件
    public partial class Form1 : Form
    {
        // 建構子：初始化表單與元件
        public Form1()
        {
            InitializeComponent();
        }

        // 計算按鈕事件處理：解析輸入、計算平均並顯示結果
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double t1, t2, t3;
            // 逐一嘗試解析三個輸入；任一失敗則顯示錯誤訊息並返回
            if (!double.TryParse(test1TextBox.Text, out t1) ||
                !double.TryParse(test2TextBox.Text, out t2) ||
                !double.TryParse(test3TextBox.Text, out t3))
            {
                // 若有非數字輸入，顯示警告訊息並停止計算
                MessageBox.Show("請輸入三個有效的數字分數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 計算三個分數的平均值
            double average = (t1 + t2 + t3) / 3.0;
            // 顯示平均值（格式化為一位小數）
            averageLabel.Text = average.ToString("F1");
        }
        

        // 清除按鈕事件處理：清空所有輸入欄與結果顯示，並將焦點放回第一個欄位
        private void clearButton_Click(object sender, EventArgs e)
        {
            test1TextBox.Text = string.Empty;
            test2TextBox.Text = string.Empty;
            test3TextBox.Text = string.Empty;
            averageLabel.Text = string.Empty;
            test1TextBox.Focus();
        }

        // 離開按鈕事件處理：關閉表單
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
