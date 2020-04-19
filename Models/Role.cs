using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("role")]
    public partial class Role
    {
        [Key]
        [Column("role_id")]
        public int RoleId { get; set; }
        [Required]
        [Column("role_map")]
        [StringLength(100)]
        public string RoleMap { get; set; }
    }
}
