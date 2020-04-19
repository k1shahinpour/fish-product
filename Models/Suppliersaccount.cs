using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("suppliersaccount")]
    public partial class Suppliersaccount
    {
        [Key]
        [Column("account_id")]
        [StringLength(20)]
        public string AccountId { get; set; }
        [Column("suppliers_id")]
        public int SuppliersId { get; set; }
        [Column("invo_no")]
        public int InvoNo { get; set; }
        [Column("cash_total", TypeName = "numeric(12, 3)")]
        public decimal CashTotal { get; set; }
        [Column("cash_paid", TypeName = "numeric(12, 3)")]
        public decimal CashPaid { get; set; }
        [Column("dept", TypeName = "numeric(12, 3)")]
        public decimal Dept { get; set; }
        [Column("invo_date", TypeName = "date")]
        public DateTime InvoDate { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("Pos_id")]
        public int PosId { get; set; }
    }
}
