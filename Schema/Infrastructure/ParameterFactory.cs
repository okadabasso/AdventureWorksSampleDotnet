using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Reflection;
namespace Schema.Infrastructure
{
    class ParameterFactory
    {
        static readonly ConcurrentDictionary<Type, List<Func<object, DbParameter>>> parameterMapperCache = new ConcurrentDictionary<Type, List<Func<object, DbParameter>>>();
        static Func<string, object, DbParameter> parameterConstructor;
        private readonly DbConnection connection;
        private DbProviderFactory providerFactory;
        private DbParameter dummy;
        public ParameterFactory(DbConnection connection)
        {
            this.connection = connection;
            this.providerFactory = DbProviderFactories.GetFactory(connection);
            this.dummy = this.providerFactory.CreateParameter();
        }
        public DbParameter CreateParamter(string name, object value){
            if(parameterConstructor == null)
            {
                parameterConstructor = CreateParameterConstructor();
            }
            var parameter = parameterConstructor.Invoke(name, value);
            return parameter;
        }
        public IEnumerable<DbParameter> CreateParameterList(object objectParameter)
        {
            var t = objectParameter.GetType();
            var paramterCreator = GetParameterMapperOrNew(t);

            var list = new List<DbParameter>();
            foreach(var creator  in paramterCreator)
            {
                var parameter = creator.Invoke(objectParameter);
                list.Add(parameter);
            }


            return list;
        }
        List<Func<object, DbParameter>> GetParameterMapperOrNew(Type objectParameterType)
        {
            if (parameterMapperCache.TryGetValue(objectParameterType, out var parameterMapper))
            {
                return parameterMapper;
            }
            parameterMapper = new List<Func<object, DbParameter>>();

            var sourceParameter = Expression.Parameter(typeof(object), "source");
            var properties = objectParameterType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty);
            foreach (var property in properties)
            {
                var propertyMapper = CreatePropertyMapper(objectParameterType, sourceParameter, property);

                parameterMapper.Add(propertyMapper);

            }
            parameterMapperCache.TryAdd(objectParameterType, parameterMapper);
            return parameterMapper;
        }
        Func<object, DbParameter> CreatePropertyMapper(Type objectParameterType, ParameterExpression sourceParameter, PropertyInfo property)
        {
            var constructor = dummy.GetType().GetConstructor(new Type[] { typeof(string), typeof(object) });
            var parameterName = "@" + property.Name;
            var initializer = Expression.New(constructor,
                Expression.Constant(parameterName),
                Expression.Convert(
                    Expression.Property(
                        Expression.Convert(
                            sourceParameter,
                            objectParameterType
                        ),
                        property
                    ),
                    typeof(object)
                )
            );
            var lambda = Expression.Lambda<Func<object, DbParameter>>(initializer, sourceParameter);
            return lambda.Compile();
        }

        Func<string, object, DbParameter> CreateParameterConstructor()
        {
            var constructor = dummy.GetType().GetConstructor(new Type[] { typeof(string), typeof(object) });
            var nameParameter = Expression.Parameter(typeof(string), "name");
            var valueParameter = Expression.Parameter(typeof(object), "value");
            var initializer = Expression.New(constructor,
                nameParameter,
                valueParameter
            );
            var lambda = Expression.Lambda<Func<string, object, DbParameter>>(initializer, nameParameter, valueParameter);
            return lambda.Compile();
        }
    }
}
