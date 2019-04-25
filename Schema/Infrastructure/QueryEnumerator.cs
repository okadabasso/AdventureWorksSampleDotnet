using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Linq.Expressions;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Schema.Infrastructure
{
    class QueryEnumerator<T> : IEnumerator<T>
    {
        private readonly DbDataReader reader;
        private readonly Dictionary<string, int> columnMapping;
        private readonly DataTable schemaTable;
        private static Func<QueryEnumerator<T>, T> rowMapper;
        private static readonly MethodInfo readValueMethod = typeof(QueryEnumerator<T>).GetMethod("ReadValue", BindingFlags.Instance | BindingFlags.NonPublic);
        private static readonly MethodInfo hasColumnMethod = typeof(QueryEnumerator<T>).GetMethod("HasColumn", BindingFlags.Instance | BindingFlags.NonPublic);
        public T Current => GetT();
        public QueryEnumerator(DbDataReader reader)
        {
            this.reader = reader;
            this.schemaTable = reader.GetSchemaTable();
            this.columnMapping = new Dictionary<string, int>();
        }
        object IEnumerator.Current => GetT();

        public void Dispose()
        {
            reader.Close();
        }

        public bool MoveNext()
        {
            return reader.Read();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
        private T GetT()
        {
            if (rowMapper == null)
            {
                rowMapper = CreateRowMapper();
            }
            if(columnMapping.Count == 0)
            {
                CreateColumnMapping();

            }
            return rowMapper(this);

        }

        private void CreateColumnMapping()
        {
            foreach (DataRow row in schemaTable.Rows)
            {
                columnMapping.Add(row["ColumnName"].ToString(), (int)row["ColumnOrdinal"]);
            }
        }

        private Func<QueryEnumerator<T>, T> CreateRowMapper()
        {
            var t = typeof(T);
            var constructor = t.GetConstructor(Type.EmptyTypes);
            var properties = t.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty);

            var thisParameter = Expression.Parameter(this.GetType(), "mapper");
            List<MemberBinding> bindings = new List<MemberBinding>();

            foreach (var property in properties)
            {
                if(property.GetCustomAttribute<NotMappedAttribute>() != null)
                {
                    continue;
                }
                if (!property.CanWrite)
                {
                    continue;
                }
                var columnName = property.Name;
                var columnAttribute = property.GetCustomAttribute<ColumnAttribute>();
                if(columnAttribute != null && !string.IsNullOrEmpty(columnAttribute.Name))
                {
                    columnName = columnAttribute.Name;
                }

                var columnValueReader = CreateColumnValueReader(thisParameter, columnName, property.PropertyType); 

                bindings.Add(Expression.Bind(property, columnValueReader));
            }
            var lambda = Expression.Lambda<Func<QueryEnumerator<T>, T>>(
                    Expression.MemberInit(
                        Expression.New(constructor),
                        bindings
                    ),
                    thisParameter);
            return lambda.Compile();
        }

        private Expression CreateColumnValueReader(ParameterExpression thisParameter, string name, Type propertyType)
        {
            var hasColumnCall = Expression.Call(
                thisParameter,
                hasColumnMethod,
                Expression.Constant(name)
            );
            var readValueCall = Expression.Convert(
                Expression.Call(
                    thisParameter,
                    readValueMethod,
                    Expression.Constant(name)
                ), 
                propertyType
            );
            var defaultValue = Expression.Default(propertyType);

            var columnValueReader = Expression.Condition(
                hasColumnCall,
                readValueCall,
                defaultValue
                );

            return columnValueReader;
        }

        private object ReadValue(string columnName)
        {
            return FilterDbNull(reader[columnMapping[columnName]]);
        }
        private bool HasColumn(string columnName)
        {

            if (columnMapping.ContainsKey(columnName))
            {
                return true;
            }
            return false;

        }
        static object FilterDbNull(object o)
        {
            return (o is DBNull) ? null : o;
        }
    }
}
