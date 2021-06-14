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
    public class Customer_DAO : Base
    {
        public Customer DB_Get_Customer(int customer_id)
        {
            string query = "SELECT Customers.Customer_ID, Customers.Customer_Name, Customers.Phone_Number, Customers.Address FROM Customers WHERE Customers.Customer_ID = @id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", SqlDbType.Int) {Value = customer_id}
            };
            return ReadCustomer(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Customer> DB_Get_Customers()
        {
            string query = "SELECT Customers.Customer_ID, Customers.Customer_Name, Customers.Phone_Number, Customers.Address FROM Customers";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadCustomers(ExecuteSelectQuery(query, sqlParameters));
        }

        public void DB_Add_Customer(Customer customer)
        {
            string query = "INSERT INTO Customers VALUES (@customer_Name, @customer_phone, @customer_Address)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@customer_Name", SqlDbType.NVarChar) { Value = customer.Customer_Name },
                new SqlParameter("@customer_phone", SqlDbType.NVarChar) { Value = customer.Phone_Number },
                new SqlParameter("@customer_Address", SqlDbType.NVarChar) { Value = customer.Address }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DB_Delete_Customer(Customer customer)
        {
            string query = "DELETE FROM Customers WHERE Customers.Customer_ID = @id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", SqlDbType.Int) { Value = customer.Customer_ID }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DB_Update_Customer(Customer customer)
        {
            string query = "UPDATE Customers SET Customers.Customer_Name = @customer_name, Customers.Phone_Number = @customer_phone, Customers.Address = @customer_address WHERE Customers.Customer_ID = @customer_id)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@customer_id", SqlDbType.Int) { Value = customer.Customer_ID},
                new SqlParameter("@customer_name", SqlDbType.NVarChar) { Value = customer.Customer_Name },
                new SqlParameter("@customer_phone", SqlDbType.NVarChar) { Value = customer.Phone_Number },
                new SqlParameter("@customer_address", SqlDbType.NVarChar) { Value = customer.Address }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private Customer ReadCustomer(DataTable dataTable)
        {
            Customer customer = new Customer();

            foreach (DataRow dr in dataTable.Rows)
            {
                customer.Customer_ID = (int)dr["Customer_ID"];
                customer.Customer_Name = (string)dr["Customer_Name"];
                customer.Phone_Number = (string)dr["Phone_Number"];
                customer.Address = (string)dr["Address"];
            }
            return customer;
        }

        private List<Customer> ReadCustomers(DataTable dataTable)
        {
            List<Customer> customers = new List<Customer>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Customer customer = new Customer()
                {
                    Customer_ID = (int)dr["Customer_ID"],
                    Customer_Name = (string)dr["Customer_Name"],
                    Phone_Number = (string)dr["Phone_Number"],
                    Address = (string)dr["Address"]
                };
                customers.Add(customer);
            }
            return customers;
        }



    }
}
