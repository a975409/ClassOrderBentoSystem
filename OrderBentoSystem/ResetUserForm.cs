using OrderBentoSystem.method;
using OrderBentoSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderBentoSystem
{
    public partial class ResetUserForm : Form
    {
        OrderBentoSystemEntities db = new OrderBentoSystemEntities();
        List<ClassRoom> classRooms;//存放有註冊帳號學生的班級
        List<Student> students;//班級內有註冊帳號的學生
        public ResetUserForm()
        {
            InitializeComponent();
        }

        private void ResetUserForm_Load(object sender, EventArgs e)
        {
            CboClassItem.Items.Clear();

            classRooms = db.ClassRoom.Where(m => m.Id > 0 && m.Student.Count() > 0 && m.Student.Any(a => a.Authority != null)).ToList();


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
            students?.Clear();
            var classroom = classRooms[CboClassItem.SelectedIndex];
            students = classroom.Student.Where(m => m.Authority != null).ToList();
            var stuNames = students.Select(m => m.stuName).ToArray();
            CboName.Items.AddRange(stuNames);
            CboName.SelectedIndex = 0;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (TxtId.Text == "" || TxtPwd.Text == "")
            {
                MessageBox.Show("請隨機產生一組帳號密碼");
                return;
            }

            DialogResult dialog = MessageBox.Show("確定要重設帳號密碼??", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.No)
                return;

            //var classroom = classRooms[CboClassItem.SelectedIndex];
            var student = students[CboName.SelectedIndex];

            student.UserId = TxtId.Text;
            string pwd = TxtPwd.Text;
            pwd = PasswordHelper.Encrypt(pwd);
            student.Password = pwd;

            db.SaveChanges();
            this.Close();
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            TxtId.Text = randerUserId();
            TxtPwd.Text = randerPassword();
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

            } while (!(lowerengRgx.IsMatch(YourPassword) && capitalengRgx.IsMatch(YourPassword)&& numRgx.IsMatch(YourPassword) && otherRgx.IsMatch(YourPassword) && !pwdRgx.IsMatch(YourPassword)));

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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
            this.Dispose();
        }
    }
}
