namespace Pay_and_Bonus
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable
        /// 必要的設計工具變數
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// 清除所使用的資源 (繁體中文註解)
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            // 如果 disposing 為 true，則處置受控資源
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// 初始化元件 (已手動調整)
        /// - 將所有文字改為繁體中文
        /// - 將表單與元件字型設定為 18pt (Microsoft JhengHei)
        /// - 調整各元件大小與相對位置，確保在較大字型下顯示良好
        /// 注意：此方法為設計檔中元件建立與屬性設定，請勿在執行時以外修改名稱或事件綁定。
        /// </summary>
        private void InitializeComponent()
        {
            this.grossPayPromptLabel = new System.Windows.Forms.Label();
            this.bonusPromptLabel = new System.Windows.Forms.Label();
            this.grossPayTextBox = new System.Windows.Forms.TextBox();
            this.bonusTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.contributionLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 全域字型設定（表單與子元件會繼承此字型）
            // 使用 Microsoft JhengHei（微軟正黑體）以確保繁體中文字型顯示正確，字型大小設為 18pt
            // 若系統無此字型，會退回至系統預設字型
            // 
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // grossPayPromptLabel
            // 總計薪資提示標籤（繁體中文）
            // 設定為 AutoSize 以便依字型大小自動調整顯示空間
            // 放置於表單左上方，與輸入欄位保持水平對齊
            // 
            this.grossPayPromptLabel.AutoSize = true;
            this.grossPayPromptLabel.Location = new System.Drawing.Point(20, 20);
            this.grossPayPromptLabel.Name = "grossPayPromptLabel";
            this.grossPayPromptLabel.Size = new System.Drawing.Size(150, 30);
            this.grossPayPromptLabel.TabIndex = 0;
            this.grossPayPromptLabel.Text = "總計薪資：";
            // 
            // bonusPromptLabel
            // 獎金金額提示標籤（繁體中文）
            // 與總計薪資標籤垂直排列，保持一致間距
            // 
            this.bonusPromptLabel.AutoSize = true;
            this.bonusPromptLabel.Location = new System.Drawing.Point(20, 72);
            this.bonusPromptLabel.Name = "bonusPromptLabel";
            this.bonusPromptLabel.Size = new System.Drawing.Size(150, 30);
            this.bonusPromptLabel.TabIndex = 1;
            this.bonusPromptLabel.Text = "獎金金額：";
            // 
            // grossPayTextBox
            // 總計薪資輸入欄位
            // 增加高度以配合 18pt 字型，寬度足以容納較長數值或千分位格式
            // 
            this.grossPayTextBox.Location = new System.Drawing.Point(210, 16);
            this.grossPayTextBox.Name = "grossPayTextBox";
            this.grossPayTextBox.Size = new System.Drawing.Size(220, 39);
            this.grossPayTextBox.TabIndex = 2;
            // 
            // bonusTextBox
            // 獎金輸入欄位
            // 與上方輸入欄位寬度相同，垂直間距配置一致
            // 
            this.bonusTextBox.Location = new System.Drawing.Point(210, 68);
            this.bonusTextBox.Name = "bonusTextBox";
            this.bonusTextBox.Size = new System.Drawing.Size(220, 39);
            this.bonusTextBox.TabIndex = 3;
            // 
            // outputDescriptionLabel
            // 顯示輸出描述（繁體中文）
            // 說明下方欄位顯示的計算結果為退休年金提撥
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(20, 126);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(150, 30);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "退休年金提撥：";
            // 
            // contributionLabel
            // 顯示計算結果的欄位（邊框、置中）
            // 增加高度與寬度，置中顯示結果文字
            // 
            this.contributionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contributionLabel.Location = new System.Drawing.Point(210, 122);
            this.contributionLabel.Name = "contributionLabel";
            this.contributionLabel.Size = new System.Drawing.Size(220, 44);
            this.contributionLabel.TabIndex = 5;
            this.contributionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 計算按鈕（繁體中文）
            // 放置於表單下方，使用較大的按鈕尺寸以便使用者操作
            // 綁定 calculateButton_Click 事件（請勿更動）
            // 
            this.calculateButton.Location = new System.Drawing.Point(80, 185);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(130, 50);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "計算提撥";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 離開按鈕（繁體中文）
            // 放置於右側，與計算按鈕對齊，提供一致的大小與間距
            // 綁定 exitButton_Click 事件（請勿更動）
            // 
            this.exitButton.Location = new System.Drawing.Point(260, 185);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(130, 50);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 主表單屬性設定（繁體中文註解）
            // 調整 ClientSize 以容納字型與元件，並設定表單標題為繁體中文
            // AutoScaleMode 保持為 Font，以便在不同 DPI/字型下自動縮放
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 260);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.contributionLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.bonusTextBox);
            this.Controls.Add(this.grossPayTextBox);
            this.Controls.Add(this.bonusPromptLabel);
            this.Controls.Add(this.grossPayPromptLabel);
            this.Name = "Form1";
            this.Text = "薪資與獎金";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label grossPayPromptLabel;
        private System.Windows.Forms.Label bonusPromptLabel;
        private System.Windows.Forms.TextBox grossPayTextBox;
        private System.Windows.Forms.TextBox bonusTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label contributionLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }