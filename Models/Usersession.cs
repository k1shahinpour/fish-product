using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("usersession")]
    public partial class Usersession
    {
        [Column("session_time", TypeName = "datetime")]
        public DateTime SessionTime { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Key]
        [Column("session_id")]
        public int SessionId { get; set; }
        [Column("net_address")]
        [StringLength(255)]
        public string NetAddress { get; set; }
    }
}
