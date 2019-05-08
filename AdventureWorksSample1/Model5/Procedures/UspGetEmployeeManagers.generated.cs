using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace Sample.Entities
{
    public partial class UspGetEmployeeManagers
    {
        private readonly SampleDbContext context;
        public UspGetEmployeeManagers()
        {
            context = new SampleDbContext();
        }
        public UspGetEmployeeManagers(SampleDbContext context)
        {
            this.context = context;
        }

        public int Execute(
            int? businessEntityId
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};
            var p0 = new SqlParameter("@BusinessEntityID",  businessEntityId);

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [dbo].[uspGetEmployeeManagers] @BusinessEntityID = @BusinessEntityID",
                returnValue, p0);

            return (int)returnValue.Value;
        }
        public IEnumerable<T> Query<T>(
            int? businessEntityId        )
        {
            var p0 = new SqlParameter("@BusinessEntityID",  businessEntityId);

            var result = context.Database.SqlQuery<T>(@"EXEC [dbo].[uspGetEmployeeManagers] @BusinessEntityID = @BusinessEntityID"
                , p0);

            return result;
        }

    }
}
