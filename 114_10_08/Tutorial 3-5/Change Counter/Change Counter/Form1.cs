using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    // 表單：讓使用者點選不同面額的硬幣，並在 totalLabel 顯示累計值
    public partial class Form1 : Form
    {
        // 常數：各硬幣面額（此處以「分 / cents」為單位）
        // 使用 decimal 可以避免浮點數精度問題（比 float/double 更適合處理金額）
        // 注意：這些常數的值代表「分」，例如 5 代表 5 分（不是 0.05 元）
        const decimal FIVE_CENTS = 5.0m;
        const decimal TEN_CENTS = 10.0m;
        const decimal TWENTY_FIVE_CENTS = 25.0m;
        const decimal FIFTY_CENTS = 50.0m;

        // total 用來累計目前的金額（以分為單位，使用 decimal 型別）
        // 註：為了完全避免小數運算及更直觀地表示「分」，可以考慮改為 int totalCents。
        private decimal total;

        // 建構子：初始化元件（由 Designer 產生）
        public Form1()
        {
            InitializeComponent();
            // 若需要在啟動時顯示初始值（例如 "0.00" 或 "0"），可於此處設定 totalLabel.Text
            // 例如： totalLabel.Text = "0";
        }

        // 五分硬幣點擊事件
        // 每次點擊將對 total 增加對應面額（此範例直接以整數 5 加入，會隱式轉為 decimal）
        // 然後把更新後的數值以字串方式顯示在 totalLabel
        // 注意：目前使用 total.ToString()，會顯示純數字（例如 "5", "15"）。若希望顯示貨幣格式（含符號與小數點）
        // 可使用 (total/100).ToString("C")（除以 100 轉為「元」並使用貨幣格式）。
        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += FIVE_CENTS;                 // 增加 5 分
            totalLabel.Text = total.ToString(); // 更新顯示（純數字）
        }

        // 十分硬幣點擊事件（同上）
        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += TEN_CENTS;                // 增加 10 分
            totalLabel.Text = total.ToString();
        }

        // 二十五分硬幣點擊事件（同上）
        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += TWENTY_FIVE_CENTS;                // 增加 25 分
            totalLabel.Text = total.ToString();
        }

        // 五十分硬幣點擊事件（同上）
        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += FIFTY_CENTS;                // 增加 50 分
            totalLabel.Text = total.ToString();
        }

        // 離開按鈕：關閉表單（結束應用程式視啟動方式而定）
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }               
    }
}
