﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Schema
{
    [Table("INDEX_COLUMN")]
    public class IndexColumn
    {
        [Column("TABLE_SCHEMA")]
        public string TableSchema { get; set; }

        [Column("TABLE_NAME")]
        public string TableName { get; set; }

        [Column("INDEX_NAME")]
        public string IndexName { get; set; }

        [Column("TYPE_DESC")]
        public string TypeDesc { get; set; }

        [Column("INDEX_ID")]
        public int IndexId { get; set; }

        [Column("INDEX_COLUMN_ID")]
        public int IndexColumnId { get; set; }

        [Column("COLUMN_NAME")]
        public string ColumnName { get; set; }

        [Column("IS_PRIMARY_KEY")]
        public bool? IsPrimaryKey { get; set; }


    }
}
