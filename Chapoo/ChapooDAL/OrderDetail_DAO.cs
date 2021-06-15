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
            string query = "SELECT o.OrderDetails_ID, o.Item_ID, o.Order_ID, o.OrderDetails_Quantity, o.OrderDetails_Comment, o.Employee_ID, o.OrderDetails_OrderStatus, o.OrderDetails_Ordered_DateTime, o.OrderDetails_Preparing_DateTime, o.OrderDetails_Finished_DateTime FROM OrderDetails AS o WHERE o.Order_ID = @id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", SqlDbType.Int) {Value = order_id}
            };
            return ReadOrderDetailsNoTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<OrderDetail> DB_Get_All_OrderDetails_On_Specific_OrderStatus(string OrderStatus)
        {
            string query = "SELECT o.OrderDetails_ID, o.Item_ID, o.Order_ID, Orders.Table_ID, o.OrderDetails_Quantity, o.OrderDetails_Comment, o.Employee_ID, o.OrderDetails_Ordered_DateTime, o.OrderDetails_Preparing_DateTime, o.OrderDetails_Finished_DateTime, o.OrderDetails_OrderStatus FROM OrderDetails AS o INNER JOIN Orders ON o.Order_ID = Orders.Order_ID  INNER JOIN OrderStatus ON OrderDetails_OrderStatus = OrderStatus.OrderStatus_ID  INNER JOIN MenuItems ON o.Item_ID = MenuItems.Item_ID INNER JOIN MenuGroup ON MenuItems.MenuGroup_ID = MenuGroup.MenuGroup_ID INNER JOIN Menu ON MenuGroup.Menu_ID = Menu.Menu_ID  WHERE OrderStatus.OrderStatus_status = @status AND CAST(OrderDetails_Ordered_DateTime AS DATE) = CAST(GETDATE() AS DATE) ORDER BY OrderDetails_Finished_DateTime DESC";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@status", SqlDbType.NVarChar) {Value = OrderStatus}
            };
            return ReadOrderDetails(ExecuteSelectQuery(query, sqlParameters));
        }

        public void DB_Update_OrderDetails(OrderDetail orderDetail)
        {
            string query = "UPDATE OrderDetails SET OrderDetails.Item_ID = @item_ID, OrderDetails.Order_ID = @order_id, OrderDetails.OrderDetails_Quantity = @quantity, OrderDetails.OrderDetails_Comment = @comment, OrderDetails.Employee_ID = @employee_id, OrderDetails.OrderDetails_Ordered_DateTime = @ordered_datetime, OrderDetails.OrderDetails_Preparing_DateTime = @preparing_datetime, OrderDetails.OrderDetails_Finished_DateTime = @finished_datetime, OrderDetails.OrderDetails_OrderStatus = @orderstatus WHERE OrderDetails.OrderDetails_ID = @orderdetail_ID";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@orderdetail_ID", SqlDbType.Int) { Value = orderDetail.OrderDetails_ID },
                new SqlParameter("@item_ID", SqlDbType.Int) { Value = orderDetail.Item.Item_ID },
                new SqlParameter("@order_id", SqlDbType.Int) { Value = orderDetail.Order_ID },
                new SqlParameter("@quantity", SqlDbType.Int) { Value = orderDetail.Quantity },
                new SqlParameter("@comment", SqlDbType.NVarChar) { Value = orderDetail.Comment },
                new SqlParameter("@employee_id", SqlDbType.Int) { Value = orderDetail.Employee.Employee_id },
                new SqlParameter("@ordered_datetime", SqlDbType.DateTime) { Value = orderDetail.Ordered_DateTime },
                new SqlParameter("@preparing_datetime", SqlDbType.DateTime) { Value = orderDetail.Preparing_DateTime },
                new SqlParameter("@finished_datetime", SqlDbType.DateTime) { Value = orderDetail.Finished_DateTime },
                new SqlParameter("@orderstatus", SqlDbType.Int) { Value = ((int)orderDetail.OrderStatus) }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DB_Add_OrderDetails(OrderDetail orderDetail)
        {
            string query = "INSERT INTO OrderDetails VALUES (@item_ID, @order_id, @quantity, @comment, @employee_id, @ordered_datetime, @preparing_datetime, @finished_datetime, @orderstatus)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@item_ID", SqlDbType.Int) { Value = orderDetail.Item.Item_ID },
                new SqlParameter("@order_id", SqlDbType.Int) { Value = orderDetail.Order_ID },
                new SqlParameter("@quantity", SqlDbType.Int) { Value = orderDetail.Quantity },
                new SqlParameter("@comment", SqlDbType.NVarChar) { Value = orderDetail.Comment },
                new SqlParameter("@employee_id", SqlDbType.Int) { Value = orderDetail.Employee.Employee_id },
                new SqlParameter("@ordered_datetime", SqlDbType.DateTime) { Value = orderDetail.Ordered_DateTime },
                new SqlParameter("@preparing_datetime", SqlDbType.DateTime) { Value = orderDetail.Preparing_DateTime },
                new SqlParameter("@finished_datetime", SqlDbType.DateTime) { Value = orderDetail.Finished_DateTime },
                new SqlParameter("@orderstatus", SqlDbType.Int) { Value = ((int)orderDetail.OrderStatus) }
            };
            ExecuteEditQuery(query, sqlParameters);
            DB_Adjust_Stock(orderDetail);
        }

        private void DB_Adjust_Stock(OrderDetail orderDetail)
        {
            string query = "UPDATE MenuItems SET Item_Stock = @stockvalue WHERE Item_ID = @item_ID";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@item_ID", SqlDbType.Int) { Value = orderDetail.Item.Item_ID },
                new SqlParameter("@stockvalue", SqlDbType.Int) { Value = orderDetail.Item.Item_Stock - orderDetail.Quantity},
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DB_Delete_All_OrderDetails(Order order)
        {
            string query = $"DELETE FROM OrderDetails WHERE Order_ID = @order_id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@order_id", SqlDbType.Int) { Value = order.order_ID }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public List<OrderDetail> DB_Get_All_Orders_By_MenuName_And_OrderStatus_finnishTime(string MenuName, string OrderStatus)
        {
            string query = "SELECT o.OrderDetails_ID, o.Item_ID, o.Order_ID, Orders.Table_ID, o.OrderDetails_Quantity, o.OrderDetails_Comment, o.Employee_ID, o.OrderDetails_Ordered_DateTime, o.OrderDetails_Preparing_DateTime, o.OrderDetails_Finished_DateTime, o.OrderDetails_OrderStatus FROM OrderDetails AS o INNER JOIN Orders ON o.Order_ID = Orders.Order_ID  INNER JOIN OrderStatus ON OrderDetails_OrderStatus = OrderStatus.OrderStatus_ID  INNER JOIN MenuItems ON o.Item_ID = MenuItems.Item_ID  INNER JOIN MenuGroup ON MenuItems.MenuGroup_ID = MenuGroup.MenuGroup_ID  INNER JOIN Menu ON MenuGroup.Menu_ID = Menu.Menu_ID  WHERE Menu.Menu_Name = @MenuName AND OrderStatus.OrderStatus_status = @OrderStatus AND CAST(OrderDetails_Ordered_DateTime AS DATE) = CAST(GETDATE() AS DATE) ORDER BY OrderDetails_Finished_DateTime DESC";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@MenuName", SqlDbType.NVarChar) { Value = MenuName },
                new SqlParameter("@OrderStatus", SqlDbType.NVarChar) { Value = OrderStatus }
            };
            return ReadOrderDetails(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<OrderDetail> DB_Get_All_Orders_By_MenuName_And_OrderStatus_OrderTime(string MenuName, string OrderStatus)
        {
            string query = "SELECT o.OrderDetails_ID, o.Item_ID, o.Order_ID, Orders.Table_ID, o.OrderDetails_Quantity, o.OrderDetails_Comment, o.Employee_ID, o.OrderDetails_Ordered_DateTime, o.OrderDetails_Preparing_DateTime, o.OrderDetails_Finished_DateTime, o.OrderDetails_OrderStatus FROM OrderDetails AS o INNER JOIN Orders ON o.Order_ID = Orders.Order_ID  INNER JOIN OrderStatus ON OrderDetails_OrderStatus = OrderStatus.OrderStatus_ID  INNER JOIN MenuItems ON o.Item_ID = MenuItems.Item_ID  INNER JOIN MenuGroup ON MenuItems.MenuGroup_ID = MenuGroup.MenuGroup_ID  INNER JOIN Menu ON MenuGroup.Menu_ID = Menu.Menu_ID  WHERE Menu.Menu_Name = @MenuName AND OrderStatus.OrderStatus_status = @OrderStatus AND CAST(OrderDetails_Ordered_DateTime AS DATE) = CAST(GETDATE() AS DATE) ORDER BY OrderDetails_Ordered_DateTime DESC";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@MenuName", SqlDbType.NVarChar) { Value = MenuName },
                new SqlParameter("@OrderStatus", SqlDbType.NVarChar) { Value = OrderStatus }
            };
            return ReadOrderDetails(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderDetail> ReadOrderDetails(DataTable dataTable)
        {
            Employee_DAO employee_DAO = new Employee_DAO();
            MenuItem_DAO Menuitem_DAO = new MenuItem_DAO();
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            foreach (DataRow dr in dataTable.Rows)
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.OrderDetails_ID = (int)dr["OrderDetails_ID"];
                orderDetail.Item = Menuitem_DAO.DB_Get_MenuItem((int)dr["Item_ID"]);
                orderDetail.Order_ID = (int)dr["Order_ID"];
                orderDetail.Table_ID = (int)dr["Table_ID"];
                orderDetail.Quantity = (int)dr["OrderDetails_Quantity"];
                orderDetail.Comment = (string)dr["OrderDetails_Comment"];
                orderDetail.Employee = employee_DAO.DB_Get_Employee((int)dr["Employee_ID"]);
                orderDetail.OrderStatus = (OrderStatus)((int)dr["OrderDetails_OrderStatus"]);
                orderDetail.Ordered_DateTime = (DateTime)dr["OrderDetails_Ordered_DateTime"];
                orderDetail.Preparing_DateTime = (DateTime)dr["OrderDetails_Preparing_DateTime"];
                orderDetail.Finished_DateTime = (DateTime)dr["OrderDetails_Finished_DateTime"];
                orderDetails.Add(orderDetail);
            }
            return orderDetails;
        }

        private List<OrderDetail> ReadOrderDetailsNoTable(DataTable dataTable)
        {
            Employee_DAO employee_DAO = new Employee_DAO();
            MenuItem_DAO Menuitem_DAO = new MenuItem_DAO();
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            foreach (DataRow dr in dataTable.Rows)
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.OrderDetails_ID = (int)dr["OrderDetails_ID"];
                orderDetail.Item = Menuitem_DAO.DB_Get_MenuItem((int)dr["Item_ID"]);
                orderDetail.Order_ID = (int)dr["Order_ID"];
                orderDetail.Quantity = (int)dr["OrderDetails_Quantity"];
                orderDetail.Comment = (string)dr["OrderDetails_Comment"];
                orderDetail.Employee = employee_DAO.DB_Get_Employee((int)dr["Employee_ID"]);
                orderDetail.OrderStatus = (OrderStatus)((int)dr["OrderDetails_OrderStatus"]);
                orderDetail.Ordered_DateTime = (DateTime)dr["OrderDetails_Ordered_DateTime"];
                orderDetail.Preparing_DateTime = (DateTime)dr["OrderDetails_Preparing_DateTime"];
                orderDetail.Finished_DateTime = (DateTime)dr["OrderDetails_Finished_DateTime"];
                orderDetails.Add(orderDetail);
            }
            return orderDetails;
        }
    }
}
