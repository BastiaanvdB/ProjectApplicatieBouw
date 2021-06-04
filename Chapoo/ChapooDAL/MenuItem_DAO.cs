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
    public class MenuItem_DAO : Base
    {
        
        public List<MenuItem> DB_Get_All_MenuItems()
        {
            string query = "SELECT MenuItems.Item_ID, MenuGroup.MenuGroup_Name, MenuItems.Item_Name, MenuItems.Item_Price, MenuItems.Item_Taxpercentage, MenuItems.Item_Stock, MenuItems.Item_Restock, MenuItems.Alcohol_Check FROM MenuItems INNER JOIN MenuGroup ON MenuItems.MenuGroup_ID = MenuGroup.MenuGroup_ID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadMenuItems(ExecuteSelectQuery(query, sqlParameters));
        }

        public MenuItem DB_Get_MenuItem(int item_id)
        {
            string query = "SELECT MenuItems.Item_ID, MenuGroup.MenuGroup_Name, MenuItems.Item_Name, MenuItems.Item_Price, MenuItems.Item_Taxpercentage, MenuItems.Item_Stock, MenuItems.Item_Restock, MenuItems.Alcohol_Check FROM MenuItems INNER JOIN MenuGroup ON MenuItems.MenuGroup_ID = MenuGroup.MenuGroup_ID WHERE MenuItems.Item_ID = @id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", SqlDbType.Int) {Value = item_id}
            };
            return ReadMenuItem(ExecuteSelectQuery(query, sqlParameters));
        }

        private MenuItem ReadMenuItem(DataTable dataTable)
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

        private List<MenuItem> ReadMenuItems(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem MenuItem = new MenuItem()
                {
                    item_ID = (int)dr["Item_ID"],
                    MenuGroup = (string)dr["MenuGroup_Name"],
                    item_Name = (string)dr["Item_Name"],
                    item_Price = (decimal)dr["Item_Price"],
                    item_Taxpercentage = (int)dr["Item_Taxpercentage"],
                    item_Stock = (int)dr["Item_Stock"],
                    item_Restock = (int)dr["Item_Restock"],
                    Alcohol_Check = (bool)dr["Alcohol_Check"],
                };
                menuItems.Add(MenuItem);
            }
            return menuItems;
        }
    }
}
 