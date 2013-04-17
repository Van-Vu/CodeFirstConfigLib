using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CodeFirstConfigLib.DataAnnotation.Infrastructure;

namespace CodeFirstConfigLib.DataAnnotation
{
    [Table("User")]
    public class DAUser
    {
        [Key]
        public int UserIdentity { get; set; }

        [Column("Firstname")]
        public string FirstName { get; set; }
        [Column("Lastname")]
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; }}

        [NotMapped]
        public string NotMapThis { get; set; }

        public List<DAOrder> Orders { get; set; }

        public DADrivingLicense DrivingLicense { get; set; }

        [Required]
        public DANationality Nationality { get; set; }

        // [InverseProperty("PrimaryContactForUsers")]
        public DAContact PrimaryContact { get; set; }
        // [InverseProperty("SecondaryContactForUsers")]
        public DAContact SecondaryContact { get; set; }


        public ICollection<DAReservation> Reservations { get; set; }

        [ConcurrencyCheck]
        public DateTime UpdatedDate { get; set; }
    }
}
