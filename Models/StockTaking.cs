using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("stock_taking")]
    public partial class StockTaking
    {
        [Key]
        [Column("stock_id")]
        [StringLength(20)]
        public string StockId { get; set; }
        [Column("pos_id")]
        public int PosId { get; set; }
        [Column("invo_date", TypeName = "date")]
        public DateTime? InvoDate { get; set; }
    }
}
