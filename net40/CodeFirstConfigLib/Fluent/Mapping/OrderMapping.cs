using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstConfigLib.Fluent.Mapping
{
    public class OrderMapping: EntityTypeConfigurationBase<FluentOrder>
    {
        public OrderMapping()
        {
            HasKey(x => x.OrderId);
            HasRequired(x => x.User).WithMany(x=>x.Orders);

            HasMany(x=>x.Products).WithMany(y=>y.Orders).Map(c =>
                {
                    c.ToTable("ProductOrder");
                    c.MapLeftKey("OrderId");
                    c.MapRightKey("ProductId");
                });

            ToTable("Order");
        }
    }
}
