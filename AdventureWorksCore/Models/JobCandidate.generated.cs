using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("JobCandidate", Schema="HumanResources")]
    public partial class JobCandidate
    {
        public JobCandidate()
        {

        }

        ///<summary>Primary key for JobCandidate records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("JobCandidateID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobCandidateId { get; set; }

        ///<summary>Employee identification number if applicant was hired. Foreign key to Employee.BusinessEntityID.</summary>
        ///<remarks></remarks>
        [Column("BusinessEntityID")]
        public int? BusinessEntityId { get; set; }

        ///<summary>Résumé in XML format.</summary>
        ///<remarks></remarks>
        [Column("Resume", Order = 2)]
        public string Resume { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 3)]
        public DateTime ModifiedDate { get; set; }

        public virtual Employee Employee { get; set; }

    }
}
