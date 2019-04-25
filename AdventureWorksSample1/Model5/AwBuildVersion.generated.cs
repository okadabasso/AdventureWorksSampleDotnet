
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
        [Key]
        [Column("SystemInformationID", Order = 1, TypeName = "tinyint")]
        public byte SystemInformationId { get; set; }
        [Column("Database Version", Order = 2, TypeName = "nvarchar")]
        [StringLength(25)]
        public string DatabaseVersion { get; set; }
        [Column("VersionDate", Order = 3, TypeName = "datetime")]
        public DateTime VersionDate { get; set; }
        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public AwBuildVersion()
        {
            SystemInformationId = 0;
            DatabaseVersion = null;
            VersionDate = DateTime.Parse("0001/01/01 0:00:00");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
