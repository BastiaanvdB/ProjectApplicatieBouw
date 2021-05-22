using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Payment
    {
        public int payment_ID { get; set; }
        public int order_ID { get; set; }
        public int table_ID { get; set; }
        public int payMethod_ID { get; set; }
        public string payMethod { get; set; }
        public int employee_ID { get; set; }
        public int payStatus_ID { get; set; }
        public string payStatus { get; set; }
        public decimal totalPrice { get; set; }
        public decimal totalVAT { get; set; }
        public decimal tip { get; set; }
        public DateTime payment_DateTime { get; set; }
    }
}
