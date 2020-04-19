using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("T_recipe_details")]
    public partial class TRecipeDetails
    {
        [Key]
        [Column("d_id")]
        [StringLength(20)]
        public string DId { get; set; }
        [Required]
        [Column("item_id")]
        [StringLength(20)]
        public string ItemId { get; set; }
        [Column("unit_price", TypeName = "numeric(12, 3)")]
        public decimal UnitPrice { get; set; }
        [Column("total_price", TypeName = "numeric(12, 3)")]
        public decimal TotalPrice { get; set; }
        [Column("qunity", TypeName = "decimal(18, 3)")]
        public decimal? Qunity { get; set; }
        [Required]
        [Column("recipe_id")]
        [StringLength(20)]
        public string RecipeId { get; set; }
        [Column("vissible")]
        public int Vissible { get; set; }
    }
}
