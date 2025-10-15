namespace Payroll_with_Overtime
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計工具變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// 若 disposing 為 true，則同時處置管理資源。
        /// </summary>
        /// <param name="disposing">如果應該處置管理資源，則為 true；否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// 此方法為設計器所需。請勿用程式碼編輯器修改方法內容（會被設計器覆寫）。
        /// 變更項目說明（繁體中文註解）：
        /// - 將所有可見文字(Text 屬性)改為繁體中文。
        /// - 將所有控制項字型設為 22pt（使用 Microsoft JhengHei UI 以確保繁體中文顯示清晰）。
        /// - 調整控制項大小與表單 ClientSize 以避免 22pt 字型被截斷。
        /// - 在程式碼內以繁體中文加入詳細註解說明每個區塊用途與變更理由。
        /// </summary>
        private void InitializeComponent()
        {
            // 宣告控制項實例（與設計器原來的一致）
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.hourlyPayRateTextBox = new System.Windows.Forms.TextBox();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.hourlyPayRatePromptLabel = new System.Windows.Forms.Label();
            this.hoursWorkedPromptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 通用字型設定：所有可見文字使用 22pt 微軟正黑體 UI（Microsoft JhengHei UI）
            // 注意：Windows 若無該字型會退回到系統預設字型，但仍會套用 22pt 字級。
            var uiFont = new System.Drawing.Font("Microsoft JhengHei UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));

            // -------------------------
            // hoursWorkedPromptLabel
            // 提示使用者輸入工作時數（左側標籤）
            // -------------------------
            this.hoursWorkedPromptLabel.AutoSize = true;
            this.hoursWorkedPromptLabel.Location = new System.Drawing.Point(20, 18);
            this.hoursWorkedPromptLabel.Name = "hoursWorkedPromptLabel";
            this.hoursWorkedPromptLabel.Size = new System.Drawing.Size(180, 37);
            this.hoursWorkedPromptLabel.TabIndex = 18;
            // 將提示文字改為繁體中文，並套用 22pt 字型
            this.hoursWorkedPromptLabel.Text = "工作時數：";
            this.hoursWorkedPromptLabel.Font = uiFont;

            // -------------------------
            // hourlyPayRatePromptLabel
            // 提示使用者輸入時薪（左側標籤）
            // -------------------------
            this.hourlyPayRatePromptLabel.AutoSize = true;
            this.hourlyPayRatePromptLabel.Location = new System.Drawing.Point(20, 70);
            this.hourlyPayRatePromptLabel.Name = "hourlyPayRatePromptLabel";
            this.hourlyPayRatePromptLabel.Size = new System.Drawing.Size(180, 37);
            this.hourlyPayRatePromptLabel.TabIndex = 19;
            // 將提示文字改為繁體中文，並套用 22pt 字型
            this.hourlyPayRatePromptLabel.Text = "時薪：";
            this.hourlyPayRatePromptLabel.Font = uiFont;

            // -------------------------
            // hoursWorkedTextBox
            // 工作時數輸入欄位（右側輸入框）
            // 字型放大以利閱讀與輸入大量數字時仍清晰
            // -------------------------
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(220, 15);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            // 增加高度以符合 22pt 顯示
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(280, 46);
            this.hoursWorkedTextBox.TabIndex = 20;
            this.hoursWorkedTextBox.Font = uiFont;

            // -------------------------
            // hourlyPayRateTextBox
            // 時薪輸入欄位（右側輸入框）
            // -------------------------
            this.hourlyPayRateTextBox.Location = new System.Drawing.Point(220, 67);
            this.hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
            this.hourlyPayRateTextBox.Size = new System.Drawing.Size(280, 46);
            this.hourlyPayRateTextBox.TabIndex = 21;
            this.hourlyPayRateTextBox.Font = uiFont;

            // -------------------------
            // outputDescriptionLabel
            // 輸出欄位的描述文字（例如「總薪資：」）
            // -------------------------
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(20, 126);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(180, 37);
            this.outputDescriptionLabel.TabIndex = 22;
            // 將描述改為繁體中文並套用 22pt 字型
            this.outputDescriptionLabel.Text = "總薪資：";
            this.outputDescriptionLabel.Font = uiFont;

            // -------------------------
            // grossPayLabel
            // 顯示計算後總薪資的欄位（初始為空白）
            // 設定為 FixedSingle 以讓輸出看起來像只讀欄位
            // -------------------------
            this.grossPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grossPayLabel.Location = new System.Drawing.Point(220, 122);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(280, 46);
            this.grossPayLabel.TabIndex = 23;
            this.grossPayLabel.Font = uiFont;
            this.grossPayLabel.Text = ""; // 初始不顯示任何文字，程式計算後再設定

            // -------------------------
            // calculateButton
            // 計算總薪資按鈕（左下）
            // -------------------------
            this.calculateButton.Location = new System.Drawing.Point(20, 180);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(180, 55);
            this.calculateButton.TabIndex = 24;
            // 將按鈕文字改為繁體中文並套用 22pt 字型
            this.calculateButton.Text = "計算總薪資";
            this.calculateButton.Font = uiFont;
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);

            // -------------------------
            // clearButton
            // 清除按鈕（中下）
            // -------------------------
            this.clearButton.Location = new System.Drawing.Point(210, 180);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(140, 55);
            this.clearButton.TabIndex = 25;
            this.clearButton.Text = "清除";
            this.clearButton.Font = uiFont;
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);

            // -------------------------
            // exitButton
            // 離開按鈕（右下）
            // -------------------------
            this.exitButton.Location = new System.Drawing.Point(370, 180);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(130, 55);
            this.exitButton.TabIndex = 26;
            this.exitButton.Text = "離開";
            this.exitButton.Font = uiFont;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);

            // -------------------------
            // Form1（表單整體設定）
            // - 調整 ClientSize 以容納 22pt 字型與增大控制項
            // - 設定表單標題為繁體中文
            // -------------------------
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // ClientSize 增大，以避免 22pt 字型顯示時擁擠或截斷
            this.ClientSize = new System.Drawing.Size(520, 250);
            // 將控制項加入表單
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.grossPayLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.hourlyPayRateTextBox);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(this.hourlyPayRatePromptLabel);
            this.Controls.Add(this.hoursWorkedPromptLabel);
            this.Name = "Form1";
            // 將表單標題改為繁體中文，方便使用者辨識功能
            this.Text = "加班薪資計算";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // 控制項欄位定義（與原始檔案一致，存取層級 internal）
        internal System.Windows.Forms.Button exitButton;
        internal System.Windows.Forms.Button clearButton;
        internal System.Windows.Forms.Button calculateButton;
        internal System.Windows.Forms.Label grossPayLabel;
        internal System.Windows.Forms.Label outputDescriptionLabel;
        internal System.Windows.Forms.TextBox hourlyPayRateTextBox;
        internal System.Windows.Forms.TextBox hoursWorkedTextBox;
        internal System.Windows.Forms.Label hourlyPayRatePromptLabel;
        internal System.Windows.Forms.Label hoursWorkedPromptLabel;
    }
}

