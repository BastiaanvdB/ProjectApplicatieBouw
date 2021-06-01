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
    public class Item_DAO : Base
    {
        public List<MenuItem> DB_Get_All_Items()
        {
            string query = "SELECT Item_ID FROM OrderDetails";
            //string query = "SELECT Item_ID, Order_ID, OrderDetails_Quantity, OrderDetails_Comment, Employee_ID, OrderDetails_Ordered_DateTime, OrderDetails_Preparing_DateTime, OrderDetails_Finished_DateTime FROM OrderDetails";
            //SqlParameter[] sqlParameters =
            //{
            //    new SqlParameter("@id", SqlDbType.Int) {Value = Order_ID}
            //};
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> Items = new List<MenuItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem item = new MenuItem()
                {
                    item_ID = (int)dr["Item_ID"],
                    //orderDetails_ID = (int)dr["Order_ID"],
                    //quantity = (int)dr["OrderDetails_Quantity"],
                    //comment = (string)(dr["OrderDetails_Comment"].ToString()),
                    //employee_ID = (int)dr["Employee_ID"],
                    //ordered_DateTime = (DateTime)dr["OrderDetails_Ordered_DateTime"],
                    //preparing_DateTime = (DateTime)dr["OrderDetails_Preparing_DateTime"],
                    //finished_DateTime = (DateTime)dr["OrderDetails_Finished_DateTime"],
                };
                Items.Add(item);
            }
            return Items;
        }
    }
}
 