using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("inventory")]
    public partial class Inventory
    {
        [Key]
        [Column("inventory_id")]
        [StringLength(20)]
        public string InventoryId { get; set; }
        [Column("prod_id")]
        public int ProdId { get; set; }
        [Column("qty_sold", TypeName = "numeric(12, 3)")]
        public decimal? QtySold { get; set; }
        [Column("qty_in", TypeName = "numeric(12, 3)")]
        public decimal? QtyIn { get; set; }
        [Column("qty_current", TypeName = "numeric(12, 3)")]
        public decimal? QtyCurrent { get; set; }
        [Column("pos_id")]
        public int PosId { get; set; }
        [Column("invo_date", TypeName = "date")]
        public DateTime? InvoDate { get; set; }
    }
}
