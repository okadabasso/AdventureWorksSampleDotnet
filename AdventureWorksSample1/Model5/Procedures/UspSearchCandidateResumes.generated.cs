using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace Sample.Entities
{
    public partial class UspSearchCandidateResumes
    {
        private readonly SampleDbContext context;
        public UspSearchCandidateResumes()
        {
            context = new SampleDbContext();
        }
        public UspSearchCandidateResumes(SampleDbContext context)
        {
            this.context = context;
        }

        ///<summary>execute command dbo.uspSearchCandidateResumes</summary>
        public int Execute(
            string searchString, 
            bool? useInflectional, 
            bool? useThesaurus, 
            int? language
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};
            var p0 = new SqlParameter("@searchString",  searchString);
            var p1 = new SqlParameter("@useInflectional",  useInflectional);
            var p2 = new SqlParameter("@useThesaurus",  useThesaurus);
            var p3 = new SqlParameter("@language",  language);

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [dbo].[uspSearchCandidateResumes]
@searchString = @searchString,
@useInflectional = @useInflectional,
@useThesaurus = @useThesaurus,
@language = @language",
                returnValue, 
                p0, 
                p1, 
                p2, 
                p3);

            return (int)returnValue.Value;
        }
        ///<summary>execute query dbo.uspSearchCandidateResumes</summary>
        public IEnumerable<T> Query<T>(
            string searchString, 
            bool? useInflectional, 
            bool? useThesaurus, 
            int? language
        )
        {
            var p0 = new SqlParameter("@searchString",  searchString);
            var p1 = new SqlParameter("@useInflectional",  useInflectional);
            var p2 = new SqlParameter("@useThesaurus",  useThesaurus);
            var p3 = new SqlParameter("@language",  language);

            var result = context.Database.SqlQuery<T>(@"EXEC [dbo].[uspSearchCandidateResumes]
@searchString = @searchString,
@useInflectional = @useInflectional,
@useThesaurus = @useThesaurus,
@language = @language", 
                p0, 
                p1, 
                p2, 
                p3);

            return result;
        }

    }
}
