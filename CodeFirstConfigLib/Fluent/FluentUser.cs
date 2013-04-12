using System;
using System.Collections.Generic;

namespace CodeFirstConfigLib.Fluent
{
    public class FluentUser
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; }}

        public List<FluentOrder> Orders { get; set; }

        public FluentDrivingLicense DrivingLicense { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
