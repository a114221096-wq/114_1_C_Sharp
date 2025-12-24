using System;
using System.Globalization;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        // 可調整的工時費率（NT$ / 小時）
        private const double HOURLY_RATE = 600.0;

        public Form1()
        {
            InitializeComponent();
        }

        // 機油和潤滑服務費用
        private double OilLubeCharges()
        {
            double total = 0;
            if (checkBox1.Checked) total += 780; // 更換機油
            if (checkBox2.Checked) total += 540; // 潤滑保養
            return total;
        }

        // 清洗服務費用
        private double FlushCharges()
        {
            double total = 0;
            if (checkBox3.Checked) total += 900;  // 水箱清洗
            if (checkBox4.Checked) total += 2400; // 變速箱清洗
            return total;
        }

        // 其他服務費用
        private double MiscCharges()
        {
            double total = 0;
            if (checkBox5.Checked) total += 450;  // 檢驗
            if (checkBox6.Checked) total += 3000; // 更換消音器
            if (checkBox7.Checked) total += 600;  // 輪胎換位
            return total;
        }

        // 零件與工時費用（直接由 textBox1, textBox2 讀取）
        // 回傳 parts + labor，並以 out 輸出 parts 與 labor
        private double OtherCharges(out double parts, out double labor)
        {
            parts = 0;
            labor = 0;

            var culture = CultureInfo.CurrentCulture;

            // 解析零件欄（允許空字串視為 0）
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (!double.TryParse(textBox1.Text.Trim(), NumberStyles.Number, culture, out parts) || parts < 0)
                {
                    MessageBox.Show("請在「零件」欄位輸入有效的非負數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    throw new InvalidOperationException("零件輸入無效");
                }
            }

            // 解析工時欄（允許空字串視為 0）
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                double hours;
                if (!double.TryParse(textBox2.Text.Trim(), NumberStyles.Number, culture, out hours) || hours < 0)
                {
                    MessageBox.Show("請在「工時數」欄位輸入有效的非負數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Focus();
                    throw new InvalidOperationException("工時輸入無效");
                }
                labor = hours * HOURLY_RATE;
            }

            return parts + labor;
        }

        // 稅金（零件 6%）
        private double TaxCharges(double parts)
        {
            return parts * 0.06;
        }

        // 計算總費用（服務與工資總額 + 零件 + 稅金）
        private double TotalCharges(double serviceAndLabor, double parts, double tax)
        {
            return serviceAndLabor + parts + tax;
        }

        // 計算按鈕事件
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double oilLube = OilLubeCharges();
                double flush = FlushCharges();
                double misc = MiscCharges();

                // 所有選定服務費用（不含工時）
                double serviceFees = oilLube + flush + misc;

                // 取得零件與工時費用（並分別得到 parts, labor）
                double parts, labor;
                OtherCharges(out parts, out labor);

                // 服務與工資總額 = 所有選定服務費用 + 工時費用
                double serviceAndLaborTotal = serviceFees + labor;

                // 稅金 = 零件 × 6%
                double tax = TaxCharges(parts);

                // 總費用 = 服務與工資總額 + 零件 + 稅金
                double total = TotalCharges(serviceAndLaborTotal, parts, tax);

                // 顯示結果（以 NT$ 兩位小數）
                label1.Text = $"NT${serviceAndLaborTotal:0.00}";
                label2.Text = $"NT${parts:0.00}";
                label3.Text = $"NT${tax:0.00}";
                label4.Text = $"NT${total:0.00}";
            }
            catch (InvalidOperationException)
            {
                // 驗證錯誤已提示給使用者，直接中止計算
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 清除按鈕事件
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        // 離開按鈕事件
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 清除機油潤滑選項
        private void ClearOilLube()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        // 清除清洗服務選項
        private void ClearFlushes()
        {
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        // 清除其他服務選項
        private void ClearMisc()
        {
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
        }

        // 清除零件和工時輸入（移除對不存在 checkbox 的參考）
        private void ClearOther()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        // 清除費用顯示
        private void ClearFees()
        {
            label1.Text = string.Empty;
            label2.Text = string.Empty;
            label3.Text = string.Empty;
            label4.Text = string.Empty;
        }
    }
}
