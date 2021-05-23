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
    public class Payment_DAO : Base
    {
        public void DB_Create_Payment(Payment payment)
        {
            string query = $"INSERT INTO Payment";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@order_id", SqlDbType.Int) { Value = payment.order_ID },
                new SqlParameter("@table_id", SqlDbType.Int) { Value = payment.table_ID },
                new SqlParameter("@payMethod_ID", SqlDbType.Int) { Value = payment.payMethod_ID },
                new SqlParameter("@payStatus_ID", SqlDbType.Int) { Value = payment.payStatus_ID },
                new SqlParameter("@totalprice", SqlDbType.Money) { Value = payment.totalPrice },
                new SqlParameter("@totalvat", SqlDbType.Money) { Value = payment.totalVAT },
                new SqlParameter("@tip", SqlDbType.Money) { Value = payment.tip },
                new SqlParameter("@payment_time", SqlDbType.DateTime) { Value = payment.payment_DateTime }
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
