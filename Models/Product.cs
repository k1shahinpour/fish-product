using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("product")]
    public partial class Product
    {
        [Key]
        [Column("prod_id")]
        public int ProdId { get; set; }
        [Column("prod_name_ar")]
        [StringLength(100)]
        public string ProdNameAr { get; set; }
        [Column("prod_name_en")]
        [StringLength(100)]
        public string ProdNameEn { get; set; }
        [Column("cate_id")]
        public int? CateId { get; set; }
        [Column("type_id")]
        public int? TypeId { get; set; }
        [StringLength(50)]
        public string Unit { get; set; }
        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }
        [Column("vissible")]
        public int? Vissible { get; set; }
    }
}
