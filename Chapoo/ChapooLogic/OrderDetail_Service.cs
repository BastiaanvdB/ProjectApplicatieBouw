﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class OrderDetail_Service
    {
        private OrderDetail_DAO BillDetail_DB = new OrderDetail_DAO();

        public List<OrderDetail> DB_Get_All_Bill_Details(int order_ID)
        {
            try
            {
                List<OrderDetail> billDetails = BillDetail_DB.DB_Get_All_Ordered_Items(order_ID);
                return billDetails;
            }
            catch (Exception)
            {
                List<OrderDetail> billDetails = new List<OrderDetail>();
                return billDetails;
            }
        }

        public void DB_Delete_All_Bill_Details(int Order_ID)
        {
            BillDetail_DB.DB_Delete_All_Bill_Details(Order_ID);
        }
    }
}