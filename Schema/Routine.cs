using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Schema.Infrastructure;
namespace Schema
{
    [Table("ROUTINES")]
    public class Routine
    {
        [Column("SPECIFIC_CATALOG")]
        public string SpecificCatalog { get; set; }

        [Column("SPECIFIC_SCHEMA")]
        public string SpecificSchema { get; set; }

        [Column("SPECIFIC_NAME")]
        public string SpecificName { get; set; }

        [Column("ROUTINE_CATALOG")]
        public string RoutineCatalog { get; set; }

        [Column("ROUTINE_SCHEMA")]
        public string RoutineSchema { get; set; }

        [Column("ROUTINE_NAME")]
        public string RoutineName { get; set; }

        [Column("ROUTINE_TYPE")]
        public string RoutineType { get; set; }

        [Column("MODULE_CATALOG")]
        public string ModuleCatalog { get; set; }

        [Column("MODULE_SCHEMA")]
        public string ModuleSchema { get; set; }

        [Column("MODULE_NAME")]
        public string ModuleName { get; set; }

        [Column("UDT_CATALOG")]
        public string UdtCatalog { get; set; }

        [Column("UDT_SCHEMA")]
        public string UdtSchema { get; set; }

        [Column("UDT_NAME")]
        public string UdtName { get; set; }

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

        [Column("TYPE_UDT_CATALOG")]
        public string TypeUdtCatalog { get; set; }

        [Column("TYPE_UDT_SCHEMA")]
        public string TypeUdtSchema { get; set; }

        [Column("TYPE_UDT_NAME")]
        public string TypeUdtName { get; set; }

        [Column("SCOPE_CATALOG")]
        public string ScopeCatalog { get; set; }

        [Column("SCOPE_SCHEMA")]
        public string ScopeSchema { get; set; }

        [Column("SCOPE_NAME")]
        public string ScopeName { get; set; }

        [Column("MAXIMUM_CARDINALITY")]
        public long? MaximumCardinality { get; set; }

        [Column("DTD_IDENTIFIER")]
        public string DtdIdentifier { get; set; }

        [Column("ROUTINE_BODY")]
        public string RoutineBody { get; set; }

        [Column("ROUTINE_DEFINITION")]
        public string RoutineDefinition { get; set; }

        [Column("EXTERNAL_NAME")]
        public string ExternalName { get; set; }

        [Column("EXTERNAL_LANGUAGE")]
        public string ExternalLanguage { get; set; }

        [Column("PARAMETER_STYLE")]
        public string ParameterStyle { get; set; }

        [Column("IS_DETERMINISTIC")]
        public string IsDeterministic { get; set; }

        [Column("SQL_DATA_ACCESS")]
        public string SqlDataAccess { get; set; }

        [Column("IS_NULL_CALL")]
        public string IsNullCall { get; set; }

        [Column("SQL_PATH")]
        public string SqlPath { get; set; }

        [Column("SCHEMA_LEVEL_ROUTINE")]
        public string SchemaLevelRoutine { get; set; }

        [Column("MAX_DYNAMIC_RESULT_SETS")]
        public short? MaxDynamicResultSets { get; set; }

        [Column("IS_USER_DEFINED_CAST")]
        public string IsUserDefinedCast { get; set; }

        [Column("IS_IMPLICITLY_INVOCABLE")]
        public string IsImplicitlyInvocable { get; set; }

        [Column("CREATED")]
        public DateTime? Created { get; set; }

        [Column("LAST_ALTERED")]
        public DateTime? LastAltered { get; set; }

        public List<Parameter> Parameters { get; set; }
        public string ObjectName
        {
            get {
                return Inflector.Currnet.Pascalize(RoutineName);
            }
        }
        public Type ObjectType
        {
            get {
                return TypeHelper.GetObjectType(DataType, true);
            }
        }
        public string ObjectTypeName
        {
            get {
                return TypeHelper.GetObjectTypeName(DataType, true);
            }
        }

    }
}
