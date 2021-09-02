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
    public partial class RegisterForm : Form
    {
        List<ClassRoom> classRooms;
        List<Student> students;
        OrderBentoSystemEntities db = new OrderBentoSystemEntities();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            LblUserMsg.Visible = false;
            LblPwdMsg.Visible = false;
            CboClassItem.Items.Clear();
            classRooms = db.ClassRoom.Where(m => m.Id > 0 && m.Student.Count() > 0 && m.Student.Any(a => a.Authority == null)).ToList();
            var classNames = classRooms.Select(m => m.className);

            CboClassItem.Items.AddRange(classNames.ToArray());
            CboClassItem.SelectedIndex = 0;
        }

        private void CboClassItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadStudents();
        }

        private void ReadStudents()
        {
            CboName.Items.Clear();
            var classroom = classRooms[CboClassItem.SelectedIndex];
            students = classroom.Student.Where(m => m.Authority == null).ToList();
            CboName.Items.AddRange(students.Select(m => m.stuName).ToArray());
            CboName.SelectedIndex = 0;
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
            this.Dispose();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            var student = students[CboName.SelectedIndex];

            if (student.Authority != null)
            {
                MessageBox.Show("此學生已註冊過帳號");
                return;
            }

            string userid = TxtId.Text;
            string pwd = TxtPwd.Text;

            bool verify = VerifyUserId(userid) && VerifyPwd(pwd);

            if (verify)
            {
                pwd = PasswordHelper.Encrypt(pwd);
                student.UserId = userid;
                student.Password = pwd;
                student.Authority = 0;
                db.SaveChanges();
                MessageBox.Show("帳號註冊成功");
                this.Close();
            }
        }

        //驗證帳號
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
                TxtId.Text = "";
                return false;
            }
            else if (!(userRgx.IsMatch(userid) && !undefineRgx.IsMatch(userid)))
            {
                LblUserMsg.Visible = true;
                LblUserMsg.Text = "帳號只能包含英文字母大小寫和數字";
                TxtId.Text = "";
                return false;
            }
            else if (db.Student.Any(m => m.UserId == userid))
            {
                LblUserMsg.Visible = true;
                LblUserMsg.Text = "此帳號已有人使用過，請設定其他帳號";
                TxtId.Text = "";
                return false;
            }
            else 
            {
                return true;
            }
        }

        //驗證密碼
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
                TxtPwd.Text = "";
                TxtAgainPwd.Text = "";
                return false;
            }
            else if (!(lowerengRgx.IsMatch(pwd) && capitalengRgx.IsMatch(pwd) && numRgx.IsMatch(pwd) && otherRgx.IsMatch(pwd) && !pwdRgx.IsMatch(pwd)))
            {
                LblPwdMsg.Visible = true;
                LblPwdMsg.Text = "密碼必須包含英文字母大小寫、數字和特殊符號";
                TxtPwd.Text = "";
                TxtAgainPwd.Text = "";
                return false;
            }
            else if (TxtPwd.Text != TxtAgainPwd.Text)
            {
                LblPwdMsg.Visible = true;
                LblPwdMsg.Text = "兩邊輸入的密碼不一致，請重新輸入";
                TxtPwd.Text = "";
                TxtAgainPwd.Text = "";
                return false;
            }
            else
            {
                return true;
            }
        }
        

    }
}
