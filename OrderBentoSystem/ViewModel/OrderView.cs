using OrderBentoSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBentoSystem.ViewModel
{
    public class OrderView
    {
        private string _orderState;

        public int orderId { get; set; }
        public DateTime orderDate { get; set; }
        public DateTime InsertOrderDateTime { get; set; }
        public int totalprice { get; set; }
        public Student student { get; set; }
        public string orderState
        {
            get
            {
                return _orderState;
            }
            set
            {
                switch (int.Parse(value))
                {
                    case 0:
                        _orderState = "待確認";
                        break;
                    case 1:
                        _orderState = "已確認";
                        break;
                    case 2:
                        _orderState = "配送中";
                        break;
                    case 3:
                        _orderState = "已送達";
                        break;
                    case 4:
                        _orderState = "訂單已取消";
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
