using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class OrderDetail
    {
        public int OrderDetails_ID { get; set; }
        public MenuItem Item { get; set; }
        public int Order_ID { get; set; }
        public int Quantity { get; set; }
        public string Comment { get; set; }
        public Employee Employee { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public DateTime Ordered_DateTime { get; set; }
        public DateTime Preparing_DateTime { get; set; }
        public DateTime Finished_DateTime { get; set; }
    }
}
