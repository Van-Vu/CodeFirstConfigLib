using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstConfigLib.DataAnnotation
{
    [Table("DrivingLicense")]
    public class DADrivingLicense
    {
        [Key]
        [ForeignKey("User")]
        public int UserIdentity { get; set; }
        public string LicenseId { get; set; }
        public DateTime AvailableDate { get; set; }
        public DateTime ExpiredDate { get; set; }

        public DAUser User { get; set; }
    }
}
