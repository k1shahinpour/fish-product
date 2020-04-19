using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("pos_data")]
    public partial class PosData
    {
        [Key]
        [Column("pos_ID")]
        public int PosId { get; set; }
        [Required]
        [Column("Pos_char")]
        [StringLength(30)]
        public string PosChar { get; set; }
        [Required]
        [Column("trade_name")]
        [StringLength(30)]
        public string TradeName { get; set; }
        [Required]
        [Column("loacation")]
        [StringLength(30)]
        public string Loacation { get; set; }
        [Required]
        [Column("phonenumber")]
        [StringLength(20)]
        public string Phonenumber { get; set; }
        [Required]
        [Column("rs_number")]
        [StringLength(20)]
        public string RsNumber { get; set; }
    }
}
