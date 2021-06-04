using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class Customer_Service
    {
        private Customer_DAO Customer_DB = new Customer_DAO();


        public void DB_Add_Customer(Customer customer)
        {
            Customer_DB.DB_Add_Customer(customer);
        }

        public void DB_Delete_Customer(Customer customer)
        {
            Customer_DB.DB_Delete_Customer(customer);
        }

        public void DB_Update_Customer(Customer customer)
        {
            Customer_DB.DB_Update_Customer(customer);
        }

        public Customer DB_Get_Customer(int customer_id)
        {
            return Customer_DB.DB_Get_Customer(customer_id);
        }

        public List<Customer> DB_Get_Customers()
        {
            return Customer_DB.DB_Get_Customers();
        }
    }
}
