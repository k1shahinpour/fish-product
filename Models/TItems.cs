using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("T_items")]
    public partial class TItems
    {
        [Key]
        [Column("item_id")]
        [StringLength(20)]
        public string ItemId { get; set; }
        [Column("item_name_ar")]
        [StringLength(100)]
        public string ItemNameAr { get; set; }
        [Column("item_name_en")]
        [StringLength(100)]
        public string ItemNameEn { get; set; }
        [StringLength(50)]
        public string Unit { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Stock { get; set; }
        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }
        [Column("vissible")]
        public int? Vissible { get; set; }
        [Column("price", TypeName = "decimal(18, 3)")]
        public decimal? Price { get; set; }
    }
}
