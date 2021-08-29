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
    public partial class OrderForm : Form
    {
        int _stuId;
        int Page;//目前所在頁數
        const int page_Len = 4;//限制每一頁顯示的資料筆數

        OrderBentoSystemEntities _db;

        public OrderForm(int stuId, OrderBentoSystemEntities db)
        {
            InitializeComponent();
            _stuId = stuId;
            _db = db;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            Page = 1;
            FLPShowOrder.Size = new Size(672, 470);
            FLPShowOrder.Location = new Point(12, 12);
            FLPShowOrder.FlowDirection = FlowDirection.TopDown;
            ShowOrder(ref Page);
        }

        /// <summary>
        /// 依據所在頁數 & page_Len，從Order資料表篩選資料顯示在畫面上
        /// </summary>
        /// <param name="Page"></param>
        private void ShowOrder(ref int Page)
        {
            var order = _db.Order.Where(m => m.stuId == _stuId);

            if (order.Count() <= 0)
            {
                MessageBox.Show("查無訂單");
                this.Close();
                return;
            }

            FLPShowOrder.Controls.Clear();
            var orderPage = order.OrderByDescending(m => m.OrderDate).Skip((Page - 1) * page_Len).Take(page_Len);

            foreach (var item in orderPage)
            {
                int totalPrice = 0;
                var orderdetial = _db.OrderDetial.Where(m => m.OrderId == item.Id);

                foreach (var detial in orderdetial)
                {
                    var menu = _db.Menu.Find(detial.MenuId);
                    totalPrice += menu.UnitPrice * detial.Num;
                }

                OrderView view = new OrderView()
                {
                    orderId = item.Id,
                    orderState = item.OrderState.ToString(),
                    totalprice = totalPrice,
                    orderDate = item.OrderDate,
                    InsertOrderDateTime = item.InsertOrderDateTime,
                    student = item.Student
                };

                InsertOrderToPanel(view);
                UpdatePageLink(order.Count());
            }
        }

        /// <summary>
        /// 將該用戶的所有訂單顯示在畫面上
        /// </summary>
        /// <param name="view"></param>
        private void InsertOrderToPanel(OrderView view)
        {
            GroupBox box = new GroupBox();
            Font font = new Font("微軟正黑體", 14.0f);
            box.Size = new Size(669, 110);

            Label[] titleLabels = {
                new Label{ Text="訂單編號",Location=new Point(5, 18),Size=new Size(98, 38),BackColor=Color.Orange,TextAlign=ContentAlignment.MiddleCenter ,Font=font},
                new Label{ Text="便當送達日期",Location=new Point(109, 18),Size=new Size(135, 38),BackColor=Color.Orange,TextAlign=ContentAlignment.MiddleCenter ,Font=font},
                new Label{ Text="訂單狀態",Location=new Point(250, 18),Size=new Size(135, 38),BackColor=Color.Orange,TextAlign=ContentAlignment.MiddleCenter ,Font=font},
                new Label{ Text="總價",Location=new Point(391, 18),Size=new Size(142, 38),BackColor=Color.Orange,TextAlign=ContentAlignment.MiddleCenter ,Font=font},
                new Label{ Text="功能",Location=new Point(539, 18),Size=new Size(121, 38),BackColor=Color.Orange,TextAlign=ContentAlignment.MiddleCenter,Font=font }
                };

            box.Controls.AddRange(titleLabels);

            Label[] valueLabels = {
                new Label{ Text=view.orderId.ToString(),Location=new Point(5, 56),Size=new Size(98, 38),BackColor=Color.White,TextAlign=ContentAlignment.MiddleCenter,Font=font },
                new Label{ Text=view.orderDate.ToString("d"),Location=new Point(109, 56),Size=new Size(135, 38),BackColor=Color.White,TextAlign=ContentAlignment.MiddleCenter,Font=font },
                new Label{ Text=view.orderState,Location=new Point(250, 56),Size=new Size(135, 38),BackColor=Color.White,TextAlign=ContentAlignment.MiddleCenter ,Font=font},
                new Label{ Text=view.totalprice.ToString(),Location=new Point(391, 56),Size=new Size(142, 38),BackColor=Color.White,TextAlign=ContentAlignment.MiddleCenter ,Font=font}};

            box.Controls.AddRange(valueLabels);

            LinkLabel linkOrderDetial = new LinkLabel();
            linkOrderDetial.Font = new Font("微軟正黑體", 9.0f);
            linkOrderDetial.Text = "詳細資料";
            linkOrderDetial.LinkColor = Color.Cyan;
            linkOrderDetial.Location = new Point(539, 56);
            linkOrderDetial.Size = new Size(121, 23);
            linkOrderDetial.TextAlign = ContentAlignment.MiddleCenter;
            linkOrderDetial.Tag = view.orderId;
            linkOrderDetial.LinkClicked += LinkOrderDetial_LinkClicked;
            box.Controls.Add(linkOrderDetial);

            if (view.orderState == "待確認" || view.orderState == "已確認")
            {
                LinkLabel linkCancal = new LinkLabel();
                linkCancal.Font = new Font("微軟正黑體", 9.0f);
                linkCancal.Text = "取消訂單";
                linkCancal.LinkColor = Color.Cyan;
                linkCancal.Location = new Point(539, 79);
                linkCancal.Size = new Size(121, 23);
                linkCancal.TextAlign = ContentAlignment.MiddleCenter;
                linkCancal.Tag = view.orderId;
                linkCancal.LinkClicked += LinkCancal_LinkClicked;
                box.Controls.Add(linkCancal);
            }

            FLPShowOrder.Controls.Add(box);
        }

        /// <summary>
        /// 取消訂單
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkCancal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult msg = MessageBox.Show("是否要取消此筆訂單??", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.No)
                return;

            Page = 1;
            int orderId = (int)((LinkLabel)sender).Tag;
            var order = _db.Order.Find(orderId);
            if (order.OrderState > 1)
            {
                OrderView View = new OrderView();
                View.orderState = order.OrderState.ToString();
                MessageBox.Show("訂單狀態為\"" + View.orderState + "\"，無法取消", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowOrder(ref Page);
                return;
            }
            order.OrderState = 4;
            _db.SaveChanges();
            ShowOrder(ref Page);
        }

        /// <summary>
        /// 查看訂單詳細資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkOrderDetial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int orderId = (int)((LinkLabel)sender).Tag;
            OrderDetailForm orderDetail = new OrderDetailForm(orderId, _db);
            orderDetail.ShowDialog();
        }

        /// <summary>
        /// 上一頁
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkLblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int count = _db.Order.Where(m => m.stuId == _stuId).Count();

            if (Page > 1)
            {
                Page--;
                ShowOrder(ref Page);
            }
        }


        /// <summary>
        /// 下一頁
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkLblNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int count = _db.Order.Where(m => m.stuId == _stuId).Count();

            if (Page < count / page_Len || (Page == count / page_Len && count % page_Len > 0))
            {
                Page++;
                ShowOrder(ref Page);
            }
        }

        /// <summary>
        /// 更新頁數
        /// </summary>
        /// <param name="count"></param>
        private void UpdatePageLink(int count)
        {
            LinkLblBack.Visible = Page > 1;
            LinkLblNext.Visible = Page < count / page_Len || (Page == count / page_Len && count % page_Len > 0);
        }
    }
}
