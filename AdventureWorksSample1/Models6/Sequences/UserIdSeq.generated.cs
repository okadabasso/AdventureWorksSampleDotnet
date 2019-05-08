using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
namespace AdventureWorks1.Models6
{
    public partial class UserIdSeq
    {
        private readonly SampleDbContext context;
        public UserIdSeq()
        {
            context = new SampleDbContext();
        }
        public UserIdSeq(SampleDbContext context)
        {
            this.context = context;
        }

        ///<summary>execute query dbo.UserIdSeq</summary>
        public long NextValue()
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.Output, DbType =DbType.Int64 };
            var affected = context.Database.ExecuteSqlCommand(@"SELECT @return_value = NEXT VALUE FOR [dbo].[UserIdSeq]", returnValue);

             return (long)returnValue.Value;
        }

    }
}
