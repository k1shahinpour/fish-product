using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("product_type")]
    public partial class ProductType
    {
        [Key]
        [Column("type_id")]
        public int TypeId { get; set; }
        [Required]
        [Column("type_name")]
        [StringLength(100)]
        public string TypeName { get; set; }
    }
}
