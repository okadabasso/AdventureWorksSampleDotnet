using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Schema.Infrastructure
{
    public static class TypeHelper
    {
        
        public static readonly Dictionary<string, string> TypeAlias = new Dictionary<string, string>
        {
            {"System.Object", "object"},
            {"System.String", "string"},
            {"System.Byte[]", "byte[]"},
            {"System.Boolean", "bool"},
            {"System.Byte", "byte"},
            {"System.SByte", "sbyte"},
            {"System.Int16", "short"},
            {"System.UInt16", "ushort"},
            {"System.Int32", "int"},
            {"System.UInt32", "uint"},
            {"System.Int64", "long"},
            {"System.UInt64", "ulong"},
            {"System.Single", "float"},
            {"System.Double", "double"},
            {"System.Decimal", "decimal"},
            {"System.Char", "char"},
            {"System.DateTime", "DateTime"},
            {"System.TimeSpan", "TimeSpan"},
            {"System.DateTimeOffset", "DateTimeOffset"},
            {"System.Guid", "Guid"}
        };
        public static readonly Dictionary<string, Type> TypeMapping = new Dictionary<string, Type>
        {
            {"image", typeof(byte[]) },
            {"varbinary", typeof(byte[]) },
            {"binary", typeof(byte[]) },
            {"text", typeof(string) },
            {"ntext", typeof(string) },
            {"varchar", typeof(string) },
            {"char", typeof(string) },
            {"nvarchar", typeof(string) },
            {"nchar", typeof(string) },
            {"date", typeof(DateTime) },
            {"time", typeof(TimeSpan) },
            {"datetime2", typeof(DateTime) },
            {"datetimeoffset", typeof(DateTimeOffset) },
            {"smalldatetime", typeof(DateTime) },
            {"datetime", typeof(DateTime) },
            {"timestamp", typeof(byte[]) },
            {"tinyint", typeof(byte) },
            {"smallint", typeof(short) },
            {"int", typeof(int) },
            {"bigint", typeof(long) },
            {"real", typeof(float) },
            {"float", typeof(double) },
            {"decimal", typeof(decimal) },
            {"numeric", typeof(decimal) },
            {"money", typeof(decimal) },
            {"smallmoney", typeof(decimal) },
            {"bit", typeof(bool) },
            {"uniqueidentifier", typeof(Guid) },
            {"xml", typeof(string) },
            {"hierarchyid", typeof(byte[]) },
            {"mediumint", typeof(int) }

        };
        public static readonly Dictionary<string, DbType> DbTypeMapping = new Dictionary<string, DbType>
        {
            {"image", DbType.Binary },
            {"varbinary", DbType.Binary },
            {"binary", DbType.Binary },
            {"text", DbType.String},
            {"ntext", DbType.String },
            {"varchar", DbType.String },
            {"char", DbType.StringFixedLength },
            {"nvarchar", DbType.String },
            {"nchar", DbType.String },
            {"date", DbType.Date },
            {"time", DbType.Time},
            {"datetime2", DbType.DateTime2},
            {"datetimeoffset", DbType.DateTimeOffset },
            {"smalldatetime", DbType.DateTime},
            {"datetime", DbType.DateTime },
            {"timestamp", DbType.Binary },
            {"tinyint", DbType.Byte},
            {"smallint", DbType.Int16},
            {"int", DbType.Int32 },
            {"bigint", DbType.Int64 },
            {"real", DbType.Single },
            {"float", DbType.Double },
            {"decimal", DbType.VarNumeric },
            {"numeric", DbType.VarNumeric },
            {"money", DbType.Decimal},
            {"smallmoney", DbType.Decimal},
            {"bit", DbType.Boolean },
            {"uniqueidentifier", DbType.Guid },
            {"xml", DbType.Xml },
            {"hierarchyid", DbType.Binary },
            {"mediumint", DbType.Int32}

        };
        public static Type GetObjectType(string dataType, bool nullable)
        {
            if (TypeHelper.TypeMapping.ContainsKey(dataType))
            {
                var baseType = TypeHelper.TypeMapping[dataType];
                if (nullable && baseType != typeof(object) && baseType != typeof(string) && baseType != typeof(byte[]))
                {
                    var nullableType = typeof(Nullable<>);
                    var objectType = nullableType.MakeGenericType(baseType);
                    return objectType;
                }
                else
                {
                    return baseType;
                }
            }
            return typeof(object);

        }
        public static string GetObjectTypeName(string dataType, bool nullable)
        {
            if (TypeHelper.TypeMapping.ContainsKey(dataType))
            {
                var baseType = TypeHelper.TypeMapping[dataType];
                if (TypeHelper.TypeAlias.ContainsKey(baseType.FullName))
                {

                    var typeAlias = TypeAlias[baseType.FullName];

                    if (nullable && typeAlias != "object" && typeAlias != "string" && typeAlias != "byte[]")
                    {
                        typeAlias += "?";
                    }
                    return typeAlias;
                }
            }
            return "object";

        }

        public static string GetObjectTypeName(Type objectType, bool nullable)
        {
            var baseType = Nullable.GetUnderlyingType(objectType) ?? objectType;
            if (TypeHelper.TypeAlias.ContainsKey(baseType.FullName))
            {

                var typeAlias = TypeAlias[baseType.FullName];

                if (nullable && typeAlias != "object" && typeAlias != "string")
                {
                    typeAlias += "?";
                }
                return typeAlias;
            }
            return "object";

        }
        public static Func<string, object> CreateValueParser(Type t)
        {
            var arg0 = Expression.Parameter(typeof(string), "value");

            Expression body = null;
            if (t == typeof(string))
            {
                body = Expression.Convert(arg0, typeof(object));
            }
            else
            {
                var baseType = Nullable.GetUnderlyingType(t) ?? t;
                body = Expression.Convert(Expression.Call(baseType.GetMethod("Parse", new Type[] { typeof(string) }), arg0), typeof(object));
            }
            var lambda = Expression.Lambda<Func<string, object>>(body, arg0);
            return lambda.Compile();
        }

        public static Func<object> CreateDefaultValueFunc(Type t)
        {
            var defaultValue = Expression.Convert(Expression.Default(t), typeof(object));
            var d = Expression.Lambda<Func<object>>(defaultValue);
            var o = d.Compile();

            return o;
        }
    }
}
