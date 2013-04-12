using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstConfigLib.DataAnnotation
{
    public class DAUser
    {
        [Key]
        public int UserIdentity { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; }}

        public List<DAOrder> Orders { get; set; }

        public DADrivingLicense DrivingLicense { get; set; }

        [ConcurrencyCheck]
        public DateTime UpdatedDate { get; set; }
    }
}
