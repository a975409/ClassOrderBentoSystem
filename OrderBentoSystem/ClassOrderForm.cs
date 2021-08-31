using OrderBentoSystem.Model;
using OrderBentoSystem.ViewModel;
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

namespace OrderBentoSystem
{
    public partial class ClassOrderForm : Form
    {
        int _classId;
        int Page;//目前所在頁數
        const int page_Len = 5;//限制每一頁顯示的資料筆數
        DateTime selectDate;
        List<CheckBox> checkBoxes = new List<CheckBox>();
        OrderBentoSystemEntities _db;

        public ClassOrderForm(int classId, OrderBentoSystemEntities db)
        {
            InitializeComponent();
            _classId = classId;
            _db = db;
        }

        private void ClassOrderForm_Load(object sender, EventArgs e)
        {
            saveOrderDialog.Filter = "All Txt Files| *.txt";
            saveOrderDialog.DefaultExt = "*.txt";
            Page = 1;
            //FLPShowOrder.Size = new Size(718, 470);
            FLPShowOrder.Location = new Point(7, 99);
            FLPShowOrder.FlowDirection = FlowDirection.TopDown;
            GetOrderDateToCbox();
        }

        private void GetOrderDateToCbox()
        {
            CboDate.Items.Clear();
            var dateList = _db.Order.Where(m=>m.Student.classId==_classId).Select(m => m.OrderDate);

            if (dateList.Count() <= 0)
            {
                MessageBox.Show("查無訂單");
                this.Close();
                return;
            }

            var strDateArray = dateList.Distinct().OrderByDescending(m=>m).Select(m => m.ToString()).ToArray();

            CboDate.Items.AddRange(strDateArray);
            CboDate.SelectedIndex = 0;
        }

        private void CboDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(CboDate.SelectedItem.ToString());
            selectDate = date;
            ShowOrder(ref Page);
        }

