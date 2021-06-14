using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Payment
    {
        public int Payment_ID { get; set; }
        public Order Order { get; set; }
        public DiningTable Table { get; set; }
        public PayMethod PayMethod { get; set; }
        public Employee Employee { get; set; }
        public string Comment { get; set; }
        public PayStatus PayStatus { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalVAT { get; set; }
        public decimal Tip { get; set; }
        public DateTime Payment_DateTime { get; set; }
    }
}
