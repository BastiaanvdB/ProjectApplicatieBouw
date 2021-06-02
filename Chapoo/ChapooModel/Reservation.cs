using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Reservation
    {
        public int reservation_ID { get; }
        public DiningTable table { get; set; }
        public Customer customer { get; set; }
        public DateTime reservation_DateTime { get; set; }
    }
}
