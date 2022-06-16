using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class 主畫面 : Form
    {
        public 主畫面()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.account = textBox1.Text;
            Program.password = textBox2.Text;
            Program.code = textBox4.Text;
                if(textBox1.Text == "B10423099" && textBox2.Text == "pwd1" && textBox4.Text == "1111")
                {
                    登入成功 f2 = new 登入成功();
                    f2.Show();
                }
                else if (textBox1.Text == "B10423100" && textBox2.Text == "pwd3" && textBox4.Text == "3333")
                {
                    登入成功 f2 = new 登入成功();
                    f2.Show();
                }
                else
                {
                    textBox3.Text = "!登入失敗!";
                }
        }
    }
}
