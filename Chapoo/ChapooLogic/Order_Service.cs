using System;
using ChapooModel;
using ChapooDAL;
using System.Collections.Generic;

namespace ChapooLogic
{
    public class Order_Service
    {
        private Order_DAO Order_db = new Order_DAO();

        public List<Order> DB_Get_All_Unpaid_Orders()
        {
            //try
            //{
                List<Order> UnpaidOrderList = Order_db.Db_Get_All_Unpaid_Orders();
                return UnpaidOrderList;
            //}
            //catch (Exception )
            //{
            //    List<Bill> billList = new List<Bill>();
            //    return billList;

            //}
        }

        public void DB_Set_Order_To_Paid(int Order_ID)
        {
            Order_db.DB_Set_Order_To_Paid(Order_ID);
        }
    }
}
