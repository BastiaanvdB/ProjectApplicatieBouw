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
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Order> Db_Get_All_Orders()
        {
            string query = "SELECT Orders.Table_ID, Orders.Order_ID, Orders.Order_PayStatus, Orders.Order_Status FROM Orders WHERE Orders.Order_PayStatus = 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
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

        public List<Order> DB_Get_All_Orders_By_MenuName_And_OrderStatus(string MenuName, string OrderStatus)
        {
            string query = "SELECT Orders.Table_ID AS Voor_Tafel, MenuGroup.MenuGroup_Name, MenuItems.Item_Name AS Bestelde_Drank, OrderDetails.OrderDetails_Quantity AS Aantal, OrderStatus.OrderStatus_status AS Status FROM OrderDetails INNER JOIN Orders ON OrderDetails.Order_ID = Orders.Order_ID INNER JOIN OrderStatus ON OrderDetails_OrderStatus = OrderStatus.OrderStatus_ID INNER JOIN MenuItems ON OrderDetails.Item_ID = MenuItems.Item_ID INNER JOIN MenuGroup ON MenuItems.MenuGroup_ID = MenuGroup.MenuGroup_ID INNER JOIN Menu ON MenuGroup.Menu_ID = Menu.Menu_ID WHERE Menu.Menu_Name = @MenuName AND OrderStatus.OrderStatus_status = @OrderStatus";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@MenuName", SqlDbType.NVarChar) { Value = MenuName },
                new SqlParameter("@OrderStatus", SqlDbType.NVarChar) { Value = OrderStatus }
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Order> ReadTables(DataTable dataTable)
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
