using System;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        private enum Choice { Rock = 0, Paper = 1, Scissor = 2 }

        private readonly Random rnd = new Random();
        private Choice playerChoice;
        private Choice compChoice;

        private int playerWins = 0;
        private int compWins = 0;
        private int ties = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 初始化畫面
            pictureBoxComputer.Image = null;
            pictureBoxPlayer.Image = null;
            UpdateScoreLabel();
        }

        private void stoneButton_Click(object sender, EventArgs e)
        {
            playerChoice = Choice.Rock;
            PlayRound();
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            playerChoice = PAPER;
                PlayRound();
        }

        private void scissorButton_Click(object sender, EventArgs e)
        {
            playerChoice = Choice.Scissor;
            PlayRound();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            string summary = $"遊戲結束 - 統計\n\n玩家勝利: {playerWins}\n電腦勝利: {compWins}\n平手: {ties}";
            MessageBox.Show(summary, "遊戲統計", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        // 產生電腦選擇
        private void getCompChoice()
        {
            compChoice = (Choice)rnd.Next(0, 3);
        }

        // 顯示電腦圖片（從外部檔案載入，避免鎖檔案）
        private void showComputerImage()
        {
            // 範例：專案輸出目錄下的 Images 資料夾
            string fileName = compChoice == Choice.Rock ? "comp_rock.png"
                            : compChoice == Choice.Paper ? "comp_paper.png"
                            : "comp_scissor.png";

            string imagePath = System.IO.Path.Combine(Application.StartupPath, "Images", fileName);

            // 如果外部檔不存在，回退到內建 Resources（如果有）
            if (!System.IO.File.Exists(imagePath))
            {
                switch (compChoice)
                {
                    case Choice.Rock:
                        pictureBoxComputer.Image = Properties.Resources.stone_computer;
                        break;
                    case Choice.Paper:
                        pictureBoxComputer.Image = Properties.Resources.paper_computer;
                        break;
                    case Choice.Scissor:
                        pictureBoxComputer.Image = Properties.Resources.scissor_computer;
                        break;
                }
                pictureBoxComputer.SizeMode = PictureBoxSizeMode.Zoom;
                return;
            }

            // 載入檔案到記憶體中的副本，避免鎖定原檔
            var previous = pictureBoxComputer.Image;
            try
            {
                using (var fs = new System.IO.FileStream(imagePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                using (var img = System.Drawing.Image.FromStream(fs))
                {
                    pictureBoxComputer.Image = new System.Drawing.Bitmap(img);
                }
                pictureBoxComputer.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show("載入圖片失敗: " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 釋放舊的 Image（若有）
                if (previous != null)
                {
                    try { previous.Dispose(); } catch { }
                }
            }
        }

        // 顯示玩家圖片
        private void showPlayerImage()
        {
            switch (playerChoice)
            {
                case Choice.Rock:
                    pictureBoxPlayer.Image = Properties.Resources.stone_player;
                    break;
                case Choice.Paper:
                    pictureBoxPlayer.Image = Properties.Resources.paper_player;
                    break;
                case Choice.Scissor:
                    pictureBoxPlayer.Image = Properties.Resources.scissor_player;
                    break;
            }
        }

        // 判斷勝負並計分、顯示結果
        private void showWinner()
        {
            if (playerChoice == compChoice)
            {
                ties++;
                //MessageBox.Show("平手！", "結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (
                (playerChoice == Choice.Rock && compChoice == Choice.Scissor) ||
                (playerChoice == Choice.Scissor && compChoice == Choice.Paper) ||
                (playerChoice == Choice.Paper && compChoice == Choice.Rock)
            )
            {
                playerWins++;
                //MessageBox.Show("你贏了！", "結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                compWins++;
                //MessageBox.Show("你輸了。", "結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            UpdateScoreLabel();
        }

        private void UpdateScoreLabel()
        {
            label3.Text = $"玩家: {playerWins}   電腦: {compWins}   平手: {ties}";
        }

        // 執行一回合
        private void PlayRound()
        {
            getCompChoice();
            showPlayerImage();
            showComputerImage();
            showWinner();
        }
    }
}
