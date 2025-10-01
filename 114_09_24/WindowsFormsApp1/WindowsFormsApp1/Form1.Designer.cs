namespace WindowsFormsApp1
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
            this.星期 = new System.Windows.Forms.Label();
            this.日 = new System.Windows.Forms.Label();
            this.月 = new System.Windows.Forms.Label();
            this.年 = new System.Windows.Forms.Label();
            this.weekTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 星期
            // 
            this.星期.AutoSize = true;
            this.星期.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.星期.Location = new System.Drawing.Point(103, 48);
            this.星期.Name = "星期";
            this.星期.Size = new System.Drawing.Size(129, 48);
            this.星期.TabIndex = 0;
            this.星期.Text = "星期:";
            // 
            // 日
            // 
            this.日.AutoSize = true;
            this.日.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.日.Location = new System.Drawing.Point(151, 229);
            this.日.Name = "日";
            this.日.Size = new System.Drawing.Size(81, 48);
            this.日.TabIndex = 1;
            this.日.Text = "日:";
            // 
            // 月
            // 
            this.月.AutoSize = true;
            this.月.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.月.Location = new System.Drawing.Point(151, 134);
            this.月.Name = "月";
            this.月.Size = new System.Drawing.Size(81, 48);
            this.月.TabIndex = 2;
            this.月.Text = "月:";
            // 
            // 年
            // 
            this.年.AutoSize = true;
            this.年.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.年.Location = new System.Drawing.Point(151, 322);
            this.年.Name = "年";
            this.年.Size = new System.Drawing.Size(81, 48);
            this.年.TabIndex = 3;
            this.年.Text = "年:";
            // 
            // weekTextBox
            // 
            this.weekTextBox.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weekTextBox.Location = new System.Drawing.Point(238, 45);
            this.weekTextBox.Name = "weekTextBox";
            this.weekTextBox.Size = new System.Drawing.Size(199, 65);
            this.weekTextBox.TabIndex = 4;
            // 
            // monthTextBox
            // 
            this.monthTextBox.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.monthTextBox.Location = new System.Drawing.Point(238, 131);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(199, 65);
            this.monthTextBox.TabIndex = 5;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yearTextBox.Location = new System.Drawing.Point(238, 319);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(199, 65);
            this.yearTextBox.TabIndex = 6;
            // 
            // dayTextBox
            // 
            this.dayTextBox.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dayTextBox.Location = new System.Drawing.Point(238, 229);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(199, 65);
            this.dayTextBox.TabIndex = 7;
            // 
            // date
            // 
            this.date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.date.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.date.Location = new System.Drawing.Point(91, 460);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(604, 65);
            this.date.TabIndex = 8;
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(91, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 56);
            this.button1.TabIndex = 9;
            this.button1.Text = "顯示日期";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clear.Location = new System.Drawing.Point(360, 555);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(146, 56);
            this.clear.TabIndex = 10;
            this.clear.Text = "清除";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exit.Location = new System.Drawing.Point(543, 555);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(152, 56);
            this.exit.TabIndex = 11;
            this.exit.Text = "離開";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 640);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.weekTextBox);
            this.Controls.Add(this.年);
            this.Controls.Add(this.月);
            this.Controls.Add(this.日);
            this.Controls.Add(this.星期);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 星期;
        private System.Windows.Forms.Label 日;
        private System.Windows.Forms.Label 月;
        private System.Windows.Forms.Label 年;
        private System.Windows.Forms.TextBox weekTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
    }
}

