using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Schema
{
    [Table("INDEX")]
    public class Index
    {
        [Column("object_id")]
        public int ObjectId { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("index_id")]
        public int IndexId { get; set; }

        [Column("type")]
        public byte Type { get; set; }

        [Column("type_desc")]
        public string TypeDesc { get; set; }

        [Column("is_unique")]
        public bool? IsUnique { get; set; }

        [Column("data_space_id")]
        public int? DataSpaceId { get; set; }

        [Column("ignore_dup_key")]
        public bool? IgnoreDupKey { get; set; }

        [Column("is_primary_key")]
        public bool? IsPrimaryKey { get; set; }

        [Column("is_unique_constraint")]
        public bool? IsUniqueConstraint { get; set; }

        [Column("fill_factor")]
        public byte FillFactor { get; set; }

        [Column("is_padded")]
        public bool? IsPadded { get; set; }

        [Column("is_disabled")]
        public bool? IsDisabled { get; set; }

        [Column("is_hypothetical")]
        public bool? IsHypothetical { get; set; }

        [Column("allow_row_locks")]
        public bool? AllowRowLocks { get; set; }

        [Column("allow_page_locks")]
        public bool? AllowPageLocks { get; set; }

        [Column("has_filter")]
        public bool? HasFilter { get; set; }

        [Column("filter_definition")]
        public string FilterDefinition { get; set; }

        [Column("compression_delay")]
        public int? CompressionDelay { get; set; }

        public List<IndexColumn> Columns { get; set; }

    }
}
