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
        public Order order { get; set; }
        public DiningTable table { get; set; }
        public PayMethod payMethod { get; set; }
        public Employee employee { get; set; }
        public PayStatus payStatus { get; set; }
        public decimal totalPrice { get; set; }
        public decimal totalVAT { get; set; }
        public decimal tip { get; set; }
        public DateTime payment_DateTime { get; set; }
    }
}
