namespace _205070011_金世赫
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCZ_Click(object sender, EventArgs e)
        {
            this.Form1_Load(sender, e);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.tboxID.Text = "";
            this.tboxPW.Text = "";
        }


        private void btnQR_Click(object sender, EventArgs e)
        {
            string ID = this.tboxID.Text.Trim();
            string PW = this.tboxPW.Text.Trim();
            int flag = 0;

            //决定输入值对否
            if (ID.ToUpper() == "K")
            {
                flag = 1;//ID输入值正确： FLAG = 1
                if (PW.ToUpper() == "1")
                {
                    flag = 2;//PW输入值正确： flag = 2
                }
            }
            else
            {
                flag = 0; //ID输入值不正确： flag = 0
            }

            
            if (flag == 0)//ID输错时
            {
                MessageBox.Show("用户ID出错！请重新输入");
                this.tboxID.Focus();
            }
            else //flag = 1或2
            {
                if (flag == 1)//flag = 1时
                {
                    MessageBox.Show("用户PW出错！请重新输入");
                    this.tboxPW.Focus();
                }
                else//flag = 2时
                {
                    Main_Form mf = new Main_Form(ID, PW);
                    mf.Show();
                    this.Hide();
                }
            }
            
        }

        private void tboxPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void tboxPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnQR_Click(sender, e);
            }
        }
    }
}