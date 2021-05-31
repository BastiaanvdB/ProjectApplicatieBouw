using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class MenuItem_Service
    {
        Item_DAO Item_db = new Item_DAO();
        public List<MenuItem> DB_Get_All_MenuItems()
        {
            List<MenuItem> items = Item_db.DB_Get_All_Items();
            return items;
        }
    }
}
