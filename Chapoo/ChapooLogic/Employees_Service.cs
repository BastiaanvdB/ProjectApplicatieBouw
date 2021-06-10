using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class Employees_Service
    {
        private Employee_DAO Employee_DB = new Employee_DAO();

        public Employee DB_Get_Employee(int employee_id)
        {
            return Employee_DB.DB_Get_Employee(employee_id);
        }

        public List<Employee> DB_Get_Employees()
        {
            return Employee_DB.DB_Get_Employees();
        }

        public void DB_Update_Employee(Employee employee)
        {
            Employee_DB.DB_Update_Employee(employee);
        }

        public void DB_Delete_Employee(Employee employee)
        {
            Employee_DB.DB_Delete_Employee(employee);
        }

        public void DB_Add_Employee(Employee employee)
        {
            Employee_DB.DB_Add_Employee(employee);
        }
    }
}
