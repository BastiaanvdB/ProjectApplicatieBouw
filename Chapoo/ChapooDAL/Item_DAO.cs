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
    public class Item_DAO : Base
    {
        public List<MenuItem> DB_Get_All_Items()
        {
            string query = "SELECT Item_ID FROM OrderDetails";
            //string query = "SELECT Item_ID, Order_ID, OrderDetails_Quantity, OrderDetails_Comment, Employee_ID, OrderDetails_Ordered_DateTime, OrderDetails_Preparing_DateTime, OrderDetails_Finished_DateTime FROM OrderDetails";
            //SqlParameter[] sqlParameters =
            //{
            //    new SqlParameter("@id", SqlDbType.Int) {Value = Order_ID}
            //};
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public MenuItem DB_Get_Item(int item_id)
        {
            string query = "SELECT MenuItems.Item_ID, MenuGroup.MenuGroup_Name, MenuItems.Item_Name, MenuItems.Item_Price, MenuItems.Item_Taxpercentage, MenuItems.Item_Stock, MenuItems.Item_Restock, MenuItems.Alcohol_Check FROM MenuItems INNER JOIN MenuGroup ON MenuItems.MenuGroup_ID = MenuGroup.MenuGroup_ID WHERE MenuItems.Item_ID = @id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", SqlDbType.Int) {Value = item_id}
            };
            return ReadItem(ExecuteSelectQuery(query, sqlParameters));
        }

        private MenuItem ReadItem(DataTable dataTable)
        {
            MenuItem menuItem = new MenuItem();
            foreach (DataRow dr in dataTable.Rows)
            {
                menuItem.item_ID = (int)dr["Item_ID"];
                menuItem.MenuGroup = (string)dr["MenuGroup_Name"];
                menuItem.item_Name = (string)dr["Item_Name"];
                menuItem.item_Price = (decimal)dr["Item_Price"];
                menuItem.item_Taxpercentage = (int)dr["Item_Taxpercentage"];
                menuItem.item_Stock = (int)dr["Item_Stock"];
                menuItem.item_Restock = (int)dr["Item_Restock"];
                menuItem.Alcohol_Check = (bool)dr["Alcohol_Check"];
            }
            return menuItem;
        }


















        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> Items = new List<MenuItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem item = new MenuItem()
                {
                    //item_ID = (int)dr["Item_ID"],
                    //orderDetails_ID = (int)dr["Order_ID"],
                    //quantity = (int)dr["OrderDetails_Quantity"],
                    //comment = (string)(dr["OrderDetails_Comment"].ToString()),
                    //employee_ID = (int)dr["Employee_ID"],
                    //ordered_DateTime = (DateTime)dr["OrderDetails_Ordered_DateTime"],
                    //preparing_DateTime = (DateTime)dr["OrderDetails_Preparing_DateTime"],
                    //finished_DateTime = (DateTime)dr["OrderDetails_Finished_DateTime"],
                };
                Items.Add(item);
            }
            return Items;
        }
    }
}
 