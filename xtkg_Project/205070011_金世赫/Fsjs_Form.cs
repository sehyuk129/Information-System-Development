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
    public partial class Fsjs_Form : Form
    {
        public Fsjs_Form()
        {
            InitializeComponent();
        }

        private void btnQD_Click(object sender, EventArgs e)
        {
            string pass;

            try
            {
                if (Convert.ToDouble(tboxBL1.Text) + Convert.ToDouble(tboxBL2.Text) + Convert.ToDouble(tboxBL3.Text) > 100)
                {
                    MessageBox.Show("占比不能超过100！");
                }
                else if (Convert.ToDouble(tboxBL1.Text) + Convert.ToDouble(tboxBL2.Text) + Convert.ToDouble(tboxBL3.Text) < 100)
                {
                    MessageBox.Show("占比不能小于100！");
                }
                else
                {
                    double score = Convert.ToDouble(tboxZY.Text) * Convert.ToDouble(tboxBL1.Text) / 100
                        + Convert.ToDouble(tboxBG.Text) * Convert.ToDouble(tboxBL2.Text) / 100
                        + Convert.ToDouble(tboxKS.Text) * Convert.ToDouble(tboxBL3.Text) / 100;
                    if (score >= 60)
                    {
                        pass = "及格";
                    }
                    else
                        pass = "不及格";

                    tboxJG.Text = Convert.ToString(cboxClass.Text) + Convert.ToString(tboxName.Text) + "同学的总分：" + score.ToString() + " (" + pass + ")";
                }
            }
            catch
            {
                MessageBox.Show("请输入所有的值");
            }

                
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Fsjs_Form_Load(object sender, EventArgs e)
        {
            this.tboxName.Text = "";
            this.cboxClass.Text = "";
            this.tboxZY.Text = "";
            this.tboxBG.Text = "";
            this.tboxKS.Text = "";
            this.tboxJG.Text = "";
        }

        private void btnCZ_Click(object sender, EventArgs e)
        {
            this.Fsjs_Form_Load(sender, e);
        }

        private void btnTC_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnQD_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnQD_Click(sender, e);
            }
        }

        private void tboxBL3_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnQD_Click(sender, e);
            }
        }
    }
}
