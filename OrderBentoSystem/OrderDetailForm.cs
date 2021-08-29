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

namespace OrderBentoSystem
{
    public partial class OrderDetailForm : Form
    {
        int _orderId;
        OrderBentoSystemEntities _db;
        public OrderDetailForm(int orderId, OrderBentoSystemEntities db)
        {
            InitializeComponent();
            _orderId = orderId;
            _db = db;
        }

        /// <summary>
        /// 先定義LsvOrderDetial(ListView)欄位，再讀取詳細訂單資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderDetailForm_Load(object sender, EventArgs e)
        {
            TxtOrderNo.Text = _orderId.ToString();

            ColumnHeader colName = new ColumnHeader();
            colName.Name = "colName";
            colName.Text = "餐點名稱";
            colName.Width = 183;
            LsvOrderDetial.Columns.Add(colName);

            ColumnHeader colShop = new ColumnHeader();
            colShop.Name = "colShop";
            colShop.Text = "店家";
            colShop.Width = 159;
            LsvOrderDetial.Columns.Add(colShop);

            ColumnHeader colUnitPrice = new ColumnHeader();
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.Text = "單價";
            colUnitPrice.Width = 91;
            LsvOrderDetial.Columns.Add(colUnitPrice);

            ColumnHeader colNum = new ColumnHeader();
            colNum.Name = "colNum";
            colNum.Text = "數量";
            colNum.Width = 84;
            LsvOrderDetial.Columns.Add(colNum);

            ColumnHeader colTotalPrice = new ColumnHeader();
            colTotalPrice.Name = "colTotalPrice";
            colTotalPrice.Text = "小計";
            colTotalPrice.Width = 123;
            LsvOrderDetial.Columns.Add(colTotalPrice);

            ReadOrderDetial();
        }

        /// <summary>
        /// 透過orderId去OrderDetial資料表找尋對應的品項&數量
        /// </summary>
        private void ReadOrderDetial()
        {
            LsvOrderDetial.Items.Clear();

            var order = _db.Order.Find(_orderId);
            var orderDetial = _db.OrderDetial.Where(m => m.OrderId == _orderId);

            if (order.OrderState >= 0 && order.OrderState <= 1)
                BtnCancel.Enabled = true;
            else
                BtnCancel.Enabled = false;

            OrderView view = new OrderView();
            view.orderState = order.OrderState.ToString();

            TxtOrderState.Text = view.orderState;
            TxtOrderDate.Text = order.OrderDate.ToString("d");
            TxtInsertOrderDateTime.Text = order.InsertOrderDateTime.ToString();

            foreach (var item in orderDetial)
            {
                var menu = _db.Menu.Find(item.MenuId);
                var shop = menu.Shop;

                string menuName = menu.ItemName;
                string shopName = shop.shopName;
                int unitPrice = menu.UnitPrice;
                int total = unitPrice * item.Num;

                ListViewItem viewItem = new ListViewItem(menuName);

                viewItem.SubItems.Add(shopName);
                viewItem.SubItems.Add(unitPrice.ToString());
                viewItem.SubItems.Add(item.Num.ToString());
                viewItem.SubItems.Add(total.ToString());

                LsvOrderDetial.Items.Add(viewItem);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("是否取消此訂單?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.No)
                return;

            var order = _db.Order.Find(_orderId);
            order.OrderState = 4;
            _db.SaveChanges();
            this.Close();
        }
    }
}
