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
        public JobCandidate()
        {
            JobCandidateID = 0;
            BusinessEntityID = null;
            Resume = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("JobCandidateID", Order = 0, TypeName = "int")]
        public int JobCandidateID { get; set; }

        public int? BusinessEntityID { get; set; }

        [Column("Resume", Order = 2, TypeName = "xml")]
        public string Resume { get; set; }

        [Column("ModifiedDate", Order = 3, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Employee Employee { get; set; }

    }
}
