using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class BillDetail_Service
    {
        private BillDetail_DAO BillDetail_DB = new BillDetail_DAO();
        
        public List<BillDetail> DB_Get_All_Bill_Details(int order_ID)
        {
            try
            {
                List<BillDetail> billDetails = BillDetail_DB.DB_Get_All_Ordered_Items(order_ID);
                return billDetails;
            }
            catch (Exception)
            {
                List<BillDetail> billDetails = new List<BillDetail>();
                return billDetails;
            }
        }

        public void DB_Delete_All_Bill_Details(int Order_ID)
        {
            BillDetail_DB.DB_Delete_All_Bill_Details(Order_ID);
        }
    }
}
