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
    public class Reservation_DAO : Base
    {
        public List<Reservation> DB_Get_Reservations()
        {
            string query = "SELECT Reservation.Reservation_ID, Reservation.Table_ID, Reservation.Customer_ID, Reservation.Reservation_DateTime FROM Reservation";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadReservations(ExecuteSelectQuery(query, sqlParameters));
        }

        public void DB_Add_Reservation(Reservation reservation)
        {
            string query = "INSERT INTO Reservation VALUES (@reservation_table_id, @reservation_customer_id, @reservation_datetime)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@reservation_table_id", SqlDbType.Int) { Value = reservation.Table.Table_ID },
                new SqlParameter("@reservation_customer_id", SqlDbType.Int) { Value = reservation.Customer.Customer_ID },
                new SqlParameter("@reservation_datetime", SqlDbType.Int) { Value = reservation.Reservation_DateTime }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DB_Remove_Reservation(Reservation reservation)
        {
            string query = "DELETE FROM Reser WHERE MenuItems.Item_ID = @reservation_id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@reservation_id", SqlDbType.Int) { Value = reservation.Reservation_ID }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DB_Update_Reservation(Reservation reservation)
        {
            string query = "UPDATE Reservation SET Reservation.Table_ID = @table_id, Reservation.Customer_ID = @customer_id, Reservation.Reservation_DateTime = @reservation_datetime WHERE Reservation.Reservation_ID = @reservation_id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@reservation_id", SqlDbType.Int) { Value = reservation.Reservation_ID },
                new SqlParameter("@table_id", SqlDbType.Int) { Value = reservation.Table.Table_ID },
                new SqlParameter("@customer_id", SqlDbType.Int) { Value = reservation.Customer.Customer_ID },
                new SqlParameter("@reservation_datetime", SqlDbType.Int) { Value = reservation.Reservation_DateTime }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Reservation> ReadReservations(DataTable dataTable)
        {
            DiningTable_DAO diningTable_DB = new DiningTable_DAO();
            Customer_DAO customer_DB = new Customer_DAO();
            List<Reservation> reservations = new List<Reservation>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Reservation reservation = new Reservation()
                {
                    Reservation_ID = (int)dr["Reservation_ID"],
                    Table = diningTable_DB.DB_Get_DiningTable((int)dr["Table_ID"]),
                    Customer = customer_DB.DB_Get_Customer((int)dr["Customer_ID"]),
                    Reservation_DateTime = (DateTime)dr["Reservation_DateTime"]
                };
                reservations.Add(reservation);
            }
            return reservations;
        }
    }
}
