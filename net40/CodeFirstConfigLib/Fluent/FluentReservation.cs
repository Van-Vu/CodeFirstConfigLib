using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstConfigLib.Fluent
{
    public class FluentReservation
    {
        public int ReservationId { get; set; }
        public DateTime DateTimeMade { get; set; }
        public FluentUser Traveler { get; set; }
        public DateTime PaidInFull { get; set; }
    }
}
