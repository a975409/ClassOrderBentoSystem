using OrderBentoSystem.Model;
using OrderBentoSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace OrderBentoSystem
{
    public partial class ShopCarForm : Form
    {
        int _stuId; 
        OrderBentoSystemEntities _db;

        public ShopCarForm(int stuId, OrderBentoSystemEntities db)
        {
            InitializeComponent();
            _stuId = stuId;
            _db = db;
        }

        
        private void ShopCarForm_Load(object sender, EventArgs e)
        {
            //設定可選擇最小日期為今天日期
            DtpOrderDate.MinDate = DateTime.Today;

            //設定可選擇最的最大日期為今天日期的7天後
            DtpOrderDate.MaxDate = DateTime.Today.AddDays(7);

            //定義要顯示在LsvShopCar(ListView)的欄位
            //==========================================
            ColumnHeader colName = new ColumnHeader();
            colName.Name = "colName";
            colName.Text = "餐點名稱";
            colName.Width = 183;
            LsvShopCar.Columns.Add(colName);

            ColumnHeader colShop = new ColumnHeader();
            colShop.Name = "colShop";
            colShop.Text = "店家";
            colShop.Width = 159;
            LsvShopCar.Columns.Add(colShop);

            ColumnHeader colUnitPrice = new ColumnHeader();
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.Text = "單價";
            colUnitPrice.Width = 91;
            LsvShopCar.Columns.Add(colUnitPrice);

            ColumnHeader colNum = new ColumnHeader();
            colNum.Name = "colNum";
            colNum.Text = "數量";
            colNum.Width = 84;
            LsvShopCar.Columns.Add(colNum);

            ColumnHeader colTotalPrice = new ColumnHeader();
            colTotalPrice.Name = "colTotalPrice";
            colTotalPrice.Text = "小計";
            colTotalPrice.Width = 123;
            LsvShopCar.Columns.Add(colTotalPrice);
            //==========================================

            //讀取購物車資料
            ReadShopCar();
        }

        /// <summary>
        /// 透過stuId&OrderId==null，從OrderDetial資料表列出購物車項目
        /// </summary>
        private void ReadShopCar()
        {
            LsvShopCar.Items.Clear();

            var shopCar = _db.OrderDetial.Where(m => m.stuId == _stuId & m.OrderId == null);

            foreach (var item in shopCar)
            {
                var menu = item.Menu;
                var shop = menu.Shop;

                string menuName = menu.ItemName;
                string shopName = shop.shopName;
                int unitPrice = menu.UnitPrice;
                int total = unitPrice * item.Num;

                ListViewItem viewItem = new ListViewItem(menuName);

                viewItem.Tag = item.Id;
                viewItem.SubItems.Add(shopName);
                viewItem.SubItems.Add(unitPrice.ToString());
                viewItem.SubItems.Add(item.Num.ToString());
                viewItem.SubItems.Add(total.ToString());

                LsvShopCar.Items.Add(viewItem);
            }
        }

        /// <summary>
        /// 清空購物車
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            if (LsvShopCar.Items.Count == 0)
                return;

            DialogResult ResposMsg = MessageBox.Show("是否要清空購物車?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ResposMsg == DialogResult.No)
                return;

            foreach (ListViewItem item in LsvShopCar.Items)
            {
                var result = _db.OrderDetial.Find((int)item.Tag);
                _db.OrderDetial.Remove(result);
            }

            _db.SaveChanges();
            ReadShopCar();
        }

        /// <summary>
        /// 移除指定品項、數量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelSelect_Click(object sender, EventArgs e)
        {
            if (LsvShopCar.CheckedItems.Count == 0)
                return;

            DialogResult ResposMsg = MessageBox.Show("是否要刪除已勾選的項目?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ResposMsg == DialogResult.No)
                return;

            foreach (ListViewItem item in LsvShopCar.CheckedItems)
            {
                var result = _db.OrderDetial.Find((int)item.Tag);
                _db.OrderDetial.Remove(result);
            }

            _db.SaveChanges();
            ReadShopCar();
        }

        /// <summary>
        /// 送出訂單新增至Order資料表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSend_Click(object sender, EventArgs e)
        {
            var shopCar = _db.OrderDetial.Where(m => m.stuId == _stuId & m.OrderId == null);

            if (shopCar == null || shopCar.Count() == 0)
                return;

            DialogResult msg = MessageBox.Show("是否要送出此筆訂單?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.No)
                return;

            //將訂單資料新增至Order資料表
            Order order = new Order();
            order.OrderDate = DtpOrderDate.Value;
            order.InsertOrderDateTime = DateTime.Now;
            order.OrderState = 0; //待確認
            order.stuId = _stuId;

            _db.Order.Add(order);
            _db.SaveChanges();

            //取得資料庫自動編號的Id，覆寫至OrderDetial資料表
            int orderId = order.Id;
            
            foreach (var item in shopCar)
                item.OrderId = orderId;

            _db.SaveChanges();
            this.Close();
        }
    }
}
