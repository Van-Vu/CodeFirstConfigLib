using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstConfigLib.Convention
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderedDate { get; set; }
        
        public ICollection<Product> Products { get; set; }

        // This property will force the FK column name to be UserId. Otherwise, it's User_UserId
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
