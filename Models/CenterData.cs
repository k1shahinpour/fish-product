using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("center_data")]
    public partial class CenterData
    {
        [Key]
        [Column("center_ID")]
        public int CenterId { get; set; }
        [Required]
        [Column("center_Name")]
        [StringLength(170)]
        public string CenterName { get; set; }
        [Required]
        [Column("location")]
        [StringLength(170)]
        public string Location { get; set; }
        [Required]
        [Column("phonenumber")]
        [StringLength(170)]
        public string Phonenumber { get; set; }
        [Required]
        [Column("cr")]
        [StringLength(170)]
        public string Cr { get; set; }
    }
}
