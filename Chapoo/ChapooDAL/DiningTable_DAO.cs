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
            return ReadDiningTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<DiningTable> DB_Get_All_DiningTables()
        {
            string query = "SELECT DiningTables.Table_ID, DiningTables.Table_Status FROM DiningTables";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDiningTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void DB_Update_DiningTable(DiningTable diningTable)
        {
            string query = $"INSERT INTO DiningTables VALUES (@table_id, @table_status)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@table_id", SqlDbType.Int) { Value = diningTable.table_ID},
                new SqlParameter("@table_status", SqlDbType.Int) { Value = ((int)diningTable.table_Status)}
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<DiningTable> ReadDiningTables(DataTable dataTable)
        {
            List<DiningTable> diningTables = new List<DiningTable>();
            foreach (DataRow dr in dataTable.Rows)
            {
                DiningTable diningTable = new DiningTable()
                {
                    table_ID = (int)dr["Table_ID"],
                    table_Status = (TableStatus)((int)dr["Table_Status"])
                };
                diningTables.Add(diningTable);
            }
            return diningTables;
        }

        private DiningTable ReadDiningTable(DataTable dataTable)
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

