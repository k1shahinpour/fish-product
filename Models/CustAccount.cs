using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("cust_account")]
    public partial class CustAccount
    {
        [Key]
        [Column("account_id")]
        [StringLength(20)]
        public string AccountId { get; set; }
        [Required]
        [Column("cust_id")]
        [StringLength(20)]
        public string CustId { get; set; }
        [Column("cash_paid", TypeName = "numeric(12, 3)")]
        public decimal? CashPaid { get; set; }
        [Column("amount", TypeName = "numeric(12, 3)")]
        public decimal Amount { get; set; }
        [Column("acc_date", TypeName = "date")]
        public DateTime AccDate { get; set; }
    }
}
