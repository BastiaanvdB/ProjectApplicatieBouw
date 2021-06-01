using System;
using ChapooModel;
using ChapooDAL;
using System.Collections.Generic;

namespace ChapooLogic
{
    public class Bill_Service
    {
        private Bill_DAO bill_db = new Bill_DAO();

        public List<Bill> DB_Get_All_Unpaid_Bills()
        {
            try
            {
                List<Bill> billList = bill_db.Db_Get_All_Unpaid_Bills();
                return billList;
            }
            catch (Exception )
            {
                List<Bill> billList = new List<Bill>();
                return billList;

            }
        }

        public void DB_Set_Bill_To_Paid(int Order_ID)
        {
            bill_db.DB_Set_Bill_To_Paid(Order_ID);
        }
    }
}
