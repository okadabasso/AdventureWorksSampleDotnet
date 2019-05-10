using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;
using Schema.Infrastructure;

namespace Schema
{
    [Table("COLUMNS")]
    public class Column
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
        public ulong? OrdinalPosition { get; set; }

        [Column("COLUMN_DEFAULT")]
        public string ColumnDefault { get; set; }

        [Column("IS_NULLABLE")]
        public string IsNullable { get; set; }

        [Column("DATA_TYPE")]
        public string DataType { get; set; }

        [Column("CHARACTER_MAXIMUM_LENGTH")]
        public ulong? CharacterMaximumLength { get; set; }

        [Column("CHARACTER_OCTET_LENGTH")]
        public ulong? CharacterOctetLength { get; set; }

        [Column("NUMERIC_PRECISION")]
        public ulong? NumericPrecision { get; set; }

        [Column("NUMERIC_PRECISION_RADIX")]
        public ulong? NumericPrecisionRadix { get; set; }

        [Column("NUMERIC_SCALE")]
        public ulong? NumericScale { get; set; }

        [Column("DATETIME_PRECISION")]
        public ulong? DatetimePrecision { get; set; }

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


        [Column("IS_IDENTITY")]
        public string IsIdentity{ get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }

        public string ObjectName
        {
            get {
                var name = ColumnName;
                var tableName = TableName;
                if(name == TableName)
                {
                    name = name + "1";
                }
                return NamingConvention.Pascalize(name);
            }
        }
        public Type ObjectType
        {
            get {
                return TypeHelper.GetObjectType(DataType, IsNullable == "YES");
            }
        }
        public string ObjectTypeName
        {
            get {
                return TypeHelper.GetObjectTypeName(DataType, IsNullable == "YES");
            }
        }
        public object DefaultValue
        {
            get {
                if(ColumnDefault == null)
                {
                    var func = TypeHelper.CreateDefaultValueFunc(ObjectType);
                    return func();
                }
                if (ColumnDefault.StartsWith("((") && ColumnDefault.StartsWith("))"))
                {
                    var value = ColumnDefault.Substring(2, ColumnDefault.Length - 4);
                    var parser = TypeHelper.CreateValueParser(ObjectType);
                    return parser(ColumnDefault);
                }
                return TypeHelper.CreateDefaultValueFunc(ObjectType)();
            }
        }
        public string DefaultValueLiteral
        {
            get {
                var defaultValue = DefaultValue;
                if(defaultValue == null)
                {
                    return "null";
                }
                var baseType = Nullable.GetUnderlyingType(ObjectType) ?? ObjectType;
                if(baseType == typeof(string))
                {
                    return $@"""{defaultValue.ToString()}""";
                }
                if (baseType == typeof(bool))
                {
                    return defaultValue.ToString().ToLower(); //
                }
                if (baseType == typeof(DateTime))
                {
                    // ここで出力するデフォルト値は言語に依存しないためにDateTime.Parseなどを使わない。
                    // 各言語で利用するときに必要なParserを使うようにする
                    return $@"""{defaultValue.ToString()}""";
                }
                if (baseType == typeof(TimeSpan))
                {
                    // ここで出力するデフォルト値は言語に依存しないためにDateTime.Parseなどを使わない。
                    // 各言語で利用するときに必要なParserを使うようにする
                    return $@"""{defaultValue.ToString()}""";
                }
                if (baseType == typeof(Guid))
                {
                    // ここで出力するデフォルト値は言語に依存しないためにDateTime.Parseなどを使わない。
                    // 各言語で利用するときに必要なParserを使うようにする
                    return $@"""{defaultValue.ToString()}""";
                }
                return defaultValue.ToString();
            }
        }

        public ulong? Length
        {
            get {
                if (CharacterOctetLength.HasValue)
                {
                    return CharacterOctetLength.Value;
                }

                return default(ulong?);
            }
        }
        public ulong? Precision
        {
            get {
                if (CharacterMaximumLength.HasValue)
                {
                    return CharacterMaximumLength.Value;
                }
                if (NumericPrecision.HasValue)
                {
                    return NumericPrecision.Value;
                }
                if (DatetimePrecision.HasValue)
                {
                    return DatetimePrecision.Value;
                }

                return default(ulong?);
            }
        }
        public ulong? Scale
        {
            get {
                if (NumericScale.HasValue)
                {
                    return NumericScale.Value;
                }
                return default(ulong?);
            }
        }
        public bool IsFixedLength
        {
            get {
                return (DataType == "char" || DataType == "nchar" || DataType == "binary");
            }
        }
        public bool IsUnicode
        {
            get {
                return (DataType == "nchar" || DataType == "nvarchar" || DataType == "ntext");

            }
        }
        public bool IsString
        {
            get {
                return (DataType == "nchar" || DataType == "nvarchar" || DataType == "ntext" || DataType == "char" || DataType == "varchar" || DataType == "text");
            }
        }
        
    }
}
