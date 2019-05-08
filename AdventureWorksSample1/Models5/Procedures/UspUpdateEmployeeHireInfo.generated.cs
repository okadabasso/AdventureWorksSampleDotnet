using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace AdventureWorks1.Models5
{
    public partial class UspUpdateEmployeeHireInfo
    {
        private readonly SampleDbContext  context;
        public UspUpdateEmployeeHireInfo()
        {
            context = new SampleDbContext ();
        }
        public UspUpdateEmployeeHireInfo(SampleDbContext  context)
        {
            this.context = context;
        }

        ///<summary>execute command HumanResources.uspUpdateEmployeeHireInfo</summary>
        public int Execute(
            int? businessEntityId, 
            string jobTitle, 
            DateTime? hireDate, 
            DateTime? rateChangeDate, 
            decimal? rate, 
            byte? payFrequency, 
            bool? currentFlag
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};
            var p0 = new SqlParameter("@BusinessEntityID",  businessEntityId);
            var p1 = new SqlParameter("@JobTitle",  jobTitle);
            var p2 = new SqlParameter("@HireDate",  hireDate);
            var p3 = new SqlParameter("@RateChangeDate",  rateChangeDate);
            var p4 = new SqlParameter("@Rate",  rate);
            var p5 = new SqlParameter("@PayFrequency",  payFrequency);
            var p6 = new SqlParameter("@CurrentFlag",  currentFlag);

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [HumanResources].[uspUpdateEmployeeHireInfo]
@BusinessEntityID = @BusinessEntityID,
@JobTitle = @JobTitle,
@HireDate = @HireDate,
@RateChangeDate = @RateChangeDate,
@Rate = @Rate,
@PayFrequency = @PayFrequency,
@CurrentFlag = @CurrentFlag",
                returnValue, 
                p0, 
                p1, 
                p2, 
                p3, 
                p4, 
                p5, 
                p6);

            return (int)returnValue.Value;
        }
        ///<summary>execute query HumanResources.uspUpdateEmployeeHireInfo</summary>
        public IEnumerable<T> Query<T>(
            int? businessEntityId, 
            string jobTitle, 
            DateTime? hireDate, 
            DateTime? rateChangeDate, 
            decimal? rate, 
            byte? payFrequency, 
            bool? currentFlag
        )
        {
            var p0 = new SqlParameter("@BusinessEntityID",  businessEntityId);
            var p1 = new SqlParameter("@JobTitle",  jobTitle);
            var p2 = new SqlParameter("@HireDate",  hireDate);
            var p3 = new SqlParameter("@RateChangeDate",  rateChangeDate);
            var p4 = new SqlParameter("@Rate",  rate);
            var p5 = new SqlParameter("@PayFrequency",  payFrequency);
            var p6 = new SqlParameter("@CurrentFlag",  currentFlag);

            var result = context.Database.SqlQuery<T>(@"EXEC [HumanResources].[uspUpdateEmployeeHireInfo]
@BusinessEntityID = @BusinessEntityID,
@JobTitle = @JobTitle,
@HireDate = @HireDate,
@RateChangeDate = @RateChangeDate,
@Rate = @Rate,
@PayFrequency = @PayFrequency,
@CurrentFlag = @CurrentFlag", 
                p0, 
                p1, 
                p2, 
                p3, 
                p4, 
                p5, 
                p6);

            return result;
        }

    }
}
