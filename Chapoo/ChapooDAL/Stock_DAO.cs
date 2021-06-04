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
    public class Stock_DAO : Base
    {
        public List<MenuItem> DB_Get_Stock()
        {
            string query = "SELECT MenuGroup.MenuGroup_Name, MenuItems.Item_ID, MenuItems.Item_Name, MenuItems.Item_Price, MenuItems.Item_Taxpercentage, MenuItems.Alcohol_Check, MenuItems.Item_Stock, MenuItems.Item_Restock FROM MenuItems INNER JOIN MenuGroup ON MenuItems.MenuGroup_ID = MenuGroup.MenuGroup_ID ORDER BY MenuGroup_Name";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadStock(ExecuteSelectQuery(query, sqlParameters));
        }

        public void DB_Add_Stock(MenuItem menuItem, int MenuGroupcode)
        {
            string query = "INSERT INTO MenuItem (@menugroup, @item_name, @price, @tax, @stock, @restock, @alcoholcheck)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@menugroup", SqlDbType.Int) { Value = MenuGroupcode },
                new SqlParameter("@item_name", SqlDbType.NVarChar) { Value = menuItem.item_Name },
                new SqlParameter("@price", SqlDbType.Money) { Value = menuItem.item_Price },
                new SqlParameter("@tax", SqlDbType.Int) { Value = menuItem.item_Taxpercentage },
                new SqlParameter("@stock", SqlDbType.Int) { Value = menuItem.item_Stock },
                new SqlParameter("@restock", SqlDbType.Int) { Value = menuItem.item_Restock },
                new SqlParameter("@alcoholcheck", SqlDbType.Bit) { Value = menuItem.Alcohol_Check }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DB_Remove_Stock(MenuItem menuItem)
        {
            string query = "DELETE FROM MenuItems WHERE MenuItems.Item_ID = @item_id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@item_id", SqlDbType.Int) { Value = menuItem.item_ID }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DB_Update_Stock(MenuItem menuItem, int MenuGroupcode)
        {
            string query = "UPDATE MenuItems SET MenuGroup_ID = @menugroup, Item_Name = @item_name, Item_Price = @price, Item_Taxpercentage = @tax, Item_Stock = @stock, Item_Restock = @restock, Alcohol_Check = @alcoholcheck WHERE MenuItems.Item_ID = @item_id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@item_id", SqlDbType.Int) { Value = menuItem.item_ID },
                new SqlParameter("@menugroup", SqlDbType.Int) { Value = MenuGroupcode },
                new SqlParameter("@item_name", SqlDbType.NVarChar) { Value = menuItem.item_Name },
                new SqlParameter("@price", SqlDbType.Money) { Value = menuItem.item_Price },
                new SqlParameter("@tax", SqlDbType.Int) { Value = menuItem.item_Taxpercentage },
                new SqlParameter("@stock", SqlDbType.Int) { Value = menuItem.item_Stock },
                new SqlParameter("@restock", SqlDbType.Int) { Value = menuItem.item_Restock },
                new SqlParameter("@alcoholcheck", SqlDbType.Bit) { Value = menuItem.Alcohol_Check }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<MenuItem> ReadStock(DataTable dataTable)
        {
            List<MenuItem> Items = new List<MenuItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem item = new MenuItem()
                {
                    item_ID = (int)dr["Item_ID"],
                    MenuGroup = (string)dr[""],
                    item_Name = (string)dr[""],
                    item_Price = (decimal)dr[""],
                    item_Taxpercentage = (int)dr[""],
                    item_Stock = (int)dr[""],
                    item_Restock = (int)dr[""],
                    Alcohol_Check = (bool)dr[""]
                };
                Items.Add(item);
            }
            return Items;
        }
    }
}
