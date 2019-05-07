
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("dbo.AWBuildVersion")]
    public partial class AWBuildVersion
    {
        public AWBuildVersion()
        {
            SystemInformationID = 0;
            Database_Version = null;
            VersionDate = DateTime.Parse("0001/01/01 0:00:00");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("SystemInformationID", Order = 0, TypeName = "tinyint")]
        public byte SystemInformationID { get; set; }

        [Required]
        [Column("Database Version", Order = 1, TypeName = "nvarchar")]
        [StringLength(25)]
        public string Database_Version { get; set; }

        [Column("VersionDate", Order = 2, TypeName = "datetime")]
        public DateTime VersionDate { get; set; }

        [Column("ModifiedDate", Order = 3, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

    }
}
