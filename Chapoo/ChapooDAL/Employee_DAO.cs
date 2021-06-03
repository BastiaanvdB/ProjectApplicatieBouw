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
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private Employee ReadTables(DataTable dataTable)
        {
            Employee employee = new Employee();

            foreach (DataRow dr in dataTable.Rows)
            {
                employee.employee_id = (int)dr["Employee_ID"]; 
                employee.position = (Position)((int)dr["Position_ID"]);
                employee.name = (string)dr["Employee_Name"];
                employee.adres = (string)dr["Employee_Address"];
                employee.phone = (string)dr["Employee_Phone"];
                //employee.pin = (string)dr["Employee_Pincode"];
            }
            return employee;
        }
    }

}

