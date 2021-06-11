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

        public void DB_Add_Stock(MenuItem menuItem)
        {
            string query = "INSERT INTO MenuItems VALUES (@menugroup, @item_name, @itemprice, @tax, @stock, @restock, @alcoholcheck)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@menugroup", SqlDbType.Int) { Value = int.Parse(menuItem.MenuGroup) },
                new SqlParameter("@item_name", SqlDbType.NVarChar) { Value = menuItem.item_Name },
                new SqlParameter("@itemprice", SqlDbType.Money) { Value = menuItem.item_Price },
                new SqlParameter("@tax", SqlDbType.Int) { Value = menuItem.item_Taxpercentage },
                new SqlParameter("@stock", SqlDbType.Int) { Value = menuItem.item_Stock },
                new SqlParameter("@restock", SqlDbType.Int) { Value = menuItem.item_Restock },
                new SqlParameter("@alcoholcheck", SqlDbType.Bit) { Value = menuItem.Alcohol_Check }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public List<MenuItem> DB_Get_Specific_Stock(int Menucode)
        {
            string query = "SELECT MenuGroup.MenuGroup_Name, Item_ID, Item_Name, Item_Price, Item_Taxpercentage, Alcohol_Check, Item_Stock, Item_Restock FROM MenuItems INNER JOIN MenuGroup ON MenuItems.MenuGroup_ID = MenuGroup.MenuGroup_ID INNER JOIN Menu ON MenuGroup.Menu_ID = Menu.Menu_ID WHERE Menu.Menu_ID = @Menucode";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Menucode", SqlDbType.Int) { Value = Menucode },
            };
            return ReadStock(ExecuteSelectQuery(query, sqlParameters));
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

        public void DB_Update_Stock(MenuItem menuItem)
        {
            string query = "UPDATE MenuItems SET MenuGroup_ID = @menugroup, Item_Name = @item_name, Item_Price = @price, Item_Taxpercentage = @tax, Item_Stock = @stock, Item_Restock = @restock, Alcohol_Check = @alcoholcheck WHERE MenuItems.Item_ID = @item_id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@item_id", SqlDbType.Int) { Value = menuItem.item_ID },
                new SqlParameter("@menugroup", SqlDbType.Int) { Value = int.Parse(menuItem.MenuGroup) },
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
                    MenuGroup = (string)dr["MenuGroup_Name"],
                    item_Name = (string)dr["Item_Name"],
                    item_Price = (decimal)dr["Item_Price"],
                    item_Taxpercentage = (int)dr["Item_Taxpercentage"],
                    item_Stock = (int)dr["Item_Stock"],
                    item_Restock = (int)dr["Item_Restock"],
                    Alcohol_Check = (bool)dr["Alcohol_Check"]
                };
                Items.Add(item);
            }
            return Items;
        }
    }
}
