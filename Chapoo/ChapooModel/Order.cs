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
        public decimal TotalPrice 
        { 
            get
            {
                decimal totalprice = 0;
                foreach (OrderDetail orderDetail in OrderDetails)
                {
                    totalprice += orderDetail.Quantity * orderDetail.Item.Item_Price;
                }
                return totalprice;
            }
        }
        public decimal TotalVAT
        { 
            get
            {
                decimal totalvat = 0;
                foreach (OrderDetail orderDetail in OrderDetails)
                {
                    totalvat += (((orderDetail.Item.Item_Price / 100) * orderDetail.Quantity) * orderDetail.Item.Item_Taxpercentage);
                }
                return totalvat;
            } 
        }
        public PayStatus Paystatus { get; set; }
    }
}
