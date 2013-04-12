using System.Collections.Generic;

namespace CodeFirstConfigLib.Fluent
{
    public class FluentProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public ICollection<FluentOrder> Orders { get; set; }
    }
}
