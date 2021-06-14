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
                new SqlParameter("@Position_ID", SqlDbType.Int) { Value = ((int)employee.Position) },
                new SqlParameter("@Employee_Name", SqlDbType.NVarChar) { Value = employee.Name },
                new SqlParameter("@Employee_Address", SqlDbType.NVarChar) { Value = employee.Adres },
                new SqlParameter("@Employee_Phone", SqlDbType.NVarChar) { Value = employee.Phone },
                new SqlParameter("@Employee_Pincode", SqlDbType.NVarChar) { Value = employee.Pin }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DB_Delete_Employee(Employee employee)
        {
            string query = "DELETE FROM Employees WHERE Employees.Employee_ID = @id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", SqlDbType.Int) { Value = employee.Employee_id }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DB_Update_Employee(Employee employee)
        {
            string query = "UPDATE Employees SET Position_ID = @PositionID, Employee_Name = @EmployeeName, Employee_Address = @EmployeeAddress, Employee_Phone = @EmployeePhone, Employee_Pincode = @EmployeePincode WHERE Employee_ID = @EmployeeID";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = employee.Employee_id },
                new SqlParameter("@PositionID", SqlDbType.Int) { Value = ((int)employee.Position) },
                new SqlParameter("@EmployeeName", SqlDbType.NVarChar) { Value = employee.Name },
                new SqlParameter("@EmployeeAddress", SqlDbType.NVarChar) { Value = employee.Adres },
                new SqlParameter("@EmployeePhone", SqlDbType.NVarChar) { Value = employee.Phone },
                new SqlParameter("@EmployeePincode", SqlDbType.NVarChar) { Value = employee.Pin }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private Employee ReadEmployee(DataTable dataTable)
        {
            Employee employee = new Employee();

            foreach (DataRow dr in dataTable.Rows)
            {
                employee.Employee_id = (int)dr["Employee_ID"]; 
                employee.Position = (Position)((int)dr["Position_ID"]);
                employee.Name = (string)dr["Employee_Name"];
                employee.Adres = (string)dr["Employee_Address"];
                employee.Phone = (string)dr["Employee_Phone"];
                employee.Pin = (string)dr["Employee_Pincode"];
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
                    Employee_id = (int)dr["Employee_ID"],
                    Position = (Position)((int)dr["Position_ID"]),
                    Name = (string)dr["Employee_Name"],
                    Adres = (string)dr["Employee_Address"],
                    Phone = (string)dr["Employee_Phone"],
                    Pin = (string)dr["Employee_Pincode"]
                };
                employees.Add(employee);
            }
            return employees;
        }
    }

}

