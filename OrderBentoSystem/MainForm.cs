using OrderBentoSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Menu = OrderBentoSystem.Model.Menu;

namespace OrderBentoSystem
{
    public partial class MainForm : Form
    {
        int _stuId;
        LoginForm _login;
        OrderBentoSystemEntities db = new OrderBentoSystemEntities();

        public MainForm(int stuId, LoginForm login)
        {
            InitializeComponent();
            _stuId = stuId;
            _login = login;
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            //透過stuId搜尋Student資料表內的資料
            var stu = db.Student.Find(_stuId);
            TxtstuName.Text = stu.stuName;
            TxtClass.Text = stu.ClassRoom.className;

            if (stu.Authority == 0)
            {
                BtnShopList.Enabled = false;
                BtnClassOrder.Enabled = false;
            }

            ReadShop();
        }
        
        /// <summary>
        /// 列出所有店家至CboShopItem
        /// </summary>
        private void ReadShop()
        {
            CboShopItem.Items.Clear();
            CboShopItem.SelectedIndex = -1;
            var shopNames = db.Shop.Select(m => m.shopName).ToArray();
            CboShopItem.Items.AddRange(shopNames);
            CboShopItem.SelectedIndex = 0;
        }

        private void CboShopItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadSelectMenu(CboShopItem.SelectedIndex);
        }

        /// <summary>
        /// 依據CboShopItem.SelectedIndex，找出該店家所有的菜單
        /// </summary>
        /// <param name="index"></param>
        private void ReadSelectMenu(int index)
        {
            splitContainer2.Panel2.Controls.Clear();

            //從資料庫找到所選店家
            var selectShop = db.Shop.ToList()[index];

            //根據shopId搜尋Menu資料表內的資料
            var menus = db.Menu.Where(m => m.shopId == selectShop.Id).ToList();

            //將該店家的菜單顯示到畫面上
            //===========================================
            int x = 3, y = 3;

            foreach (var item in menus)
            {
                var box = CreateMenuGroupbox(item);

                if (x >= 789)
                {
                    x = 3;
                    y += 221;
                }

                box.Location = new Point(x, y);
                x += 198;

                splitContainer2.Panel2.Controls.Add(box);
            }
            //===========================================
        }

        /// <summary>
        /// 將單一品項資訊組成GroupBox
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private GroupBox CreateMenuGroupbox(Menu item)
        {
            DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);
            string imgPathDir = Path.Combine(dir.Parent.Parent.FullName, "img");

            //產生GroupBox
            GroupBox group = new GroupBox();
            group.Size = new Size(192, 230);
            group.Text = "";
            group.Tag = item.Id;

            //產生菜單圖片
            if (item.ImageFile != null)
            {
                PictureBox box = new PictureBox();

                //從資料庫載入圖片
                using (MemoryStream memory = new MemoryStream(item.ImageFile))
                {
                    box.Image = Image.FromStream(memory);
                }

                box.SizeMode = PictureBoxSizeMode.Zoom;
                box.Size = new Size(125, 83);
                box.Location = new Point(31, 21);
                group.Controls.Add(box);
            }

            //產生Label顯示菜色名稱
            Label label = new Label();
            label.Text = item.ItemName;
            label.Font = new Font("微軟正黑體", 15.75f, FontStyle.Bold);
            label.Location = new Point(6, 107);
            label.AutoSize = false;
            label.Size = new Size(174, 26);
            label.TextAlign = ContentAlignment.MiddleCenter;
            group.Controls.Add(label);

            //產生Label顯示價格
            Label label2 = new Label();
            label2.Text = item.UnitPrice.ToString();
            label2.Font = new Font("微軟正黑體", 15.75f, FontStyle.Bold);
            label2.ForeColor = Color.DeepPink;
            label2.Location = new Point(6, 137);
            label2.AutoSize = false;
            label2.Size = new Size(174, 26);
            label2.TextAlign = ContentAlignment.MiddleCenter;
            group.Controls.Add(label2);

            //產生NumericUpDown讓使用者輸入數量
            NumericUpDown num = new NumericUpDown();
            num.Name = "count";
            num.Minimum = 1;
            num.Maximum = 10;
            num.Font = new Font("微軟正黑體", 9.0f);
            num.Location = new Point(11, 172);
            num.Size = new Size(59, 23);
            group.Controls.Add(num);

