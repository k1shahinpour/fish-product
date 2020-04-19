using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("invoice")]
    public partial class Invoice
    {
        [Key]
        [Column("invoice_id")]
        [StringLength(20)]
        public string InvoiceId { get; set; }
        [Column("invoice_date", TypeName = "date")]
        public DateTime InvoiceDate { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("totalprice", TypeName = "numeric(12, 3)")]
        public decimal Totalprice { get; set; }
        [Column("cash", TypeName = "numeric(12, 3)")]
        public decimal? Cash { get; set; }
        [Column("change", TypeName = "numeric(12, 3)")]
        public decimal? Change { get; set; }
        [Column("discount", TypeName = "numeric(18, 0)")]
        public decimal? Discount { get; set; }
        [Column("cust_id")]
        [StringLength(20)]
        public string CustId { get; set; }
        [Column("time_d", TypeName = "datetime")]
        public DateTime? TimeD { get; set; }
        [Column("paid")]
        public int? Paid { get; set; }
        [Column("pos_id")]
        public int? PosId { get; set; }
        [Column("cock_ntf")]
        [StringLength(100)]
        public string CockNtf { get; set; }
    }
}
