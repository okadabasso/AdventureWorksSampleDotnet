using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace AdventureWorks1.Models5
{
    public partial class SpUpdateemployeeTemporal
    {
        private readonly SampleDbContext  context;
        public SpUpdateemployeeTemporal()
        {
            context = new SampleDbContext ();
        }
        public SpUpdateemployeeTemporal(SampleDbContext  context)
        {
            this.context = context;
        }

        ///<summary>execute command HumanResources.sp_UpdateEmployee_Temporal</summary>
        public int Execute(
            int? businessEntityId, 
            string loginId, 
            string jobTitle, 
            string maritalStatus, 
            string gender, 
            short? vacationHours, 
            short? sickLeaveHours
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};
            var p0 = new SqlParameter("@BusinessEntityID",  businessEntityId);
            var p1 = new SqlParameter("@LoginID",  loginId);
            var p2 = new SqlParameter("@JobTitle",  jobTitle);
            var p3 = new SqlParameter("@MaritalStatus",  maritalStatus);
            var p4 = new SqlParameter("@Gender",  gender);
            var p5 = new SqlParameter("@VacationHours",  vacationHours);
            var p6 = new SqlParameter("@SickLeaveHours",  sickLeaveHours);

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [HumanResources].[sp_UpdateEmployee_Temporal]
@BusinessEntityID = @BusinessEntityID,
@LoginID = @LoginID,
@JobTitle = @JobTitle,
@MaritalStatus = @MaritalStatus,
@Gender = @Gender,
@VacationHours = @VacationHours,
@SickLeaveHours = @SickLeaveHours",
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
        ///<summary>execute query HumanResources.sp_UpdateEmployee_Temporal</summary>
        public IEnumerable<T> Query<T>(
            int? businessEntityId, 
            string loginId, 
            string jobTitle, 
            string maritalStatus, 
            string gender, 
            short? vacationHours, 
            short? sickLeaveHours
        )
        {
            var p0 = new SqlParameter("@BusinessEntityID",  businessEntityId);
            var p1 = new SqlParameter("@LoginID",  loginId);
            var p2 = new SqlParameter("@JobTitle",  jobTitle);
            var p3 = new SqlParameter("@MaritalStatus",  maritalStatus);
            var p4 = new SqlParameter("@Gender",  gender);
            var p5 = new SqlParameter("@VacationHours",  vacationHours);
            var p6 = new SqlParameter("@SickLeaveHours",  sickLeaveHours);

            var result = context.Database.SqlQuery<T>(@"EXEC [HumanResources].[sp_UpdateEmployee_Temporal]
@BusinessEntityID = @BusinessEntityID,
@LoginID = @LoginID,
@JobTitle = @JobTitle,
@MaritalStatus = @MaritalStatus,
@Gender = @Gender,
@VacationHours = @VacationHours,
@SickLeaveHours = @SickLeaveHours", 
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
