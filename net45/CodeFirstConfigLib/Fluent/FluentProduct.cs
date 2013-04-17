using System;
using System.Collections.Generic;

namespace CodeFirstConfigLib.Fluent
{
    public class FluentProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public ProductTypeEnum ProductTypeEnum { get; set; }

        public ICollection<FluentOrder> Orders { get; set; }

        public Guid CategoryId { get; set; }
        
        public FluentCategory Category { get; set; }
    }
}
