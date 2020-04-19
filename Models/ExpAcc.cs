using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("exp_acc")]
    public partial class ExpAcc
    {
        [Key]
        [Column("acc_id")]
        [StringLength(20)]
        public string AccId { get; set; }
        [Column("exp_id")]
        public int ExpId { get; set; }
        [Column("amount", TypeName = "numeric(18, 3)")]
        public decimal? Amount { get; set; }
        [Column("acc_date", TypeName = "date")]
        public DateTime AccDate { get; set; }
        [Column("pos_id")]
        public int PosId { get; set; }
        [Column("ref_no")]
        [StringLength(30)]
        public string RefNo { get; set; }
    }
}
