using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstConfigLib.DataAnnotation
{
    public class DAProductInStock : DAProduct
    {
        public int Remaining { get; set; }
        public string Notes { get; set; }
    }
}
