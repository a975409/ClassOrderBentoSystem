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
    public partial class FavoriteForm : Form
    {
        int _stuId;
        List<int> fids = new List<int>();
        OrderBentoSystemEntities _db;

        public FavoriteForm(int stuId, OrderBentoSystemEntities db)
        {
            InitializeComponent();
            _stuId = stuId;
            _db = db;
        }

        private void FavoriteForm_Load(object sender, EventArgs e)
        {
            ReadFavoriteList();
        }

        private void ReadFavoriteList()
        {
            fids.Clear();
            LstFavorite.Items.Clear();
            var result = _db.Favorite.Where(m => m.stuId == _stuId);

            if (result.Count() <= 0)
            {
                MessageBox.Show("查無我的最愛項目");
                this.Close();
                return;
            }

            foreach (var item in result)
            {
                fids.Add(item.Id);
                LstFavorite.Items.Add(item.Name);
            }
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            int index = LstFavorite.SelectedIndex;
            if (index < 0)
                return;

            int favoriteId = fids[index];
            FavoriteDetailForm form = new FavoriteDetailForm(favoriteId, _db);
            form.ShowDialog();
        }

        private void BtnDelSelect_Click(object sender, EventArgs e)
        {
            int index = LstFavorite.SelectedIndex;
            if (index < 0)
                return;

            DialogResult ResposMsg = MessageBox.Show("是否要刪除選擇的項目?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ResposMsg == DialogResult.No)
                return;

            int favoriteId = fids[index];

            var result = _db.Favorite.Find(favoriteId);
            var Detials = _db.FavoriteDetial.Where(m => m.FavoriteId == result.Id);

            _db.FavoriteDetial.RemoveRange(Detials);
            _db.Favorite.Remove(result);

            _db.SaveChanges();
            ReadFavoriteList();
            MessageBox.Show("移除成功");
        }


        private void BtnInsertShopCar_Click(object sender, EventArgs e)
        {
            int index = LstFavorite.SelectedIndex;

            if (index < 0)
                return;

            DialogResult ResposMsg = MessageBox.Show("是否要加入至購物車?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ResposMsg == DialogResult.No)
                return;

            
            int favoriteId = fids[index];

            var detial = _db.FavoriteDetial.Where(m => m.FavoriteId == favoriteId);


            foreach (var item in detial)
            {
                OrderDetial orderDetial = new OrderDetial
                {
                    Menu = item.Menu,
                    MenuId = item.MenuId,
                    Num = item.Num,
                    Student = item.Favorite.Student,
                    stuId = item.Favorite.stuId,
                    OrderId = null
                };

                _db.OrderDetial.Add(orderDetial);
            }

            _db.SaveChanges();
            MessageBox.Show("新增成功");
        }

        private void FavoriteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
