using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("expense")]
    public partial class Expense
    {
        [Key]
        [Column("exp_id")]
        public int ExpId { get; set; }
        [Required]
        [Column("exp_name")]
        [StringLength(40)]
        public string ExpName { get; set; }
        [Column("exp_date", TypeName = "date")]
        public DateTime ExpDate { get; set; }
        [Column("nam_ara")]
        [StringLength(40)]
        public string NamAra { get; set; }
    }
}
