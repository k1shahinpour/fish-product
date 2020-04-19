using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("damage_head")]
    public partial class DamageHead
    {
        [Key]
        [Column("d_id")]
        [StringLength(20)]
        public string DId { get; set; }
        [Column("d_date", TypeName = "date")]
        public DateTime DDate { get; set; }
        [Column("totalprice", TypeName = "numeric(12, 3)")]
        public decimal Totalprice { get; set; }
        [Column("pos_id")]
        public int? PosId { get; set; }
    }
}
