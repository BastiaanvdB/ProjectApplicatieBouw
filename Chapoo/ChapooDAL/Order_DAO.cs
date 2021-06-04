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
    public class Order_DAO : Base
    {
        public List<Order> Db_Get_All_Unpaid_Orders()
        {
            string query = "SELECT Orders.Table_ID, Orders.Order_ID, Orders.Order_PayStatus FROM Orders WHERE Orders.Order_PayStatus = 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Order> Db_Get_All_Orders()
        {
            string query = "SELECT Orders.Table_ID, Orders.Order_ID, Orders.Order_PayStatus, Orders.Order_Status FROM Orders WHERE Orders.Order_PayStatus = 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        public void DB_Set_Order_To_Paid(int Order_ID)
        {
            string query = $"UPDATE Orders SET Order_PayStatus = 1 WHERE Order_ID = @order_id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@order_id", SqlDbType.Int) { Value = Order_ID }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DB_Add_Order(Order order)
        {
            string query = "INSERT INTO Orders VALUES (@Table_ID, @Paystatus)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Table_ID", SqlDbType.Int) { Value = order.Table.table_ID },
                new SqlParameter("@Paystatus", SqlDbType.Int) { Value = ((int)order.paystatus) },
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Order> ReadOrders(DataTable dataTable)
        {
            OrderDetail_DAO orderDetail_DAO = new OrderDetail_DAO();
            DiningTable_DAO diningTable_DAO = new DiningTable_DAO();
            List<Order> bills = new List<Order>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Order bill = new Order()
                {
                    order_ID = (int)dr["Order_ID"],
                    Table = diningTable_DAO.DB_Get_DiningTable((int)dr["Table_ID"]),
                    OrderDetails = orderDetail_DAO.DB_Get_All_Ordered_Items((int)dr["Order_ID"]),
                    paystatus = (PayStatus)((int)dr["Order_PayStatus"])
                };
                bills.Add(bill);
            }
            return bills;
        }
    }
}
