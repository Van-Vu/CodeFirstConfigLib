using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstConfigLib.DataAnnotation
{
    [Table("Category")]
    public class DACategory
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
