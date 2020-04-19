using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFReverse.Models
{
    [Table("product_details_tracking")]
    public partial class ProductDetailsTracking
    {
        [Key]
        [Column("prod_cent_id")]
        [StringLength(20)]
        public string ProdCentId { get; set; }
        [Column("update_scope_local_id")]
        public int? UpdateScopeLocalId { get; set; }
        [Column("scope_update_peer_key")]
        public int? ScopeUpdatePeerKey { get; set; }
        [Column("scope_update_peer_timestamp")]
        public long? ScopeUpdatePeerTimestamp { get; set; }
        [Column("local_update_peer_key")]
        public int LocalUpdatePeerKey { get; set; }
        [Required]
        [Column("local_update_peer_timestamp")]
        public byte[] LocalUpdatePeerTimestamp { get; set; }
        [Column("create_scope_local_id")]
        public int? CreateScopeLocalId { get; set; }
        [Column("scope_create_peer_key")]
        public int? ScopeCreatePeerKey { get; set; }
        [Column("scope_create_peer_timestamp")]
        public long? ScopeCreatePeerTimestamp { get; set; }
        [Column("local_create_peer_key")]
        public int LocalCreatePeerKey { get; set; }
        [Column("local_create_peer_timestamp")]
        public long LocalCreatePeerTimestamp { get; set; }
        [Column("sync_row_is_tombstone")]
        public int SyncRowIsTombstone { get; set; }
        [Column("restore_timestamp")]
        public long? RestoreTimestamp { get; set; }
        [Column("last_change_datetime", TypeName = "datetime")]
        public DateTime? LastChangeDatetime { get; set; }
    }
}
