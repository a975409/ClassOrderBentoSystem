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
    public partial class SelectFavoriteForm : Form
    {
        OrderBentoSystemEntities _db;
        FavoriteDetial _detial;
        List<int> fids = new List<int>();
        int _stuId;
        
        public SelectFavoriteForm(OrderBentoSystemEntities db, FavoriteDetial detial,int stuId)
        {
            InitializeComponent();
            _db = db;
            _detial = detial;
            _stuId = stuId;
        }
        private void SelectFavoriteForm_Load(object sender, EventArgs e)
        {
            LblMsg.Text = "在左邊選擇好要加入至哪個我的最愛後，按下下方的確定鈕即可；或者在右上方新增一個我的最愛，指定後再按下確定即可";

            var menu = _detial.Menu;

            LblShop.Text = menu.Shop.shopName;
            LblMenu.Text = menu.ItemName;
            ReadFavorite();
        }

        private void ReadFavorite() 
        {
            fids.Clear();
            LstFavorite.Items.Clear();
            var favorite = _db.Favorite.Where(m => m.stuId == _stuId);
            fids.AddRange(favorite.Select(m => m.Id));
            LstFavorite.Items.AddRange(favorite.Select(m => m.Name).ToArray());
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            int index = LstFavorite.SelectedIndex;

            if (index < 0)
                return;

            int fid = fids[index];
            _detial.FavoriteId = fid;
            _detial.Favorite = _db.Favorite.Find(fid);

            _db.FavoriteDetial.Add(_detial);
            _db.SaveChanges();
            MessageBox.Show("已將菜單新增至我的最愛");
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (TxtFavoriteName.Text == "")
                return;

            Favorite favorite = new Favorite();
            favorite.Name = TxtFavoriteName.Text;
            favorite.stuId = _stuId;
            favorite.Student = _db.Student.Find(_stuId);

            _db.Favorite.Add(favorite);
            _db.SaveChanges();
            ReadFavorite();
        }
    }
}
