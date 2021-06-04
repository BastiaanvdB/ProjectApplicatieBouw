using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class DiningTable_Service
    {
        private DiningTable_DAO DiningTable_DB = new DiningTable_DAO();

        public List<DiningTable> DB_Get_All_DiningTables()
        {
            return DiningTable_DB.DB_Get_All_DiningTables();
        }

        public DiningTable DB_Get_DiningTable(int tableNumber)
        {
            return DiningTable_DB.DB_Get_DiningTable(tableNumber);
        }

        public void DB_Update_DiningTable(DiningTable diningTable)
        {
            DiningTable_DB.DB_Update_DiningTable(diningTable);
        }
    }
}
