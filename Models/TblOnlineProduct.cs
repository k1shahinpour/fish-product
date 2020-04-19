using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("tblOnlineProduct")]
    public partial class TblOnlineProduct
    {
        [Key]
        [Column("ID")]
        [StringLength(50)]
        public string Id { get; set; }
        [Column("pos_id")]
        public int PosId { get; set; }
        [Column("prod_id")]
        public int ProdId { get; set; }
        [Column("qty", TypeName = "decimal(18, 3)")]
        public decimal Qty { get; set; }
        [Column("fresh_price", TypeName = "decimal(18, 3)")]
        public decimal FreshPrice { get; set; }
        [Column("meal_price", TypeName = "decimal(18, 3)")]
        public decimal? MealPrice { get; set; }
        [Column("D_DATE", TypeName = "date")]
        public DateTime? DDate { get; set; }
        [Column("photo", TypeName = "image")]
        public byte[] Photo { get; set; }
        [Column("vissible")]
        public bool? Vissible { get; set; }
    }
}
