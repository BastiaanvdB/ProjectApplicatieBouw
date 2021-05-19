using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class BillDetail
    {
        public int order_ID { get; set; }
        public string menuGroup { get; set; }
        public int menuItem_ID { get; set; }
        public string menuItem_Name { get; set; }
        public int quantity { get; set; }
        public decimal item_price { get; set; }
        public decimal totalPrice { get; set; }
    }
}
