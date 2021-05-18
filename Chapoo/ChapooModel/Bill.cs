using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Bill
    {
        public int tableNumber { get; set; }
        public int orderNumber { get; set; }
        public decimal totalPrice { get; set; }
        public string payStatus { get; set; }
    }
}
