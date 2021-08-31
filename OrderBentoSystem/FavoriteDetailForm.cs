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

namespace OrderBentoSystem
{
    public partial class FavoriteDetailForm : Form
    {
        int _favoriteId;
        List<int> fdIds = new List<int>();
        OrderBentoSystemEntities _db;
        public FavoriteDetailForm(int favoriteId, OrderBentoSystemEntities db)
        {
            InitializeComponent();
            _favoriteId = favoriteId;
            _db = db;
        }

        private void FavoriteDetailForm_Load(object sender, EventArgs e)
        {
            ColumnHeader colName = new ColumnHeader();
            colName.Name = "colName";
            colName.Text = "餐點名稱";
            colName.Width = 183;
            LsvFavoriteDetial.Columns.Add(colName);

            ColumnHeader colShop = new ColumnHeader();
            colShop.Name = "colShop";
            colShop.Text = "店家";
            colShop.Width = 159;
            LsvFavoriteDetial.Columns.Add(colShop);

            ColumnHeader colUnitPrice = new ColumnHeader();
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.Text = "單價";
            colUnitPrice.Width = 91;
            LsvFavoriteDetial.Columns.Add(colUnitPrice);

            ColumnHeader colNum = new ColumnHeader();
            colNum.Name = "colNum";
            colNum.Text = "數量";
            colNum.Width = 84;
            LsvFavoriteDetial.Columns.Add(colNum);

            ReadFavoriteDetail();
        }

        private void ReadFavoriteDetail() 
        {
            fdIds.Clear();
            LsvFavoriteDetial.Items.Clear();

            var detial = _db.FavoriteDetial.Where(m => m.FavoriteId == _favoriteId);
            int total = 0;
            foreach (var item in detial)
            {
                var menu = item.Menu;
                var shop = menu.Shop;

                string menuName = menu.ItemName;
                string shopName = shop.shopName;
                int unitPrice = menu.UnitPrice;
                total += unitPrice * item.Num;
                ListViewItem viewItem = new ListViewItem(menuName);

                viewItem.Tag = item.Id;
                viewItem.SubItems.Add(shopName);
                viewItem.SubItems.Add(unitPrice.ToString());
                viewItem.SubItems.Add(item.Num.ToString());

                fdIds.Add(item.Id);
                LsvFavoriteDetial.Items.Add(viewItem);
            }

            LblTotal.Text = total+"元";
        }

        private void BtnRemoveItem_Click(object sender, EventArgs e)
        {
            var selectIndexes = LsvFavoriteDetial.CheckedIndices;

            if (selectIndexes.Count <= 0)
            {
                MessageBox.Show("未勾選任何項目");
                return;
            }

            DialogResult dialog = MessageBox.Show("是否要移除勾選的項目?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.No)
                return;

            foreach (int index in selectIndexes)
            {
                int fdId = fdIds[index];
                var detial = _db.FavoriteDetial.Find(fdId);
                _db.FavoriteDetial.Remove(detial);
            }
            _db.SaveChanges();
            ReadFavoriteDetail();
        }

        private void FavoriteDetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
