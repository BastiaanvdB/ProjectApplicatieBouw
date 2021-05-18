using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Reservation
    {
        public int reservation_ID { get; set; }
        public int table_ID { get; set; }
        public int customer_ID { get; set; }
        public string customer_Name { get; set; }
        public int customer_Phone { get; set; }
        public DateTime reservation_DateTime { get; set; }
    }
}
