using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class Payment_Service
    {
        private Payment_DAO Payment_DB = new Payment_DAO();
        private OrderDetail_DAO OrderDetail_DB = new OrderDetail_DAO();
        private Order_DAO Order_DB = new Order_DAO();

        public void DB_Create_New_Payment(Payment payment)
        {
            Payment_DB.DB_Create_Payment(payment);
            Order_DB.DB_Set_Order_To_Paid(payment.order.order_ID);
            OrderDetail_DB.DB_Delete_All_Order_Details(payment.order);
        }
    }
}
