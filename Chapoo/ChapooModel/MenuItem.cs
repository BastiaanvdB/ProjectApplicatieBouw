using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class MenuItem
    {
        public int orderDetails_ID { get; set; }
        public int item_ID { get; set; }
        public int quantity { get; set; }
        public string comment { get; set; }
        public int employee_ID { get; set; }
        public DateTime ordered_DateTime { get; set; }
        public DateTime preparing_DateTime { get; set; }
        public DateTime finished_DateTime { get; set; }
    }
}