            //產生Button讓使用者將商品加入至購物車
            Button button = new Button();
            button.Text = "加入購物車";
            button.Font = new Font("微軟正黑體", 12.0f);
            button.Location = new Point(76, 169);
            button.Size = new Size(104, 27);
            button.Tag = item.Id;
            button.Click += Add_to_ShopCar_Click;
            group.Controls.Add(button);

            //產生Button讓使用者將商品加入至我的最愛
            Button button2 = new Button();
            button2.Text = "加入至我的最愛";
            button2.Font = new Font("微軟正黑體", 12.0f);
            button2.Location = new Point(11, 196);
            button2.Size = new Size(169, 27);
            button2.Tag = item.Id;
            button2.Click += Add_to_Favorite_Click;
            group.Controls.Add(button2);

            return group;
        }

        /// <summary>
        /// 當使用者按下加入至我的最愛，會將該品項&數量統一紀錄在FavoriteDetial資料表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_to_Favorite_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int menuId = (int)button.Tag;

            foreach (GroupBox box in splitContainer2.Panel2.Controls)
            {
                if ((int)box.Tag == menuId)
                {
                    int num = 0;

                    //尋找NumericUpDown控制項，取得數量
                    foreach (var item in box.Controls)
                    {
                        if (item.GetType().Name == "NumericUpDown")
                        {
                            num = (int)((NumericUpDown)item).Value;
                            break;
                        }
                    }

                    //將單一品項、數量新增至OrderDetial資料表
                    var menu = db.Menu.Find(menuId);

                    FavoriteDetial detial = new FavoriteDetial();
                    detial.MenuId = menuId;
                    detial.Menu = menu;
                    detial.Num = num;

                    SelectFavoriteForm form = new SelectFavoriteForm(db, detial, _stuId);
                    form.ShowDialog();
                    break;
                }
            }
        }

        /// <summary>
        /// 當使用者按下加入購物車，會將該品項&數量統一紀錄在OrderDetial資料表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_to_ShopCar_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int menuId = (int)button.Tag;

            foreach (GroupBox box in splitContainer2.Panel2.Controls)
            {
                if ((int)box.Tag == menuId)
                {
                    int num = 0;

                    //尋找NumericUpDown控制項，取得數量
                    foreach (var item in box.Controls)
                    {
                        if (item.GetType().Name == "NumericUpDown")
                        {
                            num = (int)((NumericUpDown)item).Value;
                            break;
                        }
                    }

                    //將單一品項、數量新增至OrderDetial資料表
                    OrderDetial detial = new OrderDetial();
                    detial.MenuId = menuId;
                    detial.stuId = _stuId;
                    detial.Num = num;

                    db.OrderDetial.Add(detial);
                    db.SaveChanges();
                    MessageBox.Show("已新增至購物車");
                    break;
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ReadShop();
        }

        /// <summary>
        /// 開啟購物車
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShopCar_Click(object sender, EventArgs e)
        {
            ShopCarForm shopCar = new ShopCarForm(_stuId,db);
            shopCar.ShowDialog();
        }

        /// <summary>
        /// 開啟訂單管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOrder_Click(object sender, EventArgs e)
        {
            OrderForm form = new OrderForm(_stuId, db);
            form.ShowDialog();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
            _login.Show();
        }

        private void BtnClassOrder_Click(object sender, EventArgs e)
        {
            var stu = db.Student.Find(_stuId);
            ClassOrderForm form = new ClassOrderForm(stu.classId, db);
            form.ShowDialog();
        }

        private void BtnBookmarks_Click(object sender, EventArgs e)
        {
            FavoriteForm form = new FavoriteForm(_stuId, db);
            form.ShowDialog();
        }

        private void BtnShopList_Click(object sender, EventArgs e)
        {
            ShopMarageForm form = new ShopMarageForm(db);
            form.ShowDialog();
            ReadShop();
        }

        private void BtnShopInfo_Click(object sender, EventArgs e)
        {
            var selectShop = db.Shop.ToList()[CboShopItem.SelectedIndex];
            int shopId = selectShop.Id;
            ShopInfoForm form = new ShopInfoForm(shopId, "查看店家資訊");
            form.ShowDialog();
        }

        private void BtnAccount_Click(object sender, EventArgs e)
        {
            ModifyUserForm form = new ModifyUserForm(_stuId);
            form.ShowDialog();
        }
    }
}
