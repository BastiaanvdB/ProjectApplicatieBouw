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
        private MenuItem_DAO MenuItem_DB = new MenuItem_DAO();
        
        public List<MenuItem> DB_Get_All_MenuItems()
        {
            return MenuItem_DB.DB_Get_All_MenuItems();
        }

        public MenuItem DB_Get_MenuItem(int item_id)
        {
            return MenuItem_DB.DB_Get_MenuItem(item_id);
        }
    }
}
