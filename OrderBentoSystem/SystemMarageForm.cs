using OrderBentoSystem.method;
using OrderBentoSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderBentoSystem
{
    public partial class SystemMarageForm : Form
    {
        int _stuId;//自己的stuId
        LoginForm _login;
        OrderBentoSystemEntities db = new OrderBentoSystemEntities();
        List<ClassRoom> classRooms;//所有班級
        List<Student> students;//該班級所有學生
        ClassRoom selectclass;//選擇的班級
        Student selectStu;//選擇的學生
        public SystemMarageForm(int stuId, LoginForm login)
        {
            InitializeComponent();
            _stuId = stuId;
            _login = login;
        }

        private void SystemMarageForm_Load(object sender, EventArgs e)
        {
            FocueClassGroup(false);
            FocueStudentGroup(false);
            ReadClassRooms();
        }

        private void ReadClassRooms()
        {
            classRooms?.Clear();
            CboClassRooms.Items.Clear();

            classRooms = db.ClassRoom.Where(m => m.Id > 0).ToList();

            if (classRooms == null)
                return;

            var classNames = classRooms.Select(m => m.className).ToArray();
            CboClassRooms.Items.AddRange(classNames);
            CboClassRooms.SelectedIndex = 0;
        }

        private void CboClassRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectclass = classRooms[CboClassRooms.SelectedIndex];
            TxtClassName.Text = selectclass.className;
            ReadStudents();
        }

        private void ReadStudents()
        {
            students?.Clear();
            LstStudent.Items.Clear();
            var classroom = classRooms[CboClassRooms.SelectedIndex];

            if (classroom.Student.Count() == 0)
                return;

            students = classroom.Student.ToList();
            var stuNames = students.Select(m => m.stuName).ToArray();
            LstStudent.Items.AddRange(stuNames);
            LstStudent.SelectedIndex = 0;
        }

        //==============================class控制項事件&方法=======================================

        /// <summary>
        /// 當使用者在執行新增/編輯/移除班級的功能，做一些對於其他控制項的初始化
        /// </summary>
        /// <param name="enable">true就代表使用者在執行新增/編輯/移除班級的功能</param>
        private void FocueClassGroup(bool enable)
        {
            splitContainer1.Panel2.Enabled = !enable;
            BtnClassDelete.Enabled = !enable;
            BtnClassEdit.Enabled = !enable;
            BtnClassInsert.Enabled = !enable;
            CboClassRooms.Enabled = !enable;
            ClassGroup.Enabled = enable;

            if (enable)
            {
                TxtClassName.TextChanged += TxtClassName_TextChanged;
            }
            else
            {
                TxtClassName.TextChanged -= TxtClassName_TextChanged;
                TxtClassName.Text = "";
                selectclass = null;
            }
        }

        private void TxtClassName_TextChanged(object sender, EventArgs e)
        {
            selectclass.className = TxtClassName.Text;
        }

        /// <summary>
        /// 新增班級
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClassInsert_Click(object sender, EventArgs e)
        {
            FocueClassGroup(true);
            selectclass = new ClassRoom();
            db.ClassRoom.Add(selectclass);
            TxtClassName.Text = "";
        }

        /// <summary>
        /// 編輯班級
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClassEdit_Click(object sender, EventArgs e)
        {
            TxtClassName.Text = selectclass.className;
            FocueClassGroup(true);
        }

        /// <summary>
        /// 移除班級
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClassDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("是否要移除該班級?\n此操作會讓該班級所有學生的相關資料一併移除", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.No)
                return;

            selectclass = classRooms[CboClassRooms.SelectedIndex];

            foreach (var item in selectclass.Student)
                DeleteStudentInfo(item.Id);

            db.Student.RemoveRange(selectclass.Student);
            db.ClassRoom.Remove(selectclass);
            db.SaveChanges();
            ReadClassRooms();
        }


        /// <summary>
        /// 確認班級修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClassOK_Click(object sender, EventArgs e)
        {
            if (TxtClassName.Text == "")
            {
                TxtClassName.Focus();
                return;
            }

            DialogResult dialog = MessageBox.Show("是否要儲存此變更?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.No)
                return;

            db.SaveChanges();
            FocueClassGroup(false);
            FocueStudentGroup(false);
            ReadClassRooms();
        }

        /// <summary>
        /// 取消班級修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClassCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("是否要取消此變更?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.No)
                return;

            if (db.Entry(selectclass).State == EntityState.Added)
                db.Entry(selectclass).State = EntityState.Detached;
            else if (db.Entry(selectclass).State == EntityState.Modified)
                db.Entry(selectclass).State = EntityState.Unchanged;
            else { }

            FocueClassGroup(false);
        }

        //======================================Student控制項事件&方法=============================================

        private void TxtPwd_TextChanged(object sender, EventArgs e)
        {
            if (TxtPwd.Text != "" && TxtPwd.Text.Length != 64)
                selectStu.Password = TxtPwd.Text;
        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {
            if (TxtId.Text != "")
                selectStu.UserId = TxtId.Text;
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            selectStu.stuName = TxtName.Text;
        }

        private void LstStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectStu = students[LstStudent.SelectedIndex];
            TxtName.Text = selectStu.stuName;
            TxtId.Text = selectStu.UserId;
            TxtPwd.Text = selectStu.Password;
        }

        /// <summary>
        /// 指派該學生為值日生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOnDuty_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("確定是否指派為值日生?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.No)
                return;

            selectStu.Authority = 1;
        }

        /// <summary>
        /// 取消指派該學生為值日生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancelDuty_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("確定是否取消指派為值日生?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.No)
                return;

            selectStu.Authority = 0;
        }

        /// <summary>
        /// 新增學生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStuInsert_Click(object sender, EventArgs e)
        {
            FocueStudentGroup(true);
            selectStu = new Student();
            selectStu.classId = classRooms[CboClassRooms.SelectedIndex].Id;
            TxtName.Text = "";
            TxtId.Text = "";
            TxtPwd.Text = "";
            db.Student.Add(selectStu);
        }

        /// <summary>
        /// 編輯學生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStuEdit_Click(object sender, EventArgs e)
        {
            TxtName.Text = selectStu.stuName;
            TxtId.Text = selectStu.UserId;
            TxtPwd.Text = selectStu.Password;
            FocueStudentGroup(true);
        }

        /// <summary>
        /// 移除學生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStuDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("是否要移除該學生?此操作會讓該學生的相關資料一併移除", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.No)
                return;

            int stuId = selectStu.Id;
            DeleteStudentInfo(stuId);
            var student = db.Student.Find(stuId);
            db.Student.Remove(student);
            db.SaveChanges();
            ReadClassRooms();
        }


        /// <summary>
        /// 儲存學生修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStuOK_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "")
            {
                TxtName.Focus();
                return;
            }

            DialogResult dialog = MessageBox.Show("是否要儲存此變更?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.No)
                return;

            if (TxtPwd.Text != "" && TxtPwd.Text.Length != 64)
                selectStu.Password = PasswordHelper.Encrypt(TxtPwd.Text);

            db.SaveChanges();
            FocueStudentGroup(false);
            ReadClassRooms();
        }


        /// <summary>
        /// 取消學生修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStuClose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("是否要取消此變更?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.No)
                return;

            if (db.Entry(selectStu).State == EntityState.Added)
                db.Entry(selectStu).State = EntityState.Detached;
            else if (db.Entry(selectStu).State == EntityState.Modified)
                db.Entry(selectStu).State = EntityState.Unchanged;
            else { }

            FocueStudentGroup(false);
        }

        /// <summary>
        /// 隨機產生一組帳號密碼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 刪除有關該學生的所有相關資料
        /// </summary>
        /// <param name="stuId"></param>
        private void DeleteStudentInfo(int stuId)
        {
            //移除該學生的詳細訂單資料
            var orderdetials = db.OrderDetial.Where(m => m.stuId == stuId);
            db.OrderDetial.RemoveRange(orderdetials);

            //移除該學生的訂單資料
            var orders = db.Order.Where(m => m.stuId == stuId);
            db.Order.RemoveRange(orders);

            var favorites = db.Favorite.Where(m => m.stuId == stuId);

            //移除該學生我的最愛的詳細資料
            foreach (var item in favorites)
                db.FavoriteDetial.RemoveRange(item.FavoriteDetial);

            //移除該學生的我的最愛
            db.Favorite.RemoveRange(favorites);

            //var student = db.Student.Find(stuId);
            //db.Student.Remove(student);
        }

        /// <summary>
        /// 當使用者在執行新增/編輯/移除學生的功能，做一些對於其他控制項的初始化
        /// </summary>
        /// <param name="enable">true就代表使用者在執行新增/編輯/移除學生的功能</param>
        private void FocueStudentGroup(bool enable)
        {
            splitContainer1.Panel1.Enabled = !enable;
            LstStudent.Enabled = !enable;
            BtnStuDelete.Enabled = !enable;
            BtnStuEdit.Enabled = !enable;
            BtnStuInsert.Enabled = !enable;
            StudentGroup.Enabled = enable;

            if (enable)
            {
                TxtName.TextChanged += TxtName_TextChanged;
                TxtId.TextChanged += TxtId_TextChanged;
                TxtPwd.TextChanged += TxtPwd_TextChanged;
            }
            else
            {
                TxtName.TextChanged -= TxtName_TextChanged;
                TxtId.TextChanged -= TxtId_TextChanged;
                TxtPwd.TextChanged -= TxtPwd_TextChanged;

                TxtName.Text = "";
                TxtId.Text = "";
                TxtPwd.Text = "";

                selectStu = null;
            }
        }


        //===================================其他控制項事件&方法==================================


        private void BtnShopList_Click(object sender, EventArgs e)
        {
            ShopMarageForm form = new ShopMarageForm(db);
            form.ShowDialog();
        }

        private void BtnClassOrder_Click(object sender, EventArgs e)
        {
            int classid = classRooms[CboClassRooms.SelectedIndex].Id;
            ClassOrderForm form = new ClassOrderForm(classid, db);
            form.ShowDialog();
        }

        private void BtnAccount_Click(object sender, EventArgs e)
        {
            ModifyUserForm form = new ModifyUserForm(_stuId);
            form.ShowDialog();
        }

        private void SystemMarageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
            _login.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
