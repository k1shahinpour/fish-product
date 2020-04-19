using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("Cash_to_bank")]
    public partial class CashToBank
    {
        [Key]
        [Column("cash_id")]
        [StringLength(20)]
        public string CashId { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? N50 { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? N20 { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? N10 { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? N5 { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? N1 { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Np5 { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Np1 { get; set; }
        [Column("cash_date", TypeName = "date")]
        public DateTime? CashDate { get; set; }
        [Column("pos_id")]
        public int? PosId { get; set; }
    }
}