        /// <summary>
        /// 依據所在頁數 & page_Len，從Order資料表篩選資料顯示在畫面上
        /// </summary>
        /// <param name="Page"></param>
        private void ShowOrder(ref int Page)
        {
            var order = _db.Order.Where(m => m.Student.classId == _classId && m.OrderDate == selectDate);

            if (order.Count() <= 0)
            {
                MessageBox.Show("查無訂單");
                this.Close();
                return;
            }

            FLPShowOrder.Controls.Clear();
            checkBoxes.Clear();
            var orderPage = order.OrderByDescending(m => m.InsertOrderDateTime).Skip((Page - 1) * page_Len).Take(page_Len);

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
            box.Size = new Size(715, 75);

            Label[] titleLabels = {
                new Label{ Text="勾選",Location=new Point(5, 18),Size=new Size(57, 23),BackColor=Color.Orange,TextAlign=ContentAlignment.MiddleCenter ,Font=font},
                new Label{ Text="訂購人",Location=new Point(68, 18),Size=new Size(117, 23),BackColor=Color.Orange,TextAlign=ContentAlignment.MiddleCenter ,Font=font},
                new Label{ Text="總價",Location=new Point(191, 18),Size=new Size(84, 23),BackColor=Color.Orange,TextAlign=ContentAlignment.MiddleCenter ,Font=font},
                new Label{ Text="訂單狀態",Location=new Point(281, 18),Size=new Size(120, 23),BackColor=Color.Orange,TextAlign=ContentAlignment.MiddleCenter ,Font=font},
                new Label{ Text="訂單送出時間",Location=new Point(407, 18),Size=new Size(202, 23),BackColor=Color.Orange,TextAlign=ContentAlignment.MiddleCenter,Font=font },
                new Label{ Text="功能",Location=new Point(615, 18),Size=new Size(92, 23),BackColor=Color.Orange,TextAlign=ContentAlignment.MiddleCenter,Font=font }
                };

            box.Controls.AddRange(titleLabels);

            CheckBox chk = new CheckBox
            {
                Location = new Point(6, 41),
                Size = new Size(56, 28),
                CheckAlign = ContentAlignment.MiddleCenter,
                Tag = view.orderId,
                Enabled = false
            };

            if (view.orderState == "待確認")
            {
                chk.Enabled = true;
            }

            checkBoxes.Add(chk);
            box.Controls.Add(chk);

            Label[] valueLabels = {
                new Label{ Text=view.student.stuName,Location=new Point(68, 41),Size=new Size(117, 28),BackColor=Color.White,TextAlign=ContentAlignment.MiddleCenter ,Font=font},
                new Label{ Text=view.totalprice.ToString(),Location=new Point(191, 41),Size=new Size(84, 28),BackColor=Color.White,TextAlign=ContentAlignment.MiddleCenter ,Font=font},
                new Label{ Text=view.orderState,Location=new Point(281, 41),Size=new Size(120, 28),BackColor=Color.White,TextAlign=ContentAlignment.MiddleCenter ,Font=font},
                new Label{ Text=view.InsertOrderDateTime.ToString("yyyy-MM-dd HH:mm:ss"),Location=new Point(407, 41),Size=new Size(202, 28),BackColor=Color.White,TextAlign=ContentAlignment.MiddleCenter,Font=font }};

            box.Controls.AddRange(valueLabels);

            LinkLabel linkOrderDetial = new LinkLabel();
            linkOrderDetial.Font = new Font("微軟正黑體", 12.0f);
            linkOrderDetial.Text = "詳細資料";
            linkOrderDetial.LinkColor = Color.Cyan;
            linkOrderDetial.Location = new Point(627, 46);
            linkOrderDetial.Size = new Size(73, 20);
            linkOrderDetial.TextAlign = ContentAlignment.MiddleCenter;
            linkOrderDetial.Tag = view.orderId;
            linkOrderDetial.LinkClicked += LinkOrderDetial_LinkClicked;
            box.Controls.Add(linkOrderDetial);

            FLPShowOrder.Controls.Add(box);
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
            int count = _db.Order.Where(m => m.Student.classId == _classId && m.OrderDate == selectDate).Count();

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
            int count = _db.Order.Where(m => m.Student.classId == _classId && m.OrderDate == selectDate).Count();

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


        private void BtnCheck_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("是否確認所有勾選的訂單?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.No)
                return;

            bool update = false;

            foreach (var item in checkBoxes)
            {
                if (item.Checked)
                {
                    update = true;
                    int orderId = (int)item.Tag;
                    var order = _db.Order.Find(orderId);
                    order.OrderState = 1;
                }
            }
            if (update)
            {
                _db.SaveChanges();
                Page = 1;
                ShowOrder(ref Page);
            }
            else
            {
                MessageBox.Show("並未勾選任何訂單!!");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("是否取消所有勾選的訂單?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.No)
                return;

            bool update = false;

            foreach (var item in checkBoxes)
            {
                if (item.Checked)
                {
                    update = true;
                    int orderId = (int)item.Tag;
                    var order = _db.Order.Find(orderId);
                    order.OrderState = 4;
                }
            }

            if (update)
            {
                _db.SaveChanges();
                Page = 1;
                ShowOrder(ref Page);
            }
            else
            {
                MessageBox.Show("並未勾選任何訂單!!");
            }
        }

        /// <summary>
        /// 匯出已確認的訂購單
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBentoOrder_Click(object sender, EventArgs e)
        {
            List<ClassOrder> orderList = new List<ClassOrder>(); //已確認的訂單
            string className = _db.ClassRoom.Find(_classId).className;
            DateTime dateTime = DateTime.Now;
            saveOrderDialog.FileName = className + "的便當訂購單_" + dateTime.ToString("yyyyMMdd_HHmmss") + ".txt";

            DialogResult dialog = saveOrderDialog.ShowDialog();

            if (dialog == DialogResult.Cancel)
                return;

            FileInfo fileInfo = new FileInfo(saveOrderDialog.FileName);

            using (StreamWriter writer = fileInfo.CreateText())
            {
                writer.WriteLine("**********" + className + "的便當訂購單**********");
                writer.WriteLine("便當訂購日期：" + (string)CboDate.SelectedItem);
                writer.WriteLine("訂購時間：" + dateTime.ToString("G"));
                writer.WriteLine("------------------------------------------------");

                var orders = _db.Order.Where(m => m.Student.classId == _classId && m.OrderDate == selectDate);

                foreach (var item in orders)
                {
                    //確認該訂單是否勾選
                    if (item.OrderState==1)
                    {
                        var orderDetials = _db.OrderDetial.Where(m => m.OrderId == item.Id);
                        var detialGroup = orderDetials.GroupBy(m => m.MenuId);

                        //找出該訂單的所有菜色 & 該菜色的數量
                        foreach (var detial in detialGroup)
                        {
                            int count = 0;//該菜色的便當數量
                            
                            foreach (var detialItem in detial)
                                count += detialItem.Num;

                            ClassOrder classOrder = new ClassOrder
                            {
                                menuId = detial.Key,
                                count = count
                            };

                            if (orderList.Count == 0 || !(orderList.Any(m => m.menuId == classOrder.menuId)))
                                orderList.Add(classOrder);
                            else
                            {
                                int index = orderList.FindIndex(m => m.menuId == classOrder.menuId);

                                orderList[index].count += count;
                            }
                        }
                    }
                }

                int totalPrice = 0;
                foreach (var item in orderList)
                {
                    var menu = _db.Menu.Find(item.menuId);
                    string msg = $"{menu.Shop.shopName} {menu.ItemName} {item.count}份 單價：{menu.UnitPrice}";
                    writer.WriteLine(msg);
                    totalPrice += menu.UnitPrice * item.count;
                }

                writer.WriteLine("------------------------------------------------");
                writer.WriteLine($"合計：{totalPrice}元");
                writer.WriteLine("------------------------------------------------");
            }

            MessageBox.Show("匯出成功");
        }

        /// <summary>
        /// 全部勾選
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCheckAll_Click(object sender, EventArgs e)
        {
            foreach (var item in checkBoxes)
            {
                if (item.Enabled == false)
                    continue;

                if (item.Checked == false)
                    item.Checked = true;
            }
        }

        /// <summary>
        /// 全部取消勾選
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancelCheckAll_Click(object sender, EventArgs e)
        {
            foreach (var item in checkBoxes)
            {
                if (item.Enabled == false)
                    continue;

                if (item.Checked == true)
                    item.Checked = false;
            }
        }

        private void ClassOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
