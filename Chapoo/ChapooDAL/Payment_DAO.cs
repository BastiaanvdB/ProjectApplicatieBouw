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
            string query = $"INSERT INTO Payment VALUES (@order_id, @table_id, @payMethod_ID, @employee_ID, @payStatus_ID, @payment_time, @totalprice, @totalvat, @tip)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@order_id", SqlDbType.Int) { Value = payment.order.order_ID },
                new SqlParameter("@table_id", SqlDbType.Int) { Value = payment.table.table_ID },
                new SqlParameter("@payMethod_ID", SqlDbType.Int) { Value = ((int)payment.payMethod) },
                new SqlParameter("@employee_ID", SqlDbType.Int) { Value = payment.employee.employee_id },
                new SqlParameter("@payStatus_ID", SqlDbType.Int) { Value = ((int)payment.payStatus) },
                new SqlParameter("@totalprice", SqlDbType.Money) { Value = payment.totalPrice },
                new SqlParameter("@totalvat", SqlDbType.Money) { Value = payment.totalVAT },
                new SqlParameter("@tip", SqlDbType.Money) { Value = payment.tip },
                new SqlParameter("@payment_time", SqlDbType.DateTime) { Value = payment.payment_DateTime }
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
