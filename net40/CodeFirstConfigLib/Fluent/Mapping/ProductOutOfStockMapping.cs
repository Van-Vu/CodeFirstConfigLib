using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstConfigLib.Fluent.Mapping
{
    public class ProductOutOfStockMapping:EntityTypeConfigurationBase<FluentProductOutOfStock>
    {
        public ProductOutOfStockMapping()
        {
            //ToTable("ProductOutOfStock");
        }
    }
}
