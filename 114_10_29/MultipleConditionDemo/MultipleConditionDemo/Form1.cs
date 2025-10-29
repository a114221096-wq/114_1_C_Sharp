using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleConditionDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJudge_Click(object sender, EventArgs e)
        {
            try
            {
                int Score = int.Parse(txtScore.Text);
                string grade;
                if (Score >= 60)
                {
                    if (Score >= 70)
                    {
                        if (Score >= 80)
                        {
                            if (Score >= 90)
                            {
                                grade = "A";
                            }
                            else
                            {
                                grade = "B";
                            }
                        }
                        else
                        {
                            grade = "C";
                        }
                    }
                    else
                    {
                        grade = "D";
                    }
                }
                else
                {
                    grade = "F";
                }
                IblGrade.Text = grade;
                MessageBox.Show($"成績等級為:{grade}");

            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入有效整數成績", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IblGrade.Text = "";
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

