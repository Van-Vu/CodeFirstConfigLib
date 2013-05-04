using System;
using System.Collections.Generic;

namespace CodeFirstConfigLib.Fluent
{
    public class FluentUser
    {
        public int UserIdentity { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; }}

        public string NotMapThis { get; set; }

        public List<FluentOrder> Orders { get; set; }

        public FluentDrivingLicense DrivingLicense { get; set; }

        public FluentNationality Nationality { get; set; }

        // [InverseProperty("PrimaryContactForUsers")]
        public FluentContact PrimaryContact { get; set; }
        // [InverseProperty("SecondaryContactForUsers")]
        public FluentContact SecondaryContact { get; set; }

        public ICollection<FluentReservation> Reservations { get; set; }

        public DateTime UpdatedDate { get; set; }

        public string NewProperty { get; set; }

    }
}
