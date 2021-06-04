using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class Stock_Service
    {
        private Stock_DAO Stock_DB = new Stock_DAO();

        public List<MenuItem> DB_Get_Stock()
        {
            return Stock_DB.DB_Get_Stock();
        }

        public void DB_Add_MenuItem(MenuItem menuItem, int MenuGroupcode)
        {
            Stock_DB.DB_Add_Stock(menuItem, MenuGroupcode);
        }

        public void DB_Remove_MenuItem(MenuItem menuItem)
        {
            Stock_DB.DB_Remove_Stock(menuItem);
        }

        public void DB_Update_MenuItem(MenuItem menuItem, int MenuGroupcode)
        {
            Stock_DB.DB_Update_Stock(menuItem, MenuGroupcode);
        }
    }
}
