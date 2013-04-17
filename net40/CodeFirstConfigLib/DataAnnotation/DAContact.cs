using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstConfigLib.DataAnnotation
{
    [Table("Contact")]
    public class DAContact
    {
        [Key]
        public int ContactId { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }

        public IEnumerable<DAUser> PrimaryContactForUsers { get; set; }
        public IEnumerable<DAUser> SecondaryContactForUsers { get; set; }
    }
}
