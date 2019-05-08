using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace Sample.Entities
{
    public partial class SpDeletepersonTemporal
    {
        private readonly SampleDbContext context;
        public SpDeletepersonTemporal()
        {
            context = new SampleDbContext();
        }
        public SpDeletepersonTemporal(SampleDbContext context)
        {
            this.context = context;
        }

        ///<summary>execute command Person.sp_DeletePerson_Temporal</summary>
        public int Execute(
            int? businessEntityId
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};
            var p0 = new SqlParameter("@BusinessEntityID",  businessEntityId);

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [Person].[sp_DeletePerson_Temporal]
@BusinessEntityID = @BusinessEntityID",
                returnValue, 
                p0);

            return (int)returnValue.Value;
        }
        ///<summary>execute query Person.sp_DeletePerson_Temporal</summary>
        public IEnumerable<T> Query<T>(
            int? businessEntityId
        )
        {
            var p0 = new SqlParameter("@BusinessEntityID",  businessEntityId);

            var result = context.Database.SqlQuery<T>(@"EXEC [Person].[sp_DeletePerson_Temporal]
@BusinessEntityID = @BusinessEntityID", 
                p0);

            return result;
        }

    }
}
