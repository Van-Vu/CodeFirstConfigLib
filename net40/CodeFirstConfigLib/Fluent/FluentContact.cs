using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstConfigLib.Fluent
{
    public class FluentContact
    {
        public int ContactId { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }

        public IEnumerable<FluentUser> PrimaryContactForUsers { get; set; }
        public IEnumerable<FluentUser> SecondaryContactForUsers { get; set; }
    }
}
