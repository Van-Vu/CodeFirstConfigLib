using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace CodeFirstConfigLib.DataAnnotation
{
    [Table("User")]
    public class DANationality
    {
        [Key]
        [ForeignKey("User")]
        public int UserId { get; set; }

        [Column("NationalityName")]
        public string Name { get; set; }

        public DAUser User { get; set; }
    }
}
