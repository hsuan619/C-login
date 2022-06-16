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
    public partial class 登入成功 : Form
    {
        public 登入成功()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text += "帳號：" + Program.account + "\r\n";
            textBox1.Text += "密碼：" + Program.password + "\r\n";
            textBox1.Text += "驗證碼：" + Program.code;
        }
        private void Form2_Formclosing(object sender, FormclosingEventArgs e)
        {
            主畫面 f1 = new 主畫面();
            f1.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            主畫面 f1 = new 主畫面();
            f1.Show();
        }
    }
}
