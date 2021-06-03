using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Order
    {
        public int order_ID { get; set; }
        public DiningTable Table { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public decimal totalPrice 
        { 
            get
            {
                decimal totalprice = 0;
                foreach (OrderDetail orderDetail in OrderDetails)
                {
                    totalprice += orderDetail.quantity * orderDetail.item.item_Price;
                }
                return totalprice;
            }
        }
        public decimal totalVAT
        { 
            get
            {
                decimal totalvat = 0;
                foreach (OrderDetail orderDetail in OrderDetails)
                {
                    totalvat += (((orderDetail.item.item_Price / 100) * orderDetail.quantity) * orderDetail.item.item_Taxpercentage);
                }
                return totalvat;
            } 
        }
        public PayStatus paystatus { get; set; }
        public OrderStatus orderStatus { get; set; }
    }
}
