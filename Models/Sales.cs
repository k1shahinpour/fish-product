using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("sales")]
    public partial class Sales
    {
        [Key]
        [Column("sale_id")]
        [StringLength(20)]
        public string SaleId { get; set; }
        [Column("prod_id")]
        public int ProdId { get; set; }
        [Column("pur_price", TypeName = "decimal(12, 3)")]
        public decimal? PurPrice { get; set; }
        [Column("unit_price", TypeName = "numeric(12, 3)")]
        public decimal UnitPrice { get; set; }
        [Column("total_price", TypeName = "numeric(12, 3)")]
        public decimal TotalPrice { get; set; }
        [Column("qunity", TypeName = "decimal(18, 3)")]
        public decimal? Qunity { get; set; }
        [Column("n_o_pc")]
        public int? NOPc { get; set; }
        [Column("Fish_status")]
        [StringLength(20)]
        public string FishStatus { get; set; }
        [Required]
        [Column("invoice_id")]
        [StringLength(20)]
        public string InvoiceId { get; set; }
        [Column("benfit", TypeName = "numeric(12, 3)")]
        public decimal? Benfit { get; set; }
        [Column("vissible")]
        public int? Vissible { get; set; }
    }
}
