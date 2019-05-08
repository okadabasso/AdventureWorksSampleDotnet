using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace Sample.Entities
{
    public partial class UspLogError
    {
        private readonly SampleDbContext context;
        public UspLogError()
        {
            context = new SampleDbContext();
        }
        public UspLogError(SampleDbContext context)
        {
            this.context = context;
        }

        ///<summary>execute command dbo.uspLogError</summary>
        public int Execute(
            ref int? errorLogId
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};
            var p0 = new SqlParameter("@ErrorLogID",  errorLogId){ Direction = System.Data.ParameterDirection.InputOutput };

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [dbo].[uspLogError]
@ErrorLogID = @ErrorLogID",
                returnValue, 
                p0);

            errorLogId = (int?)p0.Value;
            return (int)returnValue.Value;
        }
        ///<summary>execute query dbo.uspLogError</summary>
        public IEnumerable<T> Query<T>(
            ref int? errorLogId
        )
        {
            var p0 = new SqlParameter("@ErrorLogID",  errorLogId){ Direction = System.Data.ParameterDirection.InputOutput };

            var result = context.Database.SqlQuery<T>(@"EXEC [dbo].[uspLogError]
@ErrorLogID = @ErrorLogID", 
                p0);

            errorLogId = (int?)p0.Value;
            return result;
        }

    }
}
