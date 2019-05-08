using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace Sample.Entities
{
    public partial class UspUpdateEmployeePersonalInfo
    {
        private readonly SampleDbContext context;
        public UspUpdateEmployeePersonalInfo()
        {
            context = new SampleDbContext();
        }
        public UspUpdateEmployeePersonalInfo(SampleDbContext context)
        {
            this.context = context;
        }

        public int Execute(
            int? businessEntityId, 
            string nationalIdNumber, 
            DateTime? birthDate, 
            string maritalStatus, 
            string gender
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};
            var p0 = new SqlParameter("@BusinessEntityID",  businessEntityId);
            var p1 = new SqlParameter("@NationalIDNumber",  nationalIdNumber);
            var p2 = new SqlParameter("@BirthDate",  birthDate);
            var p3 = new SqlParameter("@MaritalStatus",  maritalStatus);
            var p4 = new SqlParameter("@Gender",  gender);

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [HumanResources].[uspUpdateEmployeePersonalInfo] @BusinessEntityID = @BusinessEntityID, @NationalIDNumber = @NationalIDNumber, @BirthDate = @BirthDate, @MaritalStatus = @MaritalStatus, @Gender = @Gender",
                returnValue, p0, p1, p2, p3, p4);

            return (int)returnValue.Value;
        }
        public IEnumerable<T> Query<T>(
            int? businessEntityId, 
            string nationalIdNumber, 
            DateTime? birthDate, 
            string maritalStatus, 
            string gender        )
        {
            var p0 = new SqlParameter("@BusinessEntityID",  businessEntityId);
            var p1 = new SqlParameter("@NationalIDNumber",  nationalIdNumber);
            var p2 = new SqlParameter("@BirthDate",  birthDate);
            var p3 = new SqlParameter("@MaritalStatus",  maritalStatus);
            var p4 = new SqlParameter("@Gender",  gender);

            var result = context.Database.SqlQuery<T>(@"EXEC [HumanResources].[uspUpdateEmployeePersonalInfo] @BusinessEntityID = @BusinessEntityID, @NationalIDNumber = @NationalIDNumber, @BirthDate = @BirthDate, @MaritalStatus = @MaritalStatus, @Gender = @Gender"
                , p0, p1, p2, p3, p4);

            return result;
        }

    }
}
