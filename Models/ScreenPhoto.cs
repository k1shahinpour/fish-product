using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("screen_photo")]
    public partial class ScreenPhoto
    {
        [Key]
        [Column("photo_cent_id")]
        [StringLength(20)]
        public string PhotoCentId { get; set; }
        [Column("desc")]
        [StringLength(20)]
        public string Desc { get; set; }
        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }
        [Column("pos_id")]
        public int? PosId { get; set; }
    }
}
