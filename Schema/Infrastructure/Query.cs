using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace Schema.Infrastructure
{
    public class Query<T> : IEnumerable<T>
    {
        private DbConnection connection;
        private DbCommand command;
        private readonly string text;
        private readonly object[] parameters;
        public Query(DbConnection connection)
        {
            this.connection = connection;
        }
        public Query(DbConnection connection, string text, params object[] parameters)
        {
            this.connection = connection;
            this.text = text;
            this.parameters = parameters;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return CreateEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return CreateEnumerator();
        }
        private IEnumerator<T> CreateEnumerator()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            if(command == null)
            {
                BuildCommand();
            }

            var enumerator = new QueryEnumerator<T>(command.ExecuteReader());
            return enumerator;
        }

        private void BuildCommand()
        {
            command = connection.CreateCommand();
            BuildCommandText();
            BuildCommandParameters();
        }

        private void BuildCommandText()
        {
            command.CommandText = text;
        }
        private void BuildCommandParameters()
        {
            var parameterFactory = new ParameterFactory(connection);
            int parameterCount = 0;
            foreach (var parameter in parameters)
            {
                if (parameter is DbParameter)
                {
                    command.Parameters.Add(parameter as DbParameter);
                    continue;
                }
                var parameterType = parameter.GetType();
                if (parameter is DateTime || parameter is DateTimeOffset || parameter is string || parameterType.IsPrimitive)
                {
                    var dbParameter = parameterFactory.CreateParamter("@p" + parameterCount.ToString(), parameter);
                    command.Parameters.Add(dbParameter);

                    ++parameterCount;
                    continue;
                }

                command.Parameters.AddRange(parameterFactory.CreateParameterList(parameter).ToArray());
            }
        }
    }
}
