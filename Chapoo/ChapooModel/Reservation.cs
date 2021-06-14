using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Reservation
    {
        public int Reservation_ID { get; set; }
        public DiningTable Table { get; set; }
        public Customer Customer { get; set; }
        public DateTime Reservation_DateTime { get; set; }
    }
}
