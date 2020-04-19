using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("purchasess_photo")]
    public partial class PurchasessPhoto
    {
        [Key]
        [Column("photo_id")]
        [StringLength(20)]
        public string PhotoId { get; set; }
        [Column("invo_id")]
        [StringLength(20)]
        public string InvoId { get; set; }
        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }
        [Column("vissible")]
        public int? Vissible { get; set; }
    }
}
