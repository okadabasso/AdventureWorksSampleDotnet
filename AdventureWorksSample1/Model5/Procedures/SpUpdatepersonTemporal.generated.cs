using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace Sample.Entities
{
    public partial class SpUpdatepersonTemporal
    {
        private readonly SampleDbContext context;
        public SpUpdatepersonTemporal()
        {
            context = new SampleDbContext();
        }
        public SpUpdatepersonTemporal(SampleDbContext context)
        {
            this.context = context;
        }

        ///<summary>execute command Person.sp_UpdatePerson_Temporal</summary>
        public int Execute(
            int? businessEntityId, 
            string personType, 
            string title, 
            string firstName, 
            string middleName, 
            string lastName, 
            string suffix, 
            short? emailPromotion
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};
            var p0 = new SqlParameter("@BusinessEntityID",  businessEntityId);
            var p1 = new SqlParameter("@PersonType",  personType);
            var p2 = new SqlParameter("@Title",  title);
            var p3 = new SqlParameter("@FirstName",  firstName);
            var p4 = new SqlParameter("@MiddleName",  middleName);
            var p5 = new SqlParameter("@LastName",  lastName);
            var p6 = new SqlParameter("@Suffix",  suffix);
            var p7 = new SqlParameter("@EmailPromotion",  emailPromotion);

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [Person].[sp_UpdatePerson_Temporal]
@BusinessEntityID = @BusinessEntityID,
@PersonType = @PersonType,
@Title = @Title,
@FirstName = @FirstName,
@MiddleName = @MiddleName,
@LastName = @LastName,
@Suffix = @Suffix,
@EmailPromotion = @EmailPromotion",
                returnValue, 
                p0, 
                p1, 
                p2, 
                p3, 
                p4, 
                p5, 
                p6, 
                p7);

            return (int)returnValue.Value;
        }
        ///<summary>execute query Person.sp_UpdatePerson_Temporal</summary>
        public IEnumerable<T> Query<T>(
            int? businessEntityId, 
            string personType, 
            string title, 
            string firstName, 
            string middleName, 
            string lastName, 
            string suffix, 
            short? emailPromotion
        )
        {
            var p0 = new SqlParameter("@BusinessEntityID",  businessEntityId);
            var p1 = new SqlParameter("@PersonType",  personType);
            var p2 = new SqlParameter("@Title",  title);
            var p3 = new SqlParameter("@FirstName",  firstName);
            var p4 = new SqlParameter("@MiddleName",  middleName);
            var p5 = new SqlParameter("@LastName",  lastName);
            var p6 = new SqlParameter("@Suffix",  suffix);
            var p7 = new SqlParameter("@EmailPromotion",  emailPromotion);

            var result = context.Database.SqlQuery<T>(@"EXEC [Person].[sp_UpdatePerson_Temporal]
@BusinessEntityID = @BusinessEntityID,
@PersonType = @PersonType,
@Title = @Title,
@FirstName = @FirstName,
@MiddleName = @MiddleName,
@LastName = @LastName,
@Suffix = @Suffix,
@EmailPromotion = @EmailPromotion", 
                p0, 
                p1, 
                p2, 
                p3, 
                p4, 
                p5, 
                p6, 
                p7);

            return result;
        }

    }
}
