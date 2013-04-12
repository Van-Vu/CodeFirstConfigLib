using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstConfigLib.DataAnnotation
{
    public class DAOrder
    {
        [Key]
        public int OrderIdentity { get; set; }
        public DateTime OrderedDate { get; set; }

        public ICollection<DAProduct> Products { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public DAUser User { get; set; }
    }
}
