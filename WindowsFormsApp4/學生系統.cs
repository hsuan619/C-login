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
    public partial class 學生系統 : Form
    {
        public 學生系統()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = Program.account;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            主畫面 f1 = new 主畫面();
            f1.Show();
        }
        private void Form3_Formclosing(object sender, FormclosingEventArgs e)
        {
            主畫面 f1 = new 主畫面();
            f1.Show();
        }
    }
}
