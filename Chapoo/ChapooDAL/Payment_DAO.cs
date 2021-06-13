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
            string query = $"INSERT INTO Payment VALUES (@order_id, @table_id, @payMethod_ID, @employee_ID, @comment, @payStatus_ID, @payment_time, @totalprice, @totalvat, @tip)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@order_id", SqlDbType.Int) { Value = payment.order.order_ID },
                new SqlParameter("@table_id", SqlDbType.Int) { Value = payment.table.table_ID },
                new SqlParameter("@payMethod_ID", SqlDbType.Int) { Value = ((int)payment.payMethod) },
                new SqlParameter("@employee_ID", SqlDbType.Int) { Value = payment.employee.employee_id },
                new SqlParameter("@comment", SqlDbType.NVarChar) {Value = payment.comment },
                new SqlParameter("@payStatus_ID", SqlDbType.Int) { Value = ((int)payment.payStatus) },
                new SqlParameter("@totalprice", SqlDbType.Money) { Value = payment.totalPrice },
                new SqlParameter("@totalvat", SqlDbType.Money) { Value = payment.totalVAT },
                new SqlParameter("@tip", SqlDbType.Money) { Value = payment.tip },
                new SqlParameter("@payment_time", SqlDbType.DateTime) { Value = payment.payment_DateTime }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public List<Payment> Db_Get_PaymentHistory(DateTime sD, DateTime eD)
        {

            string query = "SELECT p.Payment_ID, p.Table_ID, p.Payment_PayMethod, p.Employee_ID, p.Payment_Comment, p.Payment_PayStatus, p.Payment_VAT, p.Payment_Tip, p.Payment_DateTime, p.Payment_Total FROM Payment AS p WHERE Payment_DateTime  BETWEEN convert(datetime, '" + sD.Year + "/" + sD.Month + "/" + sD.Day + "') and convert(datetime, '" + eD.Year + "/" + eD.Month + "/" + eD.Day + "')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadPayment(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Payment> ReadPayment(DataTable dataTable)
        {
            Employee_DAO employee_DAO = new Employee_DAO();
            List<Payment> PaymentList = new List<Payment>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Payment payment = new Payment()
                {
                    payment_ID = (int)dr["Payment_ID"],
                    payMethod = (PayMethod)dr["Payment_PayMethod"],
                    employee = employee_DAO.DB_Get_Employee((int)dr["Employee_ID"]),
                    comment = (string)dr["Payment_Comment"],
                    payStatus = (PayStatus)dr["Payment_PayStatus"],
                    totalPrice = (decimal)dr["Payment_Total"],
                    totalVAT = (decimal)dr["Payment_VAT"],
                    tip = (decimal)dr["Payment_Tip"],
                    payment_DateTime = (DateTime)dr["Payment_DateTime"]

                };
                PaymentList.Add(payment);
            }
            return PaymentList;
        }
    }
}
