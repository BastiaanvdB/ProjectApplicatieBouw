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
        private OrderDetail_DAO OrderDetail_DB = new OrderDetail_DAO();

        public List<OrderDetail> DB_Get_All_OrderDetails(Order order)
        {
            return OrderDetail_DB.DB_Get_All_Ordered_Items(order.order_ID);
        }

        public void DB_Add_OrderDetails(OrderDetail orderDetail)
        {
            OrderDetail_DB.DB_Add_OrderDetails(orderDetail);
        }

        public List<OrderDetail> DB_Get_All_Orders_By_MenuName_And_OrderStatus(string MenuName, string OrderStatus)
        {
            return OrderDetail_DB.DB_Get_All_Orders_By_MenuName_And_OrderStatus(MenuName, OrderStatus);
        }

        public void DB_Delete_All_OrderDetails(Order order)
        {
            OrderDetail_DB.DB_Delete_All_OrderDetails(order);
        }
    }
}
