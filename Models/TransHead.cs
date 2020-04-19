using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("trans_head")]
    public partial class TransHead
    {
        [Key]
        [Column("trans_id")]
        [StringLength(20)]
        public string TransId { get; set; }
        [Column("trans_date", TypeName = "date")]
        public DateTime TransDate { get; set; }
        [Column("totalprice", TypeName = "numeric(12, 3)")]
        public decimal Totalprice { get; set; }
        [Column("store_recev_id")]
        public int? StoreRecevId { get; set; }
        [Column("pos_id")]
        public int? PosId { get; set; }
    }
}
