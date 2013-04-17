using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstConfigLib.Fluent.Mapping
{
    public class NationalityMapping: EntityTypeConfigurationBase<FluentNationality>
    {
        public NationalityMapping()
        {
            HasKey(x => x.UserIdentity);
            Property(x => x.Name).HasColumnName("NationalityName");

            ToTable("User");
        }
    }
}
