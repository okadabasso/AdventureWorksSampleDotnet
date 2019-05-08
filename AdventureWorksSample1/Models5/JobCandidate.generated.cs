using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("HumanResources.JobCandidate")]
    public partial class JobCandidate
    {
        public JobCandidate()
        {
            JobCandidateId = 0;
            BusinessEntityId = null;
            Resume = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>Primary key for JobCandidate records.</summary>
        [Key]
        [Column("JobCandidateID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobCandidateId { get; set; }

        ///<summary>Employee identification number if applicant was hired. Foreign key to Employee.BusinessEntityID.</summary>
        [Column("BusinessEntityID")]
        public int? BusinessEntityId { get; set; }

        ///<summary>Résumé in XML format.</summary>
        [Column("Resume", Order = 2, TypeName = "xml")]
        public string Resume { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 3, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Employee Employee { get; set; }

    }
}
