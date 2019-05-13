using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("AWBuildVersion", Schema="dbo")]
    public partial class AwBuildVersion
    {
        public AwBuildVersion()
        {

        }

        ///<summary>Primary key for AWBuildVersion records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("SystemInformationID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte SystemInformationId { get; set; }

        ///<summary>Version number of the database in 9.yy.mm.dd.00 format.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Database Version", Order = 1)]
        [StringLength(25)]
        public string DatabaseVersion { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("VersionDate", Order = 2)]
        public DateTime VersionDate { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 3)]
        public DateTime ModifiedDate { get; set; }

    }
}
