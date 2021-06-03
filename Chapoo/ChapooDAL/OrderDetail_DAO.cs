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
        public List<OrderDetail> DB_Get_All_Ordered_Items(int order_ID)
        {
            string query = "SELECT o.Item_ID, o.OrderDetails_Quantity, o.OrderDetails_Comment, o.Employee_ID, o.OrderDetails_Ordered_DateTime, o.OrderDetails_Preparing_DateTime, o.OrderDetails_Finished_DateTime FROM OrderDetails AS o WHERE o.Order_ID = @id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", SqlDbType.Int) {Value = order_ID}
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void DB_Delete_All_Bill_Details(int Order_ID)
        {
            string query = $"DELETE FROM OrderDetails WHERE Order_ID = @order_id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@order_id", SqlDbType.Int) { Value = Order_ID }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<OrderDetail> ReadTables(DataTable dataTable)
        {
            Employee_DAO employee_DAO = new Employee_DAO();
            Item_DAO item_DAO = new Item_DAO();
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            foreach (DataRow dr in dataTable.Rows)
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.item = item_DAO.DB_Get_Item((int)dr["Item_ID"]);
                orderDetail.quantity = (int)dr["OrderDetails_Quantity"];
                orderDetail.comment = (string)dr["OrderDetails_Comment"];
                orderDetail.employee = employee_DAO.DB_Get_Employee((int)dr["Employee_ID"]);
                orderDetail.ordered_DateTime = (DateTime)dr["OrderDetails_Ordered_DateTime"];
                orderDetail.preparing_DateTime = (DateTime)dr["OrderDetails_Preparing_DateTime"];
                orderDetail.finished_DateTime = (DateTime)dr["OrderDetails_Finished_DateTime"];
                orderDetails.Add(orderDetail);
            }
            return orderDetails;
        }
    }
}
