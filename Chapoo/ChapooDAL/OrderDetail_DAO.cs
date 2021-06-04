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
    public class OrderDetail_DAO : Base
    {
        public List<OrderDetail> DB_Get_All_Ordered_Items(int order_id)
        {
            string query = "SELECT o.Item_ID, o.OrderDetails_Quantity, o.OrderDetails_Comment, o.Employee_ID, o.OrderDetails_OrderStatus, o.OrderDetails_Ordered_DateTime, o.OrderDetails_Preparing_DateTime, o.OrderDetails_Finished_DateTime FROM OrderDetails AS o WHERE o.Order_ID = @id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", SqlDbType.Int) {Value = order_id}
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void DB_Delete_All_Order_Details(Order order)
        {
            string query = $"DELETE FROM OrderDetails WHERE Order_ID = @order_id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@order_id", SqlDbType.Int) { Value = order.order_ID }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public List<OrderDetail> DB_Get_All_Orders_By_MenuName_And_OrderStatus(string MenuName, string OrderStatus)
        {
            string query = "SELECT o.OrderDetails_ID, o.Item_ID, o.Order_ID, o.OrderDetails_Quantity, o.OrderDetails_Comment, o.Employee_ID, o.OrderDetails_Ordered_DateTime, o.OrderDetails_Preparing_DateTime, o.OrderDetails_Finished_DateTime, o.OrderDetails_OrderStatus FROM OrderDetails AS o INNER JOIN Orders ON o.Order_ID = Orders.Order_ID  INNER JOIN OrderStatus ON OrderDetails_OrderStatus = OrderStatus.OrderStatus_ID  INNER JOIN MenuItems ON o.Item_ID = MenuItems.Item_ID  INNER JOIN MenuGroup ON MenuItems.MenuGroup_ID = MenuGroup.MenuGroup_ID  INNER JOIN Menu ON MenuGroup.Menu_ID = Menu.Menu_ID  WHERE Menu.Menu_Name = @MenuName AND OrderStatus.OrderStatus_status = @OrderStatus";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@MenuName", SqlDbType.NVarChar) { Value = MenuName },
                new SqlParameter("@OrderStatus", SqlDbType.NVarChar) { Value = OrderStatus }
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderDetail> ReadTables(DataTable dataTable)
        {
            Employee_DAO employee_DAO = new Employee_DAO();
            MenuItem_DAO Menuitem_DAO = new MenuItem_DAO();
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            foreach (DataRow dr in dataTable.Rows)
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.orderDetails_ID = (int)dr["OrderDetails_ID"];
                orderDetail.item = Menuitem_DAO.DB_Get_MenuItem((int)dr["Item_ID"]);
                orderDetail.quantity = (int)dr["OrderDetails_Quantity"];
                orderDetail.comment = (string)dr["OrderDetails_Comment"];
                orderDetail.employee = employee_DAO.DB_Get_Employee((int)dr["Employee_ID"]);
                orderDetail.orderStatus = (OrderStatus)((int)dr["OrderDetails_OrderStatus"]);
                orderDetail.ordered_DateTime = (DateTime)dr["OrderDetails_Ordered_DateTime"];
                orderDetail.preparing_DateTime = (DateTime)dr["OrderDetails_Preparing_DateTime"];
                orderDetail.finished_DateTime = (DateTime)dr["OrderDetails_Finished_DateTime"];
                orderDetails.Add(orderDetail);
            }
            return orderDetails;
        }
    }
}
