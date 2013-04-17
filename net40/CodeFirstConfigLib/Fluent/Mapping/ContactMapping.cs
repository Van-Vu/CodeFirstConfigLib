using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstConfigLib.Fluent.Mapping
{
    public class ContactMapping: EntityTypeConfigurationBase<FluentContact>
    {
        public ContactMapping()
        {
            HasKey(x => x.ContactId);

            ToTable("Contact");
        }
    }
}
