using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooModel;

namespace ChapooDAL
{
    public class DiningTable_DAO : Base
    {
        public DiningTable DB_Get_DiningTable(int tableNumber)
        {
            string query = "SELECT DiningTables.Table_ID, DiningTables.Table_Status FROM DiningTables WHERE DiningTables.Table_ID = @id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", SqlDbType.Int) {Value = tableNumber}
            };
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        private DiningTable ReadTable(DataTable dataTable)
        {
            DiningTable diningTable = new DiningTable();

            foreach (DataRow dr in dataTable.Rows)
            {
                diningTable.table_ID = (int)dr["Table_ID"];
                diningTable.table_Status = (TableStatus)((int)dr["Table_Status"]);
            }
            
            return diningTable;
        }

    }
}

