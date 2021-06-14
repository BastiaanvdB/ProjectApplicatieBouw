using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class MenuItem
    {
        public int Item_ID { get; set; }
        public string MenuGroup { get; set; }
        public string Item_Name { get; set; }
        public decimal Item_Price { get; set; }
        public int Item_Taxpercentage { get; set; }
        public int Item_Stock { get; set; }
        public int Item_Restock { get; set; }
        public bool Alcohol_Check { get; set; }
    }
}
