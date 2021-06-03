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
    public class Employee_DAO : Base
    {
        public Employee DB_Get_Employee(int employee_id)
        {
            string query = "SELECT Employees.Employee_ID, Employees.Position_ID, Employees.Employee_Name, Employees.Employee_Address, Employees.Employee_Phone, Employees.Employee_Pincode FROM Employees WHERE Employee_ID = @id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", SqlDbType.Int) {Value = employee_id}
            };
            return ReadEmployee(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Employee> DB_Get_Employees()
        {
            string query = "SELECT Employees.Employee_ID, Employees.Position_ID, Employees.Employee_Name, Employees.Employee_Address, Employees.Employee_Phone, Employees.Employee_Pincode FROM Employees WHERE Employee_ID = @id";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadEmployees(ExecuteSelectQuery(query, sqlParameters));
        }

        public void DB_Add_Employee(MenuItem menuItem)
        {
            string query = "INSERT";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", SqlDbType.Int) { Value = menuItem.item_ID }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DB_Delete_Employee(MenuItem menuItem)
        {
            string query = "DELETE FROM MenuItems WHERE MenuItems.Item_ID = @id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", SqlDbType.Int) { Value = menuItem.item_ID }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DB_Update_Employee(MenuItem menuItem)
        {
            string query = "UPDATE";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", SqlDbType.Int) { Value = menuItem.item_ID }
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
                //employee.pin = (string)dr["Employee_Pincode"]; // later als employees pincodes hebben en login form aanwezig is
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
                    //pin = (string)dr["Employee_Pincode"] // later als employees pincodes hebben en login form aanwezig is
                };
                employees.Add(employee);
            }
            return employees;
        }
    }

}

