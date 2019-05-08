using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Schema.Infrastructure;
namespace Schema
{
    [Table("PARAMETERS")]
    public class Parameter
    {
        [Column("SPECIFIC_CATALOG")]
        public string SpecificCatalog { get; set; }

        [Column("SPECIFIC_SCHEMA")]
        public string SpecificSchema { get; set; }

        [Column("SPECIFIC_NAME")]
        public string SpecificName { get; set; }

        [Column("ORDINAL_POSITION")]
        public int OrdinalPosition { get; set; }

        [Column("PARAMETER_MODE")]
        public string ParameterMode { get; set; }

        [Column("IS_RESULT")]
        public string IsResult { get; set; }

        [Column("AS_LOCATOR")]
        public string AsLocator { get; set; }

        [Column("PARAMETER_NAME")]
        public string ParameterName { get; set; }

        [Column("DATA_TYPE")]
        public string DataType { get; set; }

        [Column("CHARACTER_MAXIMUM_LENGTH")]
        public int? CharacterMaximumLength { get; set; }

        [Column("CHARACTER_OCTET_LENGTH")]
        public int? CharacterOctetLength { get; set; }

        [Column("COLLATION_CATALOG")]
        public string CollationCatalog { get; set; }

        [Column("COLLATION_SCHEMA")]
        public string CollationSchema { get; set; }

        [Column("COLLATION_NAME")]
        public string CollationName { get; set; }

        [Column("CHARACTER_SET_CATALOG")]
        public string CharacterSetCatalog { get; set; }

        [Column("CHARACTER_SET_SCHEMA")]
        public string CharacterSetSchema { get; set; }

        [Column("CHARACTER_SET_NAME")]
        public string CharacterSetName { get; set; }

        [Column("NUMERIC_PRECISION")]
        public byte? NumericPrecision { get; set; }

        [Column("NUMERIC_PRECISION_RADIX")]
        public short? NumericPrecisionRadix { get; set; }

        [Column("NUMERIC_SCALE")]
        public int? NumericScale { get; set; }

        [Column("DATETIME_PRECISION")]
        public short? DatetimePrecision { get; set; }

        [Column("INTERVAL_TYPE")]
        public string IntervalType { get; set; }

        [Column("INTERVAL_PRECISION")]
        public short? IntervalPrecision { get; set; }

        [Column("USER_DEFINED_TYPE_CATALOG")]
        public string UserDefinedTypeCatalog { get; set; }

        [Column("USER_DEFINED_TYPE_SCHEMA")]
        public string UserDefinedTypeSchema { get; set; }

        [Column("USER_DEFINED_TYPE_NAME")]
        public string UserDefinedTypeName { get; set; }

        [Column("SCOPE_CATALOG")]
        public string ScopeCatalog { get; set; }

        [Column("SCOPE_SCHEMA")]
        public string ScopeSchema { get; set; }

        [Column("SCOPE_NAME")]
        public string ScopeName { get; set; }

        public string ObjectName
        {
            get {
                // parameter prefixが付く場合はObjectNameからprefixを除外する
                if(ParameterName.StartsWith("@") || ParameterName.StartsWith(":"))
                {
                    return NamingConvention.Pascalize(ParameterName.Substring(1));

                }
                return NamingConvention.Pascalize(ParameterName);
            }
        }
        public Type ObjectType
        {
            get {
                return Infrastructure.TypeHelper.GetObjectType(DataType, true);
            }
        }
        public string ObjectTypeName
        {
            get {
                return Infrastructure.TypeHelper.GetObjectTypeName(DataType, true);
            }
        }
        public int? Length
        {
            get {
                if (CharacterOctetLength.HasValue)
                {
                    return CharacterOctetLength.Value;
                }

                return default(int?);
            }
        }
        public int? Precision
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

                return default(int?);
            }
        }
        public int? Scale
        {
            get {
                if (NumericScale.HasValue)
                {
                    return NumericScale.Value;
                }
                return default(int?);
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
