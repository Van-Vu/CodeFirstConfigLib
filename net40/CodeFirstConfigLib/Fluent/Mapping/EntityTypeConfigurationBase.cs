using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace CodeFirstConfigLib.Fluent.Mapping
{
    public class EntityTypeConfigurationBase<T> : EntityTypeConfiguration<T> where T : class
    {
    }
}
