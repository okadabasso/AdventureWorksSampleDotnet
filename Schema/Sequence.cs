using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Schema.Infrastructure;

namespace Schema
{
    [Table("SEQUENCES")]
    public class Sequence
    {
        [Column("SEQUENCE_CATALOG")]
        public string SequenceCatalog { get; set; }

        [Column("SEQUENCE_SCHEMA")]
        public string SequenceSchema { get; set; }

        [Column("SEQUENCE_NAME")]
        public string SequenceName { get; set; }

        [Column("DATA_TYPE")]
        public string DataType { get; set; }

        [Column("NUMERIC_PRECISION")]
        public byte NumericPrecision { get; set; }

        [Column("NUMERIC_PRECISION_RADIX")]
        public short? NumericPrecisionRadix { get; set; }

        [Column("NUMERIC_SCALE")]
        public int? NumericScale { get; set; }

        [Column("START_VALUE")]
        public object StartValue { get; set; }

        [Column("MINIMUM_VALUE")]
        public object MinimumValue { get; set; }

        [Column("MAXIMUM_VALUE")]
        public object MaximumValue { get; set; }

        [Column("INCREMENT")]
        public object Increment { get; set; }

        [Column("CYCLE_OPTION")]
        public bool? CycleOption { get; set; }

        [Column("DECLARED_DATA_TYPE")]
        public string DeclaredDataType { get; set; }

        [Column("DECLARED_NUMERIC_PRECISION")]
        public byte DeclaredNumericPrecision { get; set; }

        [Column("DECLARED_NUMERIC_SCALE")]
        public byte DeclaredNumericScale { get; set; }
        public string ObjectName
        {
            get {
                return NamingConvention.Pascalize(SequenceName);
            }
        }
        public Type ObjectType
        {
            get {
                return TypeHelper.GetObjectType(DataType, false);
            }
        }
        public string ObjectTypeName
        {
            get {
                return TypeHelper.GetObjectTypeName(DataType, false);
            }
        }
    }
}
