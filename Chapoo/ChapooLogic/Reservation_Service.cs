using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class Reservation_Service
    {
        private Reservation_DAO Reservation_DB = new Reservation_DAO();

        public List<Reservation> DB_Get_Reservations()
        {
            return Reservation_DB.DB_Get_Reservations();
        }

        public void DB_Add_Reservation(Reservation reservation)
        {
            Reservation_DB.DB_Add_Reservation(reservation);
        }

        public void DB_Remove_Reservation(Reservation reservation)
        {
            Reservation_DB.DB_Remove_Reservation(reservation);
        }

        public void DB_Update_Reservation(Reservation reservation)
        {
            Reservation_DB.DB_Update_Reservation(reservation);
        }
    }
}
