using System;
using ChapooModel;
using ChapooDAL;
using System.Collections.Generic;

namespace ChapooLogic
{
    public class Order_Service
    {
        private Order_DAO bill_db = new Order_DAO();

        public List<Order> DB_Get_All_Unpaid_Bills()
        {
            //try
            //{
                List<Order> billList = bill_db.Db_Get_All_Unpaid_Bills();
                return billList;
            //}
            //catch (Exception )
            //{
            //    List<Bill> billList = new List<Bill>();
            //    return billList;

            //}
        }

        public void DB_Set_Bill_To_Paid(int Order_ID)
        {
            bill_db.DB_Set_Bill_To_Paid(Order_ID);
        }
    }
}
