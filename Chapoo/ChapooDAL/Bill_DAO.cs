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
            string query = "SELECT MAX(o.Table_ID) AS tafelnummer, o.Order_ID, SUM(d.orderdetails_quantity*p.Item_Price) as totalprice, MAX(s.PayStatus_Status) AS paystatus FROM Orders AS o INNER JOIN OrderDetails AS d ON d.order_id = o.order_id INNER JOIN MenuItems AS p ON d.Item_ID = p.Item_ID INNER JOIN PayStatus AS s On o.Order_PayStatus = s.PayStatus_ID WHERE o.Order_PayStatus = 0 GROUP BY o.Order_ID";
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
            List<Bill> bills = new List<Bill>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Bill bill = new Bill()
                {
                    tableNumber = (int)dr["tafelnummer"],
                    orderNumber = (int)dr["Order_ID"],
                    totalPrice = (decimal)dr["totalprice"],
                    payStatus = (string)dr["paystatus"]
                };
                bills.Add(bill);
            }
            return bills;
        }
    }
}
