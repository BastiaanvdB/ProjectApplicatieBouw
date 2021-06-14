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
                new SqlParameter("@order_id", SqlDbType.Int) { Value = payment.Order.order_ID },
                new SqlParameter("@table_id", SqlDbType.Int) { Value = payment.Table.Table_ID },
                new SqlParameter("@payMethod_ID", SqlDbType.Int) { Value = ((int)payment.PayMethod) },
                new SqlParameter("@employee_ID", SqlDbType.Int) { Value = payment.Employee.Employee_id },
                new SqlParameter("@comment", SqlDbType.NVarChar) {Value = payment.Comment },
                new SqlParameter("@payStatus_ID", SqlDbType.Int) { Value = ((int)payment.PayStatus) },
                new SqlParameter("@totalprice", SqlDbType.Money) { Value = payment.TotalPrice },
                new SqlParameter("@totalvat", SqlDbType.Money) { Value = payment.TotalVAT },
                new SqlParameter("@tip", SqlDbType.Money) { Value = payment.Tip },
                new SqlParameter("@payment_time", SqlDbType.DateTime) { Value = payment.Payment_DateTime }
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
                    Payment_ID = (int)dr["Payment_ID"],
                    PayMethod = (PayMethod)dr["Payment_PayMethod"],
                    Employee = employee_DAO.DB_Get_Employee((int)dr["Employee_ID"]),
                    Comment = (string)dr["Payment_Comment"],
                    PayStatus = (PayStatus)dr["Payment_PayStatus"],
                    TotalPrice = (decimal)dr["Payment_Total"],
                    TotalVAT = (decimal)dr["Payment_VAT"],
                    Tip = (decimal)dr["Payment_Tip"],
                    Payment_DateTime = (DateTime)dr["Payment_DateTime"]

                };
                PaymentList.Add(payment);
            }
            return PaymentList;
        }
    }
}
