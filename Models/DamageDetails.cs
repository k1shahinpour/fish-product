using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("damage_details")]
    public partial class DamageDetails
    {
        [Key]
        [Column("dd_id")]
        [StringLength(20)]
        public string DdId { get; set; }
        [Column("prod_id")]
        public int ProdId { get; set; }
        [Column("pur_price", TypeName = "decimal(12, 3)")]
        public decimal? PurPrice { get; set; }
        [Column("total_price", TypeName = "numeric(12, 3)")]
        public decimal TotalPrice { get; set; }
        [Column("qunity", TypeName = "decimal(18, 3)")]
        public decimal? Qunity { get; set; }
        [Required]
        [Column("d_id")]
        [StringLength(20)]
        public string DId { get; set; }
        [Column("vissible")]
        public int Vissible { get; set; }
    }
}
