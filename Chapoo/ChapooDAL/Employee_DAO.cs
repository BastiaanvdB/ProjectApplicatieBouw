using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ChapooModel;

namespace ChapooDAL
{
    public class Employee_DAO : Base
    {
        public Employee DB_Get_Employee(int employee_id)
        {
            string query = "SELECT Employees.Employee_ID, Employees.Position_ID, Employees.Employee_Name, Employees.Employee_Address, Employees.Employee_Phone, Employees.Employee_Pincode FROM Employees WHERE Employees.Employee_ID = @id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", SqlDbType.Int) {Value = employee_id}
            };
            return ReadEmployee(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Employee> DB_Get_Employees()
        {
            string query = "SELECT Employees.Employee_ID, Employees.Position_ID, Employees.Employee_Name, Employees.Employee_Address, Employees.Employee_Phone, Employees.Employee_Pincode FROM Employees";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadEmployees(ExecuteSelectQuery(query, sqlParameters));
        }

        public void DB_Add_Employee(Employee employee)
        {
            string query = "INSERT INTO Employees VALUES (@Position_ID, @Employee_Name, @Employee_Address, @Employee_Phone, @Employee_Pincode)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Position_ID", SqlDbType.Int) { Value = ((int)employee.position) },
                new SqlParameter("@Employee_Name", SqlDbType.Int) { Value = employee.name },
                new SqlParameter("@Employee_Address", SqlDbType.Int) { Value = employee.adres },
                new SqlParameter("@Employee_Phone", SqlDbType.Int) { Value = employee.phone },
                new SqlParameter("@Employee_Pincode", SqlDbType.Int) { Value = employee.pin }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DB_Delete_Employee(Employee employee)
        {
            string query = "DELETE FROM Employees WHERE Employees.Employee_ID = @id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", SqlDbType.Int) { Value = employee.employee_id }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DB_Update_Employee(Employee employee)
        {
            string query = "UPDATE Employees SET Employees.Position_ID = @Position_ID, Employees.Employee_Name = @Employee_Name, Employees.Employee_Address = @Employee_Address, Employees.Employee_Phone = @Employee_Phone, Employees.Employee_Pincode = @Employee_Pincode WHERE Employees.Employee_ID = @Employee_ID)";
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

        private Employee ReadEmployee(DataTable dataTable)
        {
            Employee employee = new Employee();

            foreach (DataRow dr in dataTable.Rows)
            {
                employee.employee_id = (int)dr["Employee_ID"]; 
                employee.position = (Position)((int)dr["Position_ID"]);
                employee.name = (string)dr["Employee_Name"];
                employee.adres = (string)dr["Employee_Address"];
                employee.phone = (string)dr["Employee_Phone"];
                employee.pin = (string)dr["Employee_Pincode"];
            }
            return employee;
        }

        private List<Employee> ReadEmployees(DataTable dataTable)
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
                    pin = (string)dr["Employee_Pincode"]
                };
                employees.Add(employee);
            }
            return employees;
        }
    }

}

