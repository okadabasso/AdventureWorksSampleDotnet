using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("HumanResources.JobCandidate")]
    public partial class JobCandidate
    {
        [Key]
        [Column("JobCandidateID", Order = 1, TypeName = "int")]
        public int JobCandidateId { get; set; }
        [Column("BusinessEntityID", Order = 2, TypeName = "int")]
        public int? BusinessEntityId { get; set; }
        [Column("Resume", Order = 3, TypeName = "xml")]
        public object Resume { get; set; }
        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public JobCandidate()
        {
            JobCandidateId = 0;
            BusinessEntityId = null;
            Resume = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
