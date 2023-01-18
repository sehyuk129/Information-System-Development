using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _205070011_金世赫
{
    public partial class Main_Form : Form
    {
        string strUSER;
        string strPWD;

        public Main_Form(string user, string pwd)
        {
            InitializeComponent();
            strUSER = user;
            strPWD = pwd;
        }

        private void 学生登陆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XD_Form xd = new XD_Form();
            xd.Show();
            //this.Hide();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + "——" + "欢迎 " + strUSER + " 进入系统！";
            timer1.Interval = 100;
            timer1.Start();
            label3.Text = "您好" + strUSER + "!";

        }

        private void 推出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void 计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fsjs_Form fs = new Fsjs_Form();
            fs.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("F");
        }

        private void btnTJ_Click(object sender, EventArgs e)
        {
            string plus = tboxXM.Text;
            lboxTodo.Items.Add(plus);
            tboxXM.Text = "";

        }

        private void btnSC_Click(object sender, EventArgs e)
        {
            lboxTodo.Items.Remove(lboxTodo.SelectedItem);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lboxTodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tBoxXM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTJ_Click(sender, e);
            }
        }

        private void 关于系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info_Form If = new Info_Form();
            If.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
