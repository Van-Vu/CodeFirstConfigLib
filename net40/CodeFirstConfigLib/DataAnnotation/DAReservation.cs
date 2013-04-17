using System;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstConfigLib.DataAnnotation
{
    public class DAReservation
    {
        [Key]
        public int ReservationId { get; set; }
        public DateTime DateTimeMade { get; set; }
        public DAUser Traveler { get; set; }
        public DateTime PaidInFull { get; set; }
    }
}
