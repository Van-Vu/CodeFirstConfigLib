using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstConfigLib.DataAnnotation
{
    [Table("Product")]
    public class DAProduct
    {
        [Key]
        public int ProductIdentity { get; set; }
        [MaxLength(200)]
        public string ProductName { get; set; }

        public ICollection<DAOrder> Orders { get; set; }

        // 1:
        //[ForeignKey("Category")]
        //public int CategoryId { get; set; }
        //public DACategory Category { get; set; }

        // 2:
        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public DACategory Category { get; set; }
    }
}
