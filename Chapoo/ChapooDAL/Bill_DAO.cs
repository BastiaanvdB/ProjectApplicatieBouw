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
    public class Bill_DAO : Base
    {
        public List<Bill> Db_Get_All_Unpaid_Bills()
        {
            string query = "SELECT Orders.Table_ID, Orders.Order_ID, Orders.Order_PayStatus, Orders.Order_Status FROM Orders WHERE Orders.Order_PayStatus = 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Bill> Db_Get_All_Orders()
        {
            string query = "SELECT Orders.Table_ID, Orders.Order_ID, Orders.Order_PayStatus, Orders.Order_Status FROM Orders WHERE Orders.Order_PayStatus = 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void DB_Set_Bill_To_Paid(int Order_ID)
        {
            string query = $"UPDATE Orders SET Order_PayStatus = 1 WHERE Order_ID = @order_id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@order_id", SqlDbType.Int) { Value = Order_ID }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Bill> ReadTables(DataTable dataTable)
        {
            BillDetail_DAO billDetail_DAO = new BillDetail_DAO();
            DiningTable_DAO diningTable_DAO = new DiningTable_DAO();
            List<Bill> bills = new List<Bill>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Bill bill = new Bill()
                {
                    order_ID = (int)dr["Order_ID"],
                    Table = diningTable_DAO.DB_Get_Dining_Table((int)dr["Table_ID"]),
                    OrderDetails = billDetail_DAO.DB_Get_All_Ordered_Items((int)dr["Order_ID"]),
                    paystatus = (PayStatus)((int)dr["Order_PayStatus"]),
                    orderStatus = (OrderStatus)((int)dr["Order_Status"])
                };
                bills.Add(bill);
            }
            return bills;
        }
    }
}
