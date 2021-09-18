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
    public partial class ShopMarageForm : Form
    {
        OrderBentoSystemEntities _db;
        List<int> sids = new List<int>();
        public ShopMarageForm(OrderBentoSystemEntities db)
        {
            InitializeComponent();
            _db = db;
        }

        private void ShopMarageForm_Load(object sender, EventArgs e)
        {
            ReadShopList();
        }

        private void ReadShopList() 
        {
            sids.Clear();
            LstShop.Items.Clear();

            var shops = _db.Shop.ToList();
            sids.AddRange(shops.Select(m => m.Id));
            LstShop.Items.AddRange(shops.Select(m => m.shopName).ToArray());
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            int index = LstShop.SelectedIndex;

            if (index < 0)
                return;

            ShopEditForm shopForm = new ShopEditForm(sids[index], "編輯店家資訊");
            shopForm.ShowDialog();
            ReadShopList();
        }

        private void BtnInsertShop_Click(object sender, EventArgs e)
        {
            ShopEditForm shopForm = new ShopEditForm(-1, "新增店家");
            shopForm.ShowDialog();
            ReadShopList();
        }

        private void BtnDelShop_Click(object sender, EventArgs e)
        {
            int index = LstShop.SelectedIndex;

            if (index < 0)
                return;

            DialogResult dialog = MessageBox.Show("是否要移除選取的店家??","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (dialog == DialogResult.No)
                return;
            
            var shop = _db.Shop.Find(sids[index]);

            _db.Menu.RemoveRange(shop.Menu);
            _db.Shop.Remove(shop);
            _db.SaveChanges();
            MessageBox.Show("移除成功");
            ReadShopList();
        }

        private void ShopMarageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
