using System;
using System.Collections.Generic;

namespace CodeFirstConfigLib.Convention
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; }}

        public List<Order> Orders { get; set; }

        public DrivingLicense DrivingLicense { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
