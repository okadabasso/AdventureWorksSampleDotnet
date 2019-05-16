using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Schema
{
    [Table("REFERENTIAL_CONSTRAINTS")]
    public class ReferentialConstraint
    {
        [Column("CONSTRAINT_CATALOG")]
        public string ConstraintCatalog { get; set; }

        [Column("CONSTRAINT_SCHEMA")]
        public string ConstraintSchema { get; set; }

        [Column("CONSTRAINT_NAME")]
        public string ConstraintName { get; set; }

        [Column("UNIQUE_CONSTRAINT_CATALOG")]
        public string UniqueConstraintCatalog { get; set; }

        [Column("UNIQUE_CONSTRAINT_SCHEMA")]
        public string UniqueConstraintSchema { get; set; }

        [Column("UNIQUE_CONSTRAINT_NAME")]
        public string UniqueConstraintName { get; set; }

        [Column("MATCH_OPTION")]
        public string MatchOption { get; set; }

        [Column("UPDATE_RULE")]
        public string UpdateRule { get; set; }

        [Column("DELETE_RULE")]
        public string DeleteRule { get; set; }


        [Column("BASE_TABLE_SCHEMA")]
        public string BaseTableSchema { get; set; }
        [Column("BASE_TABLE_NAME")]
        public string BaseTableName { get; set; }

        [Column("REFERENCE_TABLE_SCHEMA")]
        public string ReferenceTableSchema { get; set; }
        [Column("REFERENCE_TABLE_NAME")]
        public string ReferenceTableName { get; set; }
    }
}
