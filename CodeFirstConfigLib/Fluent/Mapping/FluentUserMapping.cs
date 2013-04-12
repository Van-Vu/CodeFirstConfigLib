using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstConfigLib.Fluent.Mapping
{
    public class FluentUserMapping: EntityTypeConfigurationBase<FluentUser>
    {
        public FluentUserMapping()
        {
            HasKey(x => x.UserId);
            
            //Property(x => x.CreatedDate).HasDatabaseGeneratedOption()
        }
    }
}
