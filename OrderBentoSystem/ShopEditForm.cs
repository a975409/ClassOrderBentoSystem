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
using System.Data.Entity;
using Menu = OrderBentoSystem.Model.Menu;

namespace OrderBentoSystem
{
    public partial class ShopEditForm : Form
    {
        Shop _shop;
        Menu selectMenu;
        OrderBentoSystemEntities _db = new OrderBentoSystemEntities();

        public ShopEditForm(int shopId,string title)
        {
            InitializeComponent();
            _shop = _db.Shop.Find(shopId);
            this.Text = title;
        }

        /// <summary>
        /// 控制項初始設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShopForm_Load(object sender, EventArgs e)
        {
            openFileDialog.Filter = "All Image Files| *.bmp;*.ico;*.gif;*.jpeg;*.jpg;*.png;*.tif;*.tiff|" +
                "Windows Bitmap(*.bmp)|*.bmp|" +
                "Windows Icon(*.ico)|*.ico|" +
                "Graphics Interchange Format (*.gif)|(*.gif)|" +
                "JPEG File Interchange Format (*.jpg)|*.jpg;*.jpeg|" +
                "Portable Network Graphics (*.png)|*.png|" +
                "Tag Image File Format (*.tif)|*.tif;*.tiff";

            NudUnitPrice.Minimum = 0;
            NudUnitPrice.Maximum = int.MaxValue;

            LsvMenu.View = View.Details;
            ColumnHeader nameheader = new ColumnHeader();
            nameheader.Text = "菜色";
            nameheader.Width = 249;
            LsvMenu.Columns.Add(nameheader);

            ColumnHeader unitheader = new ColumnHeader();
            unitheader.Text = "單價";
            unitheader.Width = 84;
            LsvMenu.Columns.Add(unitheader);

            FocusMenu(false);

            if (_shop == null)
                InsertShopInfo();
            else
                ReadShopInfo();
        }

        /// <summary>
        /// 儲存變更至資料庫
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (verifyShopEntity())
            {
                _db.SaveChanges();

                //當店家新增成功，則開放新增/修改/移除菜色的功能
                if (_db.Entry(_shop).State == EntityState.Unchanged)
                {
                    BtnInsert.Enabled = true;
                    BtnDelete.Enabled = true;
                    BtnEdit.Enabled = true;
                }

                MessageBox.Show("儲存成功");
            }
            else
            {
                MessageBox.Show("請完整輸入店家資料");
                if (_db.Entry(_shop).State != EntityState.Added)
                    _db.Entry(_shop).Reload();
            }

            FocusMenu(false);
            ReadShopInfo();
        }


        /// <summary>
        /// 拋棄所有變更，並重新讀取所有實體的資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            //如果該店家實體是從資料庫取得，則拋棄修改
            if (_db.Entry(_shop).State != EntityState.Added)
                _db.Entry(_shop).Reload();

