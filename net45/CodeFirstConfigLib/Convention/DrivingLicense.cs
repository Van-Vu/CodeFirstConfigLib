using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstConfigLib.Convention
{
    public class DrivingLicense
    {
        [Key]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public string LicenseId { get; set; }
        public DateTime AvailableDate { get; set; }
        public DateTime ExpiredDate { get; set; }

        public User User { get; set; }
    }
}
