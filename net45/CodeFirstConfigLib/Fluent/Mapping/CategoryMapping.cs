using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace CodeFirstConfigLib.Fluent.Mapping
{
    public class CategoryMapping: EntityTypeConfigurationBase<FluentCategory>
    {
        public CategoryMapping()
        {
            HasKey(x => x.CategoryId);
            Property(x => x.CategoryId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.RowVersion).IsRowVersion();

            ToTable("Category");
        }
    }
}
