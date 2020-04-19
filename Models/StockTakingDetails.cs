using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("stock_taking_details")]
    public partial class StockTakingDetails
    {
        [Key]
        [Column("stocking_id")]
        [StringLength(20)]
        public string StockingId { get; set; }
        [Column("prod_id")]
        public int ProdId { get; set; }
        [Column("carr_aty", TypeName = "numeric(12, 3)")]
        public decimal? CarrAty { get; set; }
        [Column("qty_onhand", TypeName = "numeric(12, 3)")]
        public decimal? QtyOnhand { get; set; }
        [Column("diffrent_qty", TypeName = "numeric(12, 3)")]
        public decimal? DiffrentQty { get; set; }
        [Required]
        [Column("stock_id")]
        [StringLength(20)]
        public string StockId { get; set; }
    }
}
