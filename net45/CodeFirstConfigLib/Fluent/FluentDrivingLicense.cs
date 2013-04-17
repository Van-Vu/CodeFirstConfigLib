using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CodeFirstConfigLib.Convention;

namespace CodeFirstConfigLib.Fluent
{
    public class FluentDrivingLicense
    {
        public int UserId { get; set; }
        public DateTime AvailableDate { get; set; }
        public DateTime ExpiredDate { get; set; }

        public FluentUser User { get; set; }
    }
}
