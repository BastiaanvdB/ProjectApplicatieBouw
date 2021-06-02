using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class MenuItem
    {
        public int item_ID { get; set; }
        public string MenuGroup { get; set; }
        public string item_Name { get; set; }
        public decimal item_Price { get; set; }
        public int item_Taxpercentage { get; set; }
        public int item_Stock { get; set; }
        public int item_Restock { get; set; }
        public bool Alcohol_Check { get; set; }
    }
}
