using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Schema.Infrastructure;

namespace Schema
{
    [Table("ROUTINE_COLUMNS")]
    public class RoutineColumn
    {
        [Column("TABLE_CATALOG")]
        public string TableCatalog { get; set; }

        [Column("TABLE_SCHEMA")]
        public string TableSchema { get; set; }

        [Column("TABLE_NAME")]
        public string TableName { get; set; }

        [Column("COLUMN_NAME")]
        public string ColumnName { get; set; }

        [Column("ORDINAL_POSITION")]
        public int OrdinalPosition { get; set; }

        [Column("COLUMN_DEFAULT")]
        public string ColumnDefault { get; set; }

        [Column("IS_NULLABLE")]
        public string IsNullable { get; set; }

        [Column("DATA_TYPE")]
        public string DataType { get; set; }

        [Column("CHARACTER_MAXIMUM_LENGTH")]
        public int? CharacterMaximumLength { get; set; }

        [Column("CHARACTER_OCTET_LENGTH")]
        public int? CharacterOctetLength { get; set; }

        [Column("NUMERIC_PRECISION")]
        public byte? NumericPrecision { get; set; }

        [Column("NUMERIC_PRECISION_RADIX")]
        public short? NumericPrecisionRadix { get; set; }

        [Column("NUMERIC_SCALE")]
        public int? NumericScale { get; set; }

        [Column("DATETIME_PRECISION")]
        public short? DatetimePrecision { get; set; }

        [Column("CHARACTER_SET_CATALOG")]
        public string CharacterSetCatalog { get; set; }

        [Column("CHARACTER_SET_SCHEMA")]
        public string CharacterSetSchema { get; set; }

        [Column("CHARACTER_SET_NAME")]
        public string CharacterSetName { get; set; }

        [Column("COLLATION_CATALOG")]
        public string CollationCatalog { get; set; }

        [Column("COLLATION_SCHEMA")]
        public string CollationSchema { get; set; }

        [Column("COLLATION_NAME")]
        public string CollationName { get; set; }

        [Column("DOMAIN_CATALOG")]
        public string DomainCatalog { get; set; }

        [Column("DOMAIN_SCHEMA")]
        public string DomainSchema { get; set; }

        [Column("DOMAIN_NAME")]
        public string DomainName { get; set; }

        public string ObjectName
        {
            get {
                return Inflector.Currnet.Pascalize(ColumnName);
            }
        }
        public Type ObjectType
        {
            get {
                return TypeHelper.GetObjectType(DataType, IsNullable == "YES");
            }
        }

    }
}
