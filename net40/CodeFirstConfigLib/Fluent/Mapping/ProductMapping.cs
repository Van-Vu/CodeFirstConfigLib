using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstConfigLib.Fluent.Mapping
{
    public class ProductMapping : EntityTypeConfigurationBase<FluentProduct>
    {
        public ProductMapping()
        {
            HasKey(x => x.ProductId);
            //HasRequired(x => x.Category);
            //Property(x => x.ProductTypeEnum);

            Map<FluentProduct>(x =>
                {
                    x.ToTable("Product");
                    x.Requires("FromEntity").HasValue("ProductEntity");
                })
                .Map<FluentProductInStock>(x => x.Requires("FromEntity").HasValue("ProductInStockEntity"))
                .Map<FluentProductOutOfStock>(x => x.Requires("FromEntity").HasValue("ProductOutOfStockEntity"));
            //ToTable("Product");
        }
    }
}
