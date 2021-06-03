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
            string query = "SELECT Employees.Employee_ID, Employees.Position_ID, Employees.Employee_Name, Employees.Employee_Address, Employees.Employee_Phone, Employees.Employee_Pincode FROM Employees WHERE Employee_ID = @id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", SqlDbType.Int) {Value = customer_id}
            };
            return ReadCustomer(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Customer> DB_Get_Customers()
        {
            string query = "SELECT Employees.Employee_ID, Employees.Position_ID, Employees.Employee_Name, Employees.Employee_Address, Employees.Employee_Phone, Employees.Employee_Pincode FROM Employees";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadCustomers(ExecuteSelectQuery(query, sqlParameters));
        }

        public void DB_Add_Customer(Customer customer)
        {
            string query = "INSERT INTO Employees VALUES (@Employee_ID, @Position_ID, @Employee_Name, @Employee_Address, @Employee_Phone, @Employee_Pincode)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@customer_Name", SqlDbType.NVarChar) { Value = customer.customer_Name },
                new SqlParameter("@customer_phone", SqlDbType.NVarChar) { Value = customer.phone_Number },
                new SqlParameter("@customer_Address", SqlDbType.NVarChar) { Value = customer.address }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DB_Delete_Customer(Customer customer)
        {
            string query = "DELETE FROM Employees WHERE Employees.Employee_ID = @id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", SqlDbType.Int) { Value = employee.employee_id }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DB_Update_Customer(Employee employee)
        {
            string query = "UPDATE Employees SET Employee_ID = @Employee_ID, Position_ID = @Position_ID, Employee_Name = @Employee_Name, Employee_Address = @Employee_Address, Employee_Phone = @Employee_Phone, Employee_Pincode = @Employee_Pincode)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Employee_ID", SqlDbType.Int) { Value = employee.employee_id },
                new SqlParameter("@Position_ID", SqlDbType.Int) { Value = ((int)employee.position) },
                new SqlParameter("@Employee_Name", SqlDbType.Int) { Value = employee.name },
                new SqlParameter("@Employee_Address", SqlDbType.Int) { Value = employee.adres },
                new SqlParameter("@Employee_Phone", SqlDbType.Int) { Value = employee.phone },
                new SqlParameter("@Employee_Pincode", SqlDbType.Int) { Value = employee.pin }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private Customer ReadCustomer(DataTable dataTable)
        {
            Employee employee = new Employee();

            foreach (DataRow dr in dataTable.Rows)
            {
                employee.employee_id = (int)dr["Employee_ID"];
                employee.position = (Position)((int)dr["Position_ID"]);
                employee.name = (string)dr["Employee_Name"];
                employee.adres = (string)dr["Employee_Address"];
                employee.phone = (string)dr["Employee_Phone"];
                //employee.pin = (string)dr["Employee_Pincode"]; // later als employees pincodes hebben en login form aanwezig is
            }
            return employee;
        }

        private List<Customer> ReadCustomers(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Employee employee = new Employee()
                {
                    employee_id = (int)dr["Employee_ID"],
                    position = (Position)((int)dr["Position_ID"]),
                    name = (string)dr["Employee_Name"],
                    adres = (string)dr["Employee_Address"],
                    phone = (string)dr["Employee_Phone"],
                    //pin = (string)dr["Employee_Pincode"] // later als employees pincodes hebben en login form aanwezig is
                };
                employees.Add(employee);
            }
            return employees;
        }



    }
}
