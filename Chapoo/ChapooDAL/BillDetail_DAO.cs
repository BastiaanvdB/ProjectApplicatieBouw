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
    public class BillDetail_DAO : Base
    {
        public List<BillDetail> DB_Get_All_Ordered_Items(int order_ID)
        {
            string query = "SELECT o.Order_ID, g.MenuGroup_Name, i.Item_ID, i.Item_Name, o.OrderDetails_Quantity, i.Item_Price, i.Item_Price*o.OrderDetails_Quantity as OrderDetails_Total FROM OrderDetails AS o INNER JOIN MenuItems AS i ON o.Item_ID = i.Item_ID INNER JOIN MenuGroup AS g ON i.MenuGroup_ID = g.MenuGroup_ID WHERE o.Order_ID = @id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", SqlDbType.Int) {Value = order_ID}
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<BillDetail> ReadTables(DataTable dataTable)
        {
            List<BillDetail> billDetails = new List<BillDetail>();
            foreach (DataRow dr in dataTable.Rows)
            {
                BillDetail billDetail = new BillDetail()
                {
                    order_ID = (int)dr["Order_ID"],
                    menuGroup = (string)dr["MenuGroup_Name"],
                    menuItem_ID = (int)dr["Item_ID"],
                    menuItem_Name = (string)dr["Item_Name"],
                    quantity = (int)dr["OrderDetails_Quantity"],
                    item_price = (decimal)dr["Item_Price"],
                    totalPrice = (decimal)dr["OrderDetails_Total"]
                };
                billDetails.Add(billDetail);
            }
            return billDetails;
        }
    }
}
