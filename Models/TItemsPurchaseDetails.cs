using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("T_items_purchase_details")]
    public partial class TItemsPurchaseDetails
    {
        [Key]
        [Column("id")]
        [StringLength(20)]
        public string Id { get; set; }
        [Column("Item_id")]
        [StringLength(20)]
        public string ItemId { get; set; }
        [Column("qty", TypeName = "numeric(18, 3)")]
        public decimal Qty { get; set; }
        [Column("cost_price", TypeName = "numeric(18, 3)")]
        public decimal CostPrice { get; set; }
        [Column("sub_total", TypeName = "numeric(18, 3)")]
        public decimal SubTotal { get; set; }
        [Required]
        [Column("acc_id")]
        [StringLength(20)]
        public string AccId { get; set; }
        [Column("vissible")]
        public int? Vissible { get; set; }
    }
}
