
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("dbo.AWBuildVersion")]
    public partial class AwBuildVersion
    {
        public AwBuildVersion()
        {
            SystemInformationId = 0;
            DatabaseVersion = null;
            VersionDate = DateTime.Parse("0001/01/01 0:00:00");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>Primary key for AWBuildVersion records.</summary>
        [Key]
        [Column("SystemInformationID", Order = 0, TypeName = "tinyint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte SystemInformationId { get; set; }

        ///<summary>Version number of the database in 9.yy.mm.dd.00 format.</summary>
        [Required]
        [Column("Database Version", Order = 1, TypeName = "nvarchar")]
        [StringLength(25)]
        public string DatabaseVersion { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("VersionDate", Order = 2, TypeName = "datetime")]
        public DateTime VersionDate { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 3, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

    }
}
