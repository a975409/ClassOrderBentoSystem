using OrderBentoSystem.method;
using OrderBentoSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderBentoSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //會員登入(學生的帳號、密碼)
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            TxtId.Focus();
            TxtId.Text = "TvHU36Tes";
            TxtPwd.Text = "L<&Ulm55o";
        }

        private void BtnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Login();
        }

        private void Login() {
            using (OrderBentoSystemEntities db = new OrderBentoSystemEntities())
            {
                LblMsg.Text = "正在驗證帳號密碼...";

                string pwd = PasswordHelper.Encrypt(TxtPwd.Text);
                Console.WriteLine(pwd);
                var result = db.Student.Where(m => m.UserId == TxtId.Text && m.Password == pwd).FirstOrDefault();

                if (result != null)
                {
                    int stuId = result.Id;

                    //MessageBox.Show("登入成功");
                    //TxtId.Clear();
                    //TxtPwd.Clear();
                    TxtId.Focus();

                    if (result.Authority == 2)
                    {
                        SystemMarageForm form = new SystemMarageForm(stuId, this);
                        this.Hide();
                        form.Show();
                    }
                    else
                    {
                        //取得stuId，並傳至MenuForm
                        MainForm menu = new MainForm(stuId, this);
                        this.Hide();
                        menu.Show();
                    }
                    //Console.WriteLine("秀出MenuForm");
                    LblMsg.Text = "請輸入帳號密碼";
                }
                else
                {
                    LblMsg.Text = "登入失敗，請重新輸入帳號密碼";
                    TxtId.Text = "";
                    TxtPwd.Text = "";
                }
            }
        }

        private void LinkCreateUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
        }

        private void LinkResetUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetUserForm form = new ResetUserForm();
            form.ShowDialog();
        }
    }
}
