using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            countrylabel.Font = new Font(countrylabel.Font.FontFamily, 24);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            countrylabel.Text = "法國";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            countrylabel.Text = "芬蘭";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            countrylabel.Text = "德國";
        }
    }
}
