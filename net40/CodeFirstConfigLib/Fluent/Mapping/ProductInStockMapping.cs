using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstConfigLib.Fluent.Mapping
{
    public class ProductInStockMapping: EntityTypeConfigurationBase<FluentProductInStock>
    {
        public ProductInStockMapping()
        {
            Property(x => x.Remaining).HasColumnName("RemainingFromProdInStock");
            Property(x => x.Notes).HasColumnName("NotesFromProdInStock");
        }
    }
}
