using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CodeFirstConfigLib.Fluent
{
    public class FatEntityForMultiTables
    {
        public int FatEntityId { get; set; }
        public string Table1 { get; set; }
        public string Table2 { get; set; }
        public string Table3 { get; set; }
    }
}
