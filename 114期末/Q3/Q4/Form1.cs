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

namespace Q4
{
    public partial class Form1 : Form
    {
        // 狀態與資料
        private int[] userNumbers = new int[5];
        private int[] winningNumbers = new int[5];
        private bool hasUserNumbers = false;
        private bool hasWinningNumbers = false;
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

            // 綁定事件
            this.button1.Click += button1_Click; // 產生號碼
            this.button2.Click += button2_Click; // 開獎號碼（讀檔）
            this.button3.Click += button3_Click; // 離開

            // 初始控制邏輯：必須先按「產生號碼」再按「開獎號碼」比對
            this.button2.Enabled = false;
        }

        // 產生號碼按鈕事件：使用基本迴圈與判斷產生不重複隨機數字（1-49）
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                GenerateUserNumbers();
                DisplayUserNumbers();
                listBox1.Items.Clear();
                listBox1.Items.Add("已產生使用者號碼。請按「開獎號碼」讀取檔案以比對。");

                hasWinningNumbers = false;
                button2.Enabled = true; // 產號後可讀取開獎號碼
            }
            catch (Exception ex)
            {
                MessageBox.Show("產生號碼時發生錯誤： " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 開獎號碼按鈕事件：開啟檔案並讀取、驗證內容，完成後自動比對
        private void button2_Click(object sender, EventArgs e)
        {
            // 需先產生使用者號碼
            if (!hasUserNumbers)
            {
                MessageBox.Show("請先按「產生號碼」以建立使用者號碼，再讀取開獎號碼檔案。", "流程順序", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            openFileDialog1.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
            openFileDialog1.Title = "選擇開獎號碼檔案 (每行一個數字，共 5 行)";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            string path = openFileDialog1.FileName;
            try
            {
                ReadWinningNumbersFromFile(path);
                hasWinningNumbers = true;
                listBox1.Items.Add("讀取成功：開獎號碼已載入。");
                DisplayWinningNumbers();
                CompareNumbers(); // 讀檔成功後立即比對
            }
            catch (FileNotFoundException)
            {
                string msg = "找不到檔案：" + path;
                MessageBox.Show(msg, "檔案錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBox1.Items.Add(msg);
            }
            catch (UnauthorizedAccessException)
            {
                string msg = "無權限讀取檔案：" + path;
                MessageBox.Show(msg, "權限錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBox1.Items.Add(msg);
            }
            catch (FormatException fex)
            {
                string msg = "檔案格式錯誤：" + fex.Message;
                MessageBox.Show(msg, "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBox1.Items.Add(msg);
            }
            catch (ArgumentOutOfRangeException arex)
            {
                string msg = "數字範圍錯誤：" + arex.Message;
                MessageBox.Show(msg, "範圍錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBox1.Items.Add(msg);
            }
            catch (Exception ex)
            {
                string msg = "讀檔時發生未預期的錯誤：" + ex.Message;
                MessageBox.Show(msg, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBox1.Items.Add(msg);
            }
        }

        // 離開按鈕事件
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 產生不重複隨機數字（基本迴圈與條件）
        private void GenerateUserNumbers()
        {
            hasUserNumbers = false;

            for (int i = 0; i < 5; i++)
            {
                bool placed = false;
                // 反覆產生直到找到不重複且合法的數
                while (!placed)
                {
                    int candidate = rnd.Next(1, 50); // 1..49
                    bool duplicate = false;
                    // 檢查已產生的數字 (基本迴圈)
                    for (int j = 0; j < i; j++)
                    {
                        if (userNumbers[j] == candidate)
                        {
                            duplicate = true;
                            break;
                        }
                    }
                    if (!duplicate)
                    {
                        userNumbers[i] = candidate;
                        placed = true;
                    }
                }
            }

            hasUserNumbers = true;
        }

        // 顯示使用者號碼到 5 個 Label
        private void DisplayUserNumbers()
        {
            Label[] labels = new Label[] { label1, label2, label3, label4, label5 };
            for (int i = 0; i < 5; i++)
            {
                labels[i].Text = userNumbers[i].ToString();
            }
        }

        // 顯示開獎號碼（加入 listBox 顯示）
        private void DisplayWinningNumbers()
        {
            listBox1.Items.Add("------- 開獎號碼 -------");
            for (int i = 0; i < 5; i++)
            {
                listBox1.Items.Add($"第 {i + 1} 行: {winningNumbers[i]}");
            }
            listBox1.Items.Add("------------------------");
        }

        // 讀取並驗證開獎號碼檔案內容
        private void ReadWinningNumbersFromFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException();

            string[] lines;
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                List<string> temp = new List<string>();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    temp.Add(line.Trim());
                }
                lines = temp.ToArray();
            }

            if (lines.Length != 5)
                throw new FormatException($"檔案需包含 5 行，實際為 {lines.Length} 行。");

            // 暫存並驗證每一行
            int[] tmp = new int[5];
            for (int i = 0; i < 5; i++)
            {
                string s = lines[i];
                if (string.IsNullOrWhiteSpace(s))
                    throw new FormatException($"第 {i + 1} 行為空白或格式錯誤。");

                int val;
                if (!int.TryParse(s, out val))
                    throw new FormatException($"第 {i + 1} 行不是有效整數：\"{s}\"。");

                if (val < 1 || val > 49)
                    throw new ArgumentOutOfRangeException($"第 {i + 1} 行數字 ({val}) 必須在 1 到 49 範圍內。");

                // 檢查重複
                for (int j = 0; j < i; j++)
                {
                    if (tmp[j] == val)
                        throw new FormatException($"第 {i + 1} 行的數字 ({val}) 與第 {j + 1} 行重複。");
                }

                tmp[i] = val;
            }

            // 驗證通過後複製到 winningNumbers
            for (int i = 0; i < 5; i++) winningNumbers[i] = tmp[i];
        }

        // 比對使用者號碼與開獎號碼，計算中獎數並判定獎項
        private void CompareNumbers()
        {
            if (!hasUserNumbers)
            {
                MessageBox.Show("尚未產生使用者號碼。", "狀態錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!hasWinningNumbers)
            {
                MessageBox.Show("尚未載入開獎號碼。請先讀取開獎號碼檔案。", "狀態錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int matchCount = 0;
            List<int> matchedNumbers = new List<int>();
            // 使用基本巢狀迴圈進行比對
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (userNumbers[i] == winningNumbers[j])
                    {
                        matchCount++;
                        matchedNumbers.Add(userNumbers[i]);
                        break; // 同一使用者號碼只計一次
                    }
                }
            }

            string prize = DeterminePrize(matchCount);

            listBox1.Items.Add($"比對結果：使用者中 {matchCount} 個號碼。");
            if (matchedNumbers.Count > 0)
            {
                listBox1.Items.Add("中獎號碼：" + string.Join(", ", matchedNumbers));
            }
            listBox1.Items.Add($"獎項判定：{prize}");
            listBox1.Items.Add("------------------------");
        }

        // 根據中獎數量回傳獎項等級
        private string DeterminePrize(int matchCount)
        {
            // 可依需求調整對應關係
            if (matchCount == 5) return "一等（恭喜！）";
            else if (matchCount == 4) return "二等";
            else if (matchCount == 3) return "三等";
            else if (matchCount == 2) return "四等（小獎）";
            else return "未中獎";
        }
    }
}
