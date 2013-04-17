using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstConfigLib.Fluent
{
    public class FluentProductInStock: FluentProduct
    {
        public int Remaining { get; set; }
        public string Notes { get; set; }
    }
}
