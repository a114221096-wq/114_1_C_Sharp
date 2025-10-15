using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    /// <summary>
    /// 主表單類別：負責接收使用者輸入、處理按鈕事件。
    /// 以下所有方法皆以繁體中文註解，說明用途與參數。
    /// UI 的文字與字型（18pt）已在 Form1.Designer.cs 中設定。
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建構子：初始化表單與元件。
        /// InitializeComponent() 會建立並設定所有控制項（其中文字已改為繁體中文，字型統一為 18pt）。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 「檢查資格」按鈕的事件處理程序。
        /// 目前此範例尚未實作具體檢查邏輯（原專案亦為空）。
        /// 可在此加入：
        /// - 解析 salaryTextBox.Text 與 yearsTextBox.Text
        /// - 驗證輸入格式（數字、範圍）
        /// - 判斷是否符合貸款資格，並將結果顯示於 decisionLabel
        /// 範例實作可以根據需求補上。
        /// </summary>
        private void checkButton_Click(object sender, EventArgs e)
        {
            const decimal MINIMUM_SALARY = 1200000m;// 最低年薪要求
            const int MINIMUM_YEARS = 2;           // 最低年資要求

            decimal salary;                        // 使用者輸入的年薪
            int yearsOnJob;                         // 使用者輸入的年資

            try
            {
                salary = decimal.Parse(salaryTextBox.Text);
                yearsOnJob = int.Parse(yearsTextBox.Text);
                if (salary >= MINIMUM_SALARY)
                {
                    if (yearsOnJob >= MINIMUM_YEARS)
                    {
                        decisionLabel.Text = "符合資格";
                    }
                    else
                    {
                        decisionLabel.Text = "不符合：年資未達最低標準";
                    }
                }
                else
                {
                    decisionLabel.Text = "不符合：收入未達最低標準";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            // 範例提示（保留為註解型範例）
            // double salary;
            // int years;
            // if (double.TryParse(salaryTextBox.Text, out salary) &&
            //     int.TryParse(yearsTextBox.Text, out years))
            // {
            //     // 實作資格判斷邏輯...
            //     // decisionLabel.Text = "通過";
            // }
            // else
            // {
            //     decisionLabel.Text = "請輸入有效的年薪與年資（數字）";
            // }
        

        /// <summary>
        /// 「清除」按鈕的事件處理程序。
        /// 清空年薪、年資輸入欄位以及決定顯示欄位，並將焦點重設到年薪欄位。
        /// </summary>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除 TextBox 與結果標籤的內容
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // 將鍵盤焦點重設到年薪輸入欄位，方便使用者繼續輸入
            salaryTextBox.Focus();
        }

        /// <summary>
        /// 「結束」按鈕的事件處理程序。
        /// 關閉目前表單（結束應用程式視專案啟動方式而定）。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
