using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstConfigLib.Fluent.Mapping
{
    public class ReservationMapping:EntityTypeConfigurationBase<FluentReservation>
    {
        public ReservationMapping()
        {
            HasKey(x => x.ReservationId);

            HasRequired(x=>x.Traveler).WithMany(x=>x.Reservations).WillCascadeOnDelete(true);
            
            ToTable("Reservation");
        }
    }
}
