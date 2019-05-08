using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace AdventureWorks1.Models5
{
    public partial class UspUpdateEmployeeLogin
    {
        private readonly SampleDbContext  context;
        public UspUpdateEmployeeLogin()
        {
            context = new SampleDbContext ();
        }
        public UspUpdateEmployeeLogin(SampleDbContext  context)
        {
            this.context = context;
        }

        ///<summary>execute command HumanResources.uspUpdateEmployeeLogin</summary>
        public int Execute(
            int? businessEntityId, 
            byte[] organizationNode, 
            string loginId, 
            string jobTitle, 
            DateTime? hireDate, 
            bool? currentFlag
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};
            var p0 = new SqlParameter("@BusinessEntityID",  businessEntityId);
            var p1 = new SqlParameter("@OrganizationNode",  organizationNode);
            var p2 = new SqlParameter("@LoginID",  loginId);
            var p3 = new SqlParameter("@JobTitle",  jobTitle);
            var p4 = new SqlParameter("@HireDate",  hireDate);
            var p5 = new SqlParameter("@CurrentFlag",  currentFlag);

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [HumanResources].[uspUpdateEmployeeLogin]
@BusinessEntityID = @BusinessEntityID,
@OrganizationNode = @OrganizationNode,
@LoginID = @LoginID,
@JobTitle = @JobTitle,
@HireDate = @HireDate,
@CurrentFlag = @CurrentFlag",
                returnValue, 
                p0, 
                p1, 
                p2, 
                p3, 
                p4, 
                p5);

            return (int)returnValue.Value;
        }
        ///<summary>execute query HumanResources.uspUpdateEmployeeLogin</summary>
        public IEnumerable<T> Query<T>(
            int? businessEntityId, 
            byte[] organizationNode, 
            string loginId, 
            string jobTitle, 
            DateTime? hireDate, 
            bool? currentFlag
        )
        {
            var p0 = new SqlParameter("@BusinessEntityID",  businessEntityId);
            var p1 = new SqlParameter("@OrganizationNode",  organizationNode);
            var p2 = new SqlParameter("@LoginID",  loginId);
            var p3 = new SqlParameter("@JobTitle",  jobTitle);
            var p4 = new SqlParameter("@HireDate",  hireDate);
            var p5 = new SqlParameter("@CurrentFlag",  currentFlag);

            var result = context.Database.SqlQuery<T>(@"EXEC [HumanResources].[uspUpdateEmployeeLogin]
@BusinessEntityID = @BusinessEntityID,
@OrganizationNode = @OrganizationNode,
@LoginID = @LoginID,
@JobTitle = @JobTitle,
@HireDate = @HireDate,
@CurrentFlag = @CurrentFlag", 
                p0, 
                p1, 
                p2, 
                p3, 
                p4, 
                p5);

            return result;
        }

    }
}
