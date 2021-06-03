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

        public void DB_Add_MenuItem(MenuItem menuItem)
        {
            string query = "INSERT";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", SqlDbType.Int) { Value = menuItem.item_ID }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DB_Remove_MenuItem(MenuItem menuItem)
        {
            string query = "DELETE FROM MenuItems WHERE MenuItems.Item_ID = @id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", SqlDbType.Int) { Value = menuItem.item_ID }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DB_Update_MenuItem(MenuItem menuItem)
        {
            string query = "UPDATE";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", SqlDbType.Int) { Value = menuItem.item_ID }
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
