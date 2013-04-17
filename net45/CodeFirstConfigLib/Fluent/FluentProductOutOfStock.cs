using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstConfigLib.Fluent
{
    public class FluentProductOutOfStock: FluentProduct
    {
        public DateTime LastDate { get; set; }
    }
}
