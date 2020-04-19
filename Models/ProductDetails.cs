using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("product_details")]
    public partial class ProductDetails
    {
        [Key]
        [Column("prod_cent_id")]
        [StringLength(20)]
        public string ProdCentId { get; set; }
        [Column("prod_id")]
        public int? ProdId { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Stock { get; set; }
        [Column("pur_price", TypeName = "decimal(18, 3)")]
        public decimal? PurPrice { get; set; }
        [Column("fresh_price", TypeName = "decimal(18, 3)")]
        public decimal? FreshPrice { get; set; }
        [Column("mal_price", TypeName = "decimal(18, 3)")]
        public decimal? MalPrice { get; set; }
        [Column("cock_price", TypeName = "decimal(18, 3)")]
        public decimal? CockPrice { get; set; }
        [Column("pos_id")]
        public int? PosId { get; set; }
    }
}
