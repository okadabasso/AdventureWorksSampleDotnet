using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("dbo.DatabaseLog")]
    public partial class DatabaseLog
    {
        public DatabaseLog()
        {
            DatabaseLogID = 0;
            PostTime = DateTime.Parse("0001/01/01 0:00:00");
            DatabaseUser = null;
            Event = null;
            Schema = null;
            Object = null;
            TSQL = null;
            XmlEvent = null;


        }

        [Key]
        [Column("DatabaseLogID", Order = 0, TypeName = "int")]
        public int DatabaseLogID { get; set; }

        [Column("PostTime", Order = 1, TypeName = "datetime")]
        public DateTime PostTime { get; set; }

        [Required]
        [Column("DatabaseUser", Order = 2, TypeName = "nvarchar")]
        [StringLength(128)]
        public string DatabaseUser { get; set; }

        [Required]
        [Column("Event", Order = 3, TypeName = "nvarchar")]
        [StringLength(128)]
        public string Event { get; set; }

        [Column("Schema", Order = 4, TypeName = "nvarchar")]
        [StringLength(128)]
        public string Schema { get; set; }

        [Column("Object", Order = 5, TypeName = "nvarchar")]
        [StringLength(128)]
        public string Object { get; set; }

        [Required]
        [Column("TSQL", Order = 6, TypeName = "nvarchar")]
        public string TSQL { get; set; }

        [Required]
        [Column("XmlEvent", Order = 7, TypeName = "xml")]
        public string XmlEvent { get; set; }

    }
}
