﻿using System;
using ChapooModel;
using ChapooDAL;
using System.Collections.Generic;

namespace ChapooLogic
{
    public class Order_Service
    {
        private Order_DAO Order_DB = new Order_DAO();

        public List<Order> Db_Get_All_Orders()
        {
            return Order_DB.Db_Get_All_Orders();
        }

        public void DB_Add_Order(Order order)
        {
            Order_DB.DB_Add_Order(order);
        }

        public List<Order> DB_Get_All_Unpaid_Orders()
        {
            return Order_DB.Db_Get_All_Unpaid_Orders();
        }

        public void DB_Set_Order_To_Paid(int Order_ID)
        {
            Order_DB.DB_Set_Order_To_Paid(Order_ID);
        }
    }
}
