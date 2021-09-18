using OrderBentoSystem.method;
using OrderBentoSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderBentoSystem
{
    public partial class ModifyUserForm : Form
    {
        int _stuId;
        OrderBentoSystemEntities db = new OrderBentoSystemEntities();
        public ModifyUserForm(int stuId)
        {
            InitializeComponent();
            _stuId = stuId;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            var student = db.Student.Find(_stuId);
            
            if (TxtOldId.Text != student.UserId || PasswordHelper.Encrypt(TxtOldPwd.Text) != student.Password)
            {
                MessageBox.Show("原來的帳號或密碼輸入錯誤，不予修改!!");
                return;
            }    

            string userid = TxtNewId.Text;
            string pwd = TxtNewPwd.Text;

            bool verify = VerifyUserId(userid) && VerifyPwd(pwd);

            if (verify)
            {
                pwd = PasswordHelper.Encrypt(pwd);
                Console.WriteLine(pwd);
                student.UserId = userid;
                student.Password = pwd;
                db.SaveChanges();
                MessageBox.Show("帳號更改成功");
                this.Close();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
            this.Dispose();
        }

        /// <summary>
        /// 驗證帳號
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        private bool VerifyUserId(string userid)
        {
            string userformate = "[0-9A-Za-z]+";
            string undefineformate = "[^0-9A-Za-z]+";

            Regex userRgx = new Regex(userformate);
            Regex undefineRgx = new Regex(undefineformate);

            if (userid == "")
            {
                LblUserMsg.Visible = true;
                LblUserMsg.Text = "帳號不可為空，請輸入帳號";
                return false;
            }
            else if (userid.Length < 7)
            {
                LblUserMsg.Visible = true;
                LblUserMsg.Text = "帳號至少要7個字或以上";
                return false;
            }
            else if (!(userRgx.IsMatch(userid) && !undefineRgx.IsMatch(userid)))
            {
                LblUserMsg.Visible = true;
                LblUserMsg.Text = "帳號只能包含英文字母大小寫和數字";
                return false;
            }
            else if (db.Student.Where(m => m.Id != _stuId).Any(m => m.UserId == userid))
            {
                LblUserMsg.Visible = true;
                LblUserMsg.Text = "此帳號已有人使用過，請設定其他帳號";
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 驗證密碼
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        private bool VerifyPwd(string pwd)
        {
            //密碼必須包含至少一個數字 (0-9) 、一個英文字母 (a-z A-Z) 及一個特殊符號 (()[]{}<>+-*/?,.:;"'_\|~`!@#$%^&= 以及不包含空格字元 )
            string lowerengformate = "[a-z]+";
            string capitalengformate = "[A-Z]+";
            string numformate = "[0-9]+";
            string otherformate = "[\\(\\)\\[\\]\\{\\}<>\\+\\-\\*/\\?,\\.\\:;\"\'_\\\\\\|~`!@#\\$%\\^&=]+";
            string formate = "[^a-zA-Z0-9\\(\\)\\[\\]\\{\\}<>\\+\\-\\*/\\?,\\.\\:;\"\'_\\\\\\|~`!@#\\$%\\^&=]";


            Regex lowerengRgx = new Regex(lowerengformate);
            Regex capitalengRgx = new Regex(capitalengformate);
            Regex numRgx = new Regex(numformate);
            Regex otherRgx = new Regex(otherformate);
            Regex pwdRgx = new Regex(formate);

            if (pwd == "")
            {
                LblPwdMsg.Visible = true;
                LblPwdMsg.Text = "密碼不可為空，請輸入密碼";
                return false;
            }
            else if (pwd.Length < 8)
            {
                LblPwdMsg.Visible = true;
                LblPwdMsg.Text = "密碼至少要8個字或以上";
                return false;
            }
            else if (!(lowerengRgx.IsMatch(pwd) && capitalengRgx.IsMatch(pwd) && numRgx.IsMatch(pwd) && otherRgx.IsMatch(pwd) && !pwdRgx.IsMatch(pwd)))
            {
                LblPwdMsg.Visible = true;
                LblPwdMsg.Text = "密碼必須包含英文字母大小寫、數字和特殊符號";
                return false;
            }
            else
            {
                return true;
            }
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            TxtNewId.Text = randerUserId();
            TxtNewPwd.Text = randerPassword();
        }

        /// <summary>
        /// 亂數產生8-10位數的密碼，產生的密碼必須包含至少一個數字 (0-9) 、一個英文字母 (a-z A-Z) 及一個特殊符號 (()[]{}<>+-*/?,.:;"'_\|~`!@#$%^&= 以及不包含空格字元 )
        /// </summary>
        /// <returns></returns>
        private string randerPassword()
        {
            //產生的密碼必須包含至少一個數字 (0-9) 、一個英文字母 (a-z A-Z) 及一個特殊符號 (()[]{}<>+-*/?,.:;"'_\|~`!@#$%^&= 以及不包含空格字元 )
            //=========================================================
            string lowerengformate = "[a-z]+";
            string capitalengformate = "[A-Z]+";
            string numformate = "[0-9]+";
            string otherformate = "[\\(\\)\\[\\]\\{\\}<>\\+\\-\\*/\\?,\\.\\:;\"\'_\\\\\\|~`!@#\\$%\\^&=]+";

            string formate = "[^a-zA-Z0-9\\(\\)\\[\\]\\{\\}<>\\+\\-\\*/\\?,\\.\\:;\"\'_\\\\\\|~`!@#\\$%\\^&=]";

            Regex lowerengRgx = new Regex(lowerengformate);
            Regex capitalengRgx = new Regex(capitalengformate);
            Regex numRgx = new Regex(numformate);
            Regex otherRgx = new Regex(otherformate);
            Regex pwdRgx = new Regex(formate);
            //=========================================================

            //亂數密碼產生的規範
            char[] chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ()[]{}<>+-*/\\?,.:;\"\'_|~`!@#$%^&=".ToCharArray();

            StringBuilder sb = new StringBuilder();
            string YourPassword = "";
            int length = RNG.Next(8, 10);

            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //亂數產生密碼，必須符合正則表示式的規範才行
            do
            {
                sb.Clear();
                for (int i = 0; i < length; i++)
                    sb.Append(chars[RNG.Next(chars.Length - 1)]);

                YourPassword = sb.ToString();
                //Console.WriteLine(YourPassword);

            } while (!(lowerengRgx.IsMatch(YourPassword) && capitalengRgx.IsMatch(YourPassword) && numRgx.IsMatch(YourPassword) && otherRgx.IsMatch(YourPassword) && !pwdRgx.IsMatch(YourPassword)));

            //stopwatch.Stop();
            //Console.WriteLine($"{stopwatch.ElapsedMilliseconds}ms");

            return YourPassword;
        }

        /// <summary>
        /// 亂數產生7-10位數的帳號，產生的帳號只能包含數字 (0-9) 、英文字母 (a-z A-Z)，以及不包含空格和特殊字元
        /// </summary>
        /// <returns></returns>
        private string randerUserId()
        {
            //產生的帳號只能包含數字 (0-9) 、英文字母 (a-z A-Z)，以及不包含空格和特殊字元
            //=========================================================

            string userformate = "[0-9A-Za-z]+";
            string undefineformate = "[^0-9A-Za-z]+";

            Regex userRgx = new Regex(userformate);
            Regex undefineRgx = new Regex(undefineformate);
            //=========================================================

            //亂數帳號產生的規範
            char[] chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            StringBuilder sb = new StringBuilder();
            string YourUserId = "";
            int length = RNG.Next(7, 10);

            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //亂數產生帳號，必須符合正則表示式的規範才行
            do
            {
                sb.Clear();
                for (int i = 0; i < length; i++)
                    sb.Append(chars[RNG.Next(chars.Length - 1)]);

                YourUserId = sb.ToString();
                //Console.WriteLine(YourPassword);

            } while (!(userRgx.IsMatch(YourUserId) && !undefineRgx.IsMatch(YourUserId)));

            //stopwatch.Stop();
            //Console.WriteLine($"{stopwatch.ElapsedMilliseconds}ms");

            return YourUserId;
        }

        private void ModifyUserForm_Load(object sender, EventArgs e)
        {
            var student = db.Student.Find(_stuId);
            TxtClass.Text = student.ClassRoom.className;
            TxtstuName.Text = student.stuName;
        }
    }
}
