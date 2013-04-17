using System;
using System.Collections.Generic;
using CodeFirstConfigLib.Convention;

namespace CodeFirstConfigLib.Fluent
{
    public class FluentOrder
    {
        public int OrderId { get; set; }
        public DateTime OrderedDate { get; set; }

        public ICollection<FluentProduct> Products { get; set; }

        // This property will force the FK column name to be UserId. Otherwise, it's User_UserId
        public int UserId { get; set; }

        public FluentUser User { get; set; }
    }
}
