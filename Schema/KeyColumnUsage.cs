using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Schema
{
    [Table("KEY_COLUMN_USAGE")]
    public class KeyColumnUsage
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

        [Column("COLUMN_NAME")]
        public string ColumnName { get; set; }

        [Column("ORDINAL_POSITION")]
        public long OrdinalPosition { get; set; }

        [Column("DATA_TYPE")]
        public string DataType { get; set; }

        [Column("IS_NULLABLE")]
        public string IsNullable { get; set; }

        [Column("CONSTRAINT_TYPE")]
        public string ConstraintType { get; set; }

    }
}
