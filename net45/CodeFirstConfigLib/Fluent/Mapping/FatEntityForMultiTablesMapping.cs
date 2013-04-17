using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstConfigLib.Fluent.Mapping
{
    public class FatEntityForMultiTablesMapping: EntityTypeConfigurationBase<FatEntityForMultiTables>
    {
        public FatEntityForMultiTablesMapping()
        {
            HasKey(x => x.FatEntityId);
            Map(c =>
                {
                    c.Properties(x => x.Table1);
                    c.ToTable("Table1");
                });
            Map(c =>
            {
                c.Properties(x => x.Table2);
                c.ToTable("Table2");
            });
            Map(c =>
            {
                c.Properties(x => x.Table3);
                c.ToTable("Table3");
            });

        }
    }
}
