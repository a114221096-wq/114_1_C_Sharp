namespace Q1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxComputer = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1 (電腦)
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(135, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "電腦出";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2 (玩家)
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(517, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "玩家出";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1 (石頭)
            // 
            this.button1.Location = new System.Drawing.Point(102, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "石頭";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.stoneButton_Click);
            // 
            // button2 (布)
            // 
            this.button2.Location = new System.Drawing.Point(309, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 56);
            this.button2.TabIndex = 3;
            this.button2.Text = "布";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // button3 (剪刀)
            // 
            this.button3.Location = new System.Drawing.Point(521, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 56);
            this.button3.TabIndex = 4;
            this.button3.Text = "剪刀";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.scissorButton_Click);
            // 
            // button4 (結束遊戲)
            // 
            this.button4.Location = new System.Drawing.Point(309, 365);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 56);
            this.button4.TabIndex = 5;
            this.button4.Text = "結束遊戲";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label3 (計分)
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(309, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "玩家:0   電腦:0   平手:0";
            // 
            // pictureBoxComputer
            // 
            this.pictureBoxComputer.Location = new System.Drawing.Point(119, 80);
            this.pictureBoxComputer.Name = "pictureBoxComputer";
            this.pictureBoxComputer.Size = new System.Drawing.Size(183, 150);
            this.pictureBoxComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxComputer.TabIndex = 7;
            this.pictureBoxComputer.TabStop = false;
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.Location = new System.Drawing.Point(501, 80);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(183, 150);
            this.pictureBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlayer.TabIndex = 8;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.pictureBoxComputer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "石頭布剪刀";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxComputer;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
    }
}

