using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Schema
{
    [Table("TABLE_CONSTRAINTS")]
    public class TableConstraint
    {
        [Column("CONSTRAINT_CATALOG")]
        public string ConstraintCatalog { get; set; }

        [Column("CONSTRAINT_SCHEMA")]
        public string ConstraintSchema { get; set; }

        [Column("CONSTRAINT_NAME")]
        public string ConstraintName { get; set; }

        [Column("TABLE_CATALOG")]
        public string TableCatalog { get; set; }

        [Column("TABLE_SCHEMA")]
        public string TableSchema { get; set; }

        [Column("TABLE_NAME")]
        public string TableName { get; set; }

        [Column("CONSTRAINT_TYPE")]
        public string ConstraintType { get; set; }

        [Column("IS_DEFERRABLE")]
        public string IsDeferrable { get; set; }

        [Column("INITIALLY_DEFERRED")]
        public string InitiallyDeferred { get; set; }
        public List<KeyColumnUsage> ConstraintColumns { get; set; }



    }
}
