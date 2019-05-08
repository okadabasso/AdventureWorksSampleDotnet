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
    public partial class SeqSampleTable1
    {
        private readonly SampleDbContext context;
        public SeqSampleTable1()
        {
            context = new SampleDbContext();
        }
        public SeqSampleTable1(SampleDbContext context)
        {
            this.context = context;
        }

        ///<summary>execute query dbo.seq_sample_table1</summary>
        public long NextValue()
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.Output, DbType =DbType.Int64 };
            var affected = context.Database.ExecuteSqlCommand(@"SELECT @return_value = NEXT VALUE FOR [dbo].[seq_sample_table1]", returnValue);

             return (long)returnValue.Value;
        }

    }
}
