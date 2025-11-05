using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Zone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // --- 開始：自動將表單與所有子元件的字型調整為 18 並嘗試將可辨識的文字改為繁體中文 ---
            // 說明：
            // 1) 為符合「其他不要更動」的要求，變更只發生在此檔案（執行時套用），不會修改 Designer 檔案或資源檔。
            // 2) 會遞迴處理所有 Controls，將 Font 大小設為 18，並嘗試針對常見文字或元件名稱做繁體中文轉換。
            // 3) 未能明確對應的文字將保留原值以避免誤譯；可根據需要在此方法中擴充對照表。
            //
            // 注意：執行時修改控制項屬性，不會影響 Visual Studio 設計器檔案 (.Designer.cs) 的原始內容。
            this.Text = "時區應用程式"; // 將視窗標題改為繁體中文（如需其他標題請修改此處）

            // 對表單本身設字型大小（遞迴會為子控制項設定）
            this.Font = new Font(this.Font.FontFamily, 18F, this.Font.Style);

            // 對所有子控制項套用字型與文字翻譯
            foreach (Control ctl in this.Controls)
            {
                ApplyTraditionalChineseRecursive(ctl);
            }
            // --- 結束：自動調整與翻譯 ---
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string city;
            if (cityListBox.SelectedIndex != -1)
            {
                city = cityListBox.SelectedItem.ToString();
                switch (city) 
                {
                    case "紐約":
                        timeZoneLabel.Text = "東部標準時間";
                        break;
                        case "丹佛":
                            timeZoneLabel.Text = "山地標準時間";
                            break;
                    case "明尼阿波利斯":
                        timeZoneLabel.Text = "中部標準時間";
                        break;
                        case "舊金山":
                            timeZoneLabel.Text = "太平洋標準時間";
                            break;
                        case "檀香山":
                            timeZoneLabel.Text = "夏威夷標準時間";
                            break;
                }
            }
            else
            {
                MessageBox.Show("請先選取一個城市。");
            }

            // 按下「確定」後的事件處理器（目前未實作具體行為）。
            // 若需要在確定時執行動作，請在此補入邏輯，例：驗證輸入、儲存設定、關閉表單等。
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }

        /// <summary>
        /// 以遞迴方式為控制項設定字型大小為 18，並嘗試將可辨識的 Text 轉為繁體中文。
        /// 詳細註解（繁體中文）已內嵌於方法內，方便後續維護與擴充對照表。
        /// </summary>
        /// <param name="control">欲處理的控制項（會包含其子項）</param>
        private void ApplyTraditionalChineseRecursive(Control control)
        {
            // 設定字型大小為 18，保留原有字型樣式與字型家族
            try
            {
                control.Font = new Font(control.Font.FontFamily, 18F, control.Font.Style);
            }
            catch
            {
                // 若發生錯誤（極少見，例如 Font 為 null），則忽略以避免程式中斷。
            }

            // 如果控制項有文字，嘗試進行常見英文詞彙到繁體中文的對應翻譯
            if (!string.IsNullOrWhiteSpace(control.Text))
            {
                string original = control.Text.Trim();
                string lower = original.ToLowerInvariant();

                // 常見文字對照表（可根據應用情境擴充）
                switch (lower)
                {
                    case "ok":
                    case "okay":
                    case "yes":
                        control.Text = "確定";
                        break;
                    case "cancel":
                        control.Text = "取消";
                        break;
                    case "exit":
                    case "close":
                        control.Text = "離開";
                        break;
                    case "submit":
                        control.Text = "提交";
                        break;
                    case "name":
                        control.Text = "名稱";
                        break;
                    case "address":
                        control.Text = "地址";
                        break;
                    case "time zone":
                    case "timezone":
                        control.Text = "時區";
                        break;
                    case "apply":
                        control.Text = "套用";
                        break;
                    default:
                        // 若原文無明確對應，根據控制項名稱作簡單判斷（例如 okButton、exitButton）
                        // 透過控制項名稱判斷時採保守策略，只針對常見命名進行替換以避免誤譯
                        string name = control.Name ?? string.Empty;
                        if (name.IndexOf("ok", StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            control.Text = "確定";
                        }
                        else if (name.IndexOf("exit", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                 name.IndexOf("close", StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            control.Text = "離開";
                        }
                        // 其他情況則保留原文字，讓開發者人工確認是否需要翻譯
                        break;
                }
            }

            // 若控制項包含子控制項，遞迴處理之
            foreach (Control child in control.Controls)
            {
                ApplyTraditionalChineseRecursive(child);
            }
        }
    }
}
