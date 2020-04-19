using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("category")]
    public partial class Category
    {
        [Key]
        [Column("cat_id")]
        public int CatId { get; set; }
        [Column("cat_namear")]
        [StringLength(100)]
        public string CatNamear { get; set; }
        [Column("cat_nameen")]
        [StringLength(100)]
        public string CatNameen { get; set; }
        [Column("type_id")]
        public int? TypeId { get; set; }
        [Column("vissible")]
        public int? Vissible { get; set; }
    }
}
