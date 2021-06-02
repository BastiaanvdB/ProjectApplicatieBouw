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
        private BillDetail_DAO BillDetail_DB = new BillDetail_DAO();
        private Bill_DAO Bill_DB = new Bill_DAO();

        public void DB_Create_New_Payment(Payment payment)
        {
            Payment_DB.DB_Create_Payment(payment);
            Bill_DB.DB_Set_Bill_To_Paid(payment.order.order_ID);
            BillDetail_DB.DB_Delete_All_Bill_Details(payment.order.order_ID);
        }
    }
}