            FocusMenu(false);
            ResetMenuList();
            ReadShopInfo();
        }

        /// <summary>
        /// 表單關閉，會檢查是否有尚未儲存的變更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShopForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Focus();

            //取得目前追蹤的實體，指的是 _shop
            EntityState shopState = _db.Entry(_shop).State;

            //取得目前追蹤的實體，指的是 _shop.Menu
            var menuEntries = _db.ChangeTracker.Entries<Menu>();

            //判斷變更的_shop 或 _shop.Menu是否已更新到資料庫內
            bool change = shopState != EntityState.Unchanged || menuEntries.Where(m => m.State != EntityState.Unchanged).Count() > 0;

            if (change)
            {
                DialogResult dialog = MessageBox.Show("發現有變更尚未儲存，是否要離開??", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }

            _db.Dispose();
            this.Dispose();
        }

        /// <summary>
        /// 將在LsvMenu選到的項目顯示在新增/編輯菜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LsvMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //此迴圈只會跑一次(因為該控制項設定為單選)，當使用者改變選項時，新增/編輯菜色裡面就會顯示該菜色的詳細資料
            foreach (ListViewItem item in LsvMenu.SelectedItems)
            {
                int menuId = (int)item.Tag;
                var _menu = _shop.Menu.Where(m => m.Id == menuId).FirstOrDefault();
                selectMenu = _menu;

                TxtMenuName.Text = _menu.ItemName;
                NudUnitPrice.Value = _menu.UnitPrice;

                if (_menu.ImageFile != null)
                {
                    using (MemoryStream imgStream = new MemoryStream(_menu.ImageFile))
                    {
                        PicMenu.Image = Image.FromStream(imgStream);
                    }
                }
                else
                    PicMenu.Image = null;
            }
        }

        //=======================其他自定義方法======================

        /// <summary>
        /// 新增店家
        /// </summary>
        private void InsertShopInfo()
        {
            _shop = new Shop();

            //寫法等同於_db.Shop.Add(_shop)
            _db.Entry(_shop).State = EntityState.Added;

            ////因為店家尚未新增，所以關閉新增/修改/移除菜色的功能
            BtnInsert.Enabled = false;
            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
        }

        /// <summary>
        /// 指定使用者是否進行新增/編輯/移除菜色等相關功能
        /// </summary>
        /// <param name="enabled">指定使用者是否進行新增/編輯/移除菜色等相關功能</param>
        private void FocusMenu(bool enabled)
        {
            TxtMenuName.Enabled = enabled;
            NudUnitPrice.Enabled = enabled;
            BtnUpload.Enabled = enabled;
            BtnCancel.Enabled = enabled;
            BtnOK.Enabled = enabled;
            LsvMenu.Enabled = !enabled;
            BtnDelete.Enabled = !enabled;
            BtnInsert.Enabled = !enabled;
            BtnEdit.Enabled = !enabled;
            BtnSave.Enabled = !enabled;
            BtnReset.Enabled = !enabled;

            if (enabled)
            {
                TxtMenuName.Leave += TxtMenuName_Leave;
                TxtMenuName.TextChanged += TxtMenuName_TextChanged;
                NudUnitPrice.ValueChanged += NudUnitPrice_ValueChanged;
            }
            else
            {
                TxtMenuName.Leave -= TxtMenuName_Leave;
                TxtMenuName.TextChanged -= TxtMenuName_TextChanged;
                NudUnitPrice.ValueChanged -= NudUnitPrice_ValueChanged;
                TxtMenuName.Text = "";
                NudUnitPrice.Value = 0;
                PicMenu.Image = null;
                selectMenu = null;
                this.Focus();
            }
        }

        /// <summary>
        /// 驗證_shop的欄位是否為空值
        /// </summary>
        /// <returns>_shop驗證結果是否OK</returns>
        private bool verifyShopEntity()
        {
            return !(_shop.Phone == null || _shop.R_Address == null || _shop.shopName == null || _shop.Phone == "" || _shop.R_Address == "" || _shop.shopName == "");
        }

        
        //=======================重新載入相關方法======================
        /// <summary>
        /// 將該店家資料庫的菜單資料，秀在LsvMenu
        /// </summary>
        private void ReadShopInfo()
        {
            TxtShopName.Text = _shop.shopName;
            TxtPhone.Text = _shop.Phone;
            TxtAddress.Text = _shop.R_Address;

            LsvMenu.Items.Clear();

            var menu = _shop.Menu;

            if (menu == null || menu.Count() <= 0)
                return;

            foreach (var item in menu)
            {
                if (_db.Entry(item).State == EntityState.Detached)
                    continue;

                ListViewItem viewItem = new ListViewItem(item.ItemName);

                //menuId
                viewItem.Tag = item.Id;

                //單價
                viewItem.SubItems.Add(item.UnitPrice.ToString());
                LsvMenu.Items.Add(viewItem);
            }
        }

        /// <summary>
        /// 重新讀取該店家的菜單實體的資料
        /// </summary>
        private void ResetMenuList()
        {
            //取得指定Menu類別的所有實體
            var menuEntries = _db.ChangeTracker.Entries<Menu>();

            foreach (var item in menuEntries)
            {
                if (item.State == EntityState.Deleted || item.State == EntityState.Modified)
                    item.Reload();
                else if (item.State == EntityState.Added)
                    item.State = EntityState.Detached;
                else { }
            }
        }

        //=======================店家資訊相關控制項======================

        private void TxtShopName_TextChanged(object sender, EventArgs e)
        {
            _shop.shopName = TxtShopName.Text;
        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {
            _shop.Phone = TxtPhone.Text;
        }

        private void TxtAddress_TextChanged(object sender, EventArgs e)
        {
            _shop.R_Address = TxtAddress.Text;
        }

        //=======================新增/編輯菜色等相關控制項======================

        /// <summary>
        /// 新增菜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            TxtMenuName.Text = "";
            NudUnitPrice.Value = 0;
            PicMenu.Image = null;
            FocusMenu(true);

            TxtMenuName.Focus();

            //因為是新增菜色，所以要建立一個Menu物件
            selectMenu = new Menu();
            selectMenu.shopId = _shop.Id;
        }

        /// <summary>
        /// 移除所選菜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (selectMenu == null)
                return;

            DialogResult dialog = MessageBox.Show("是否要移除所選菜色?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.No)
                return;

            if (_db.Entry(selectMenu).State == EntityState.Added)
            {
                //EntityState.Detached代表該物件是另外新增時，因為未與資料庫關聯，所以才會是此狀態
                _db.Entry(selectMenu).State = EntityState.Detached;
            }
            else
            {
                //將所選的菜色標記為刪除，寫法等同於 _db.Menu.Remove(menu)
                _db.Entry(selectMenu).State = EntityState.Deleted;
            }

            FocusMenu(false);
            ReadShopInfo();
        }

        /// <summary>
        /// 編輯所選菜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (selectMenu == null)
                return;

            FocusMenu(true);
        }

        /// <summary>
        /// 上傳菜色圖片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpload_Click(object sender, EventArgs e)
        {
            DialogResult dialog = openFileDialog.ShowDialog();

            if (dialog == DialogResult.Cancel)
                return;

            if (openFileDialog.SafeFileName.Length > 50)
            {
                MessageBox.Show("檔名+副檔名長度不符資料庫規範，請重新命名");
                return;
            }
            //圖片來源端的完整路徑
            string sourcePath = openFileDialog.FileName;

            FileInfo fileInfo = new FileInfo(sourcePath);

            using (FileStream imgStream = fileInfo.OpenRead())
            {
                selectMenu.ImageFile = new byte[(int)imgStream.Length];

                imgStream.Read(selectMenu.ImageFile, 0, selectMenu.ImageFile.Length);
                PicMenu.Image = Image.FromStream(imgStream);
            }
        }

        /// <summary>
        /// 確定執行新增/編輯/移除菜色等相關功能的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOK_Click(object sender, EventArgs e)
        {
            //判斷菜色名稱是否為空值
            if (TxtMenuName.Text == "")
            {
                TxtMenuName.Focus();
                return;
            }

            //判斷selectMenu是否為 新建立的一個 Menu物件，是的話就代表使用者正在執行新增物件的功能
            //EntityState.Detached代表該物件是另外新增時，因為未與資料庫關聯，所以才會是此狀態
            if (_db.Entry(selectMenu).State == EntityState.Detached)
            {
                //標記該物件為新增，語法等同於_db.Menu.Add(selectMenu)
                _db.Entry(selectMenu).State = EntityState.Added;
            }

            FocusMenu(false);
            ReadShopInfo();
        }

        /// <summary>
        /// 取消新增/編輯/移除菜色等相關功能的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (selectMenu != null)
            {
                if (_db.Entry(selectMenu).State == EntityState.Detached)
                    selectMenu = null;
                else if (_db.Entry(selectMenu).State == EntityState.Modified)
                    _db.Entry(selectMenu).Reload();
                else { }
            }

            FocusMenu(false);
            ReadShopInfo();
        }

        private void TxtMenuName_TextChanged(object sender, EventArgs e)
        {
            selectMenu.ItemName = TxtMenuName.Text;
        }

        private void TxtMenuName_Leave(object sender, EventArgs e)
        {
            if (TxtMenuName.Text == "")
                TxtMenuName.Focus();
        }

        private void NudUnitPrice_ValueChanged(object sender, EventArgs e)
        {
            selectMenu.UnitPrice = (int)NudUnitPrice.Value;
        }

    }
}