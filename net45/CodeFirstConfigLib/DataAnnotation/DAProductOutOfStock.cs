using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace CodeFirstConfigLib.DataAnnotation
{
    [Table("ProductOutOfStock")]
    public class DAProductOutOfStock: DAProduct
    {
        public DateTime LastDate { get; set; }
    }
}
