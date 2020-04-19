using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("dim")]
    public partial class Dim
    {
        [Key]
        [Column("date", TypeName = "date")]
        public DateTime Date { get; set; }
        [Column("day")]
        public int? Day { get; set; }
        [Column("month")]
        public int? Month { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FirstOfMonth { get; set; }
        [StringLength(30)]
        public string MonthName { get; set; }
        [Column("week")]
        public int? Week { get; set; }
        [Column("ISOweek")]
        public int? Isoweek { get; set; }
        public int? DayOfWeek { get; set; }
        [Column("quarter")]
        public int? Quarter { get; set; }
        [Column("year")]
        public int? Year { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FirstOfYear { get; set; }
        [StringLength(8)]
        public string Style112 { get; set; }
        [StringLength(10)]
        public string Style101 { get; set; }
    }
}
