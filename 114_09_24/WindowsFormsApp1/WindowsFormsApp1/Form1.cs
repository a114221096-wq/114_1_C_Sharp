using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string week = weekTextBox.Text;
            string month = monthTextBox.Text;
            string day = dayTextBox.Text;
            string year = yearTextBox.Text;

            string output = "中華民國" + year + "年" + month + "月" + day + "日" + ",星期" + week;

            date.Text = output;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            weekTextBox.Text = "";
            monthTextBox.Text = "";
            dayTextBox.Text = "";
            yearTextBox.Text = "";
        }
    }
}
