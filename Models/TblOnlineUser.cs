using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("tblOnlineUser")]
    public partial class TblOnlineUser
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(150)]
        public string UserName { get; set; }
        [Required]
        [Column("User_N")]
        [StringLength(50)]
        public string UserN { get; set; }
        [Required]
        [Column("PWD")]
        [StringLength(50)]
        public string Pwd { get; set; }
        public int Privildge { get; set; }
        [Required]
        [Column("hint")]
        [StringLength(50)]
        public string Hint { get; set; }
        [Column("reg_Date", TypeName = "date")]
        public DateTime RegDate { get; set; }
        [Column("Pos_ID")]
        public int PosId { get; set; }
        [Column("address")]
        public int Address { get; set; }
        [Required]
        [Column("phone")]
        [StringLength(20)]
        public string Phone { get; set; }
        public int Rate { get; set; }
    }
}
