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
using System.Threading;

namespace Friend_File
{
    public partial class Form1 : Form
    {
        // 新增計數器欄位並初始化（盡量不改其他邏輯）
        private int count = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            
            // 設定預設資料夾為 文件 (My Documents)
            saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFile.Title = "選擇儲存朋友名字的檔案";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                outputFile = File.AppendText(saveFile.FileName);
                outputFile.WriteLine(count + ": " + nameTextBox.Text);
                outputFile.Close();
            }
            else
            {
                MessageBox.Show("未選擇檔案");
            }
            nameTextBox.Text = "";
            nameTextBox.Focus();
            count++;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
