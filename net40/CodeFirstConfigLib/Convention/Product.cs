using System.Collections.Generic;
using CodeFirstConfigLib.Fluent;

namespace CodeFirstConfigLib.Convention
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
