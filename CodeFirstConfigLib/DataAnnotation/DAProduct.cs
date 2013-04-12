using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstConfigLib.DataAnnotation
{
    public class DAProduct
    {
        [Key]
        public int ProductIdentity { get; set; }
        [MaxLength(200)]
        public string ProductName { get; set; }

        public ICollection<DAOrder> Orders { get; set; }
        public DACategory Category { get; set; }
    }
}
