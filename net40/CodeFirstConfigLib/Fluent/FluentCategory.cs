using System;

namespace CodeFirstConfigLib.Fluent
{
    public class FluentCategory
    {
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
