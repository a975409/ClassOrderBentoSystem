using OrderBentoSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = OrderBentoSystem.Model.Menu;

namespace OrderBentoSystem
{
    public partial class ShopInfoForm : Form
    {
        Shop _shop;
        OrderBentoSystemEntities _db = new OrderBentoSystemEntities();

        public ShopInfoForm(int shopId, string title)
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
        private void ShopInfoForm_Load(object sender, EventArgs e)
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

            ReadShopInfo();
        }

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

        private void ShopInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _db.Dispose();
            this.Dispose();
        }
    }
}
