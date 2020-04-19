using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    public partial class Suppliers
    {
        [Key]
        [Column("Suppliers_id")]
        public int SuppliersId { get; set; }
        [Required]
        [Column("Suppliers_name")]
        [StringLength(40)]
        public string SuppliersName { get; set; }
        [Column("phone_no")]
        [StringLength(40)]
        public string PhoneNo { get; set; }
        [Column("Suppliers_tel_add")]
        [StringLength(40)]
        public string SuppliersTelAdd { get; set; }
        [Column("vissible")]
        public int? Vissible { get; set; }
    }
}
