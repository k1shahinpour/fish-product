using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("customer")]
    public partial class Customer
    {
        [Key]
        [Column("Cust_id")]
        [StringLength(20)]
        public string CustId { get; set; }
        [Required]
        [Column("Cust_name")]
        [StringLength(100)]
        public string CustName { get; set; }
        [Column("Cust_add")]
        [StringLength(100)]
        public string CustAdd { get; set; }
        [Column("cust_phone")]
        [StringLength(20)]
        public string CustPhone { get; set; }
        [Column("cust_date", TypeName = "date")]
        public DateTime CustDate { get; set; }
        [Column("credit_limit", TypeName = "numeric(12, 3)")]
        public decimal? CreditLimit { get; set; }
    }
}
