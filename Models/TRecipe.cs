using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("T_recipe")]
    public partial class TRecipe
    {
        [Key]
        [Column("recipe_id")]
        [StringLength(20)]
        public string RecipeId { get; set; }
        [Column("recipe_date", TypeName = "date")]
        public DateTime RecipeDate { get; set; }
        [Column("totalprice", TypeName = "numeric(12, 3)")]
        public decimal Totalprice { get; set; }
        [Column("time_d", TypeName = "datetime")]
        public DateTime? TimeD { get; set; }
        [Column("pos_id_recever")]
        public int? PosIdRecever { get; set; }
        [Column("pos_id")]
        public int? PosId { get; set; }
    }
}
