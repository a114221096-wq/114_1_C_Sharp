using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String message = "點餐內容: ";
            String drink = "";
            String sandwitch = "";

            if (radioButton1.Checked)
            {
                drink = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                drink = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                drink = radioButton3.Text;
            }
            else
            {
                drink = "未選擇飲料";
            }
            if (radioButton4.Checked)
            {
                sandwitch = radioButton4.Text;
            }
            else if (radioButton5.Checked)
            {
                sandwitch = radioButton5.Text;
            }
            else if (radioButton6.Checked)
            {
                sandwitch = radioButton6.Text;
            }
            else
            {
                sandwitch = "未選擇三明治";
            }
            message = drink + sandwitch;
            MessageBox.Show(message, "您的點餐內容");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
