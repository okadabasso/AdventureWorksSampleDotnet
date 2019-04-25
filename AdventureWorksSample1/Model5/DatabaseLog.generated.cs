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
        [Key]
        [Column("DatabaseLogID", Order = 1, TypeName = "int")]
        public int DatabaseLogId { get; set; }
        [Column("PostTime", Order = 2, TypeName = "datetime")]
        public DateTime PostTime { get; set; }
        [Column("DatabaseUser", Order = 3, TypeName = "nvarchar")]
        [StringLength(128)]
        public string DatabaseUser { get; set; }
        [Column("Event", Order = 4, TypeName = "nvarchar")]
        [StringLength(128)]
        public string Event { get; set; }
        [Column("Schema", Order = 5, TypeName = "nvarchar")]
        [StringLength(128)]
        public string Schema { get; set; }
        [Column("Object", Order = 6, TypeName = "nvarchar")]
        [StringLength(128)]
        public string Object { get; set; }
        [Column("TSQL", Order = 7, TypeName = "nvarchar")]
        public string Tsql { get; set; }
        [Column("XmlEvent", Order = 8, TypeName = "xml")]
        public object XmlEvent { get; set; }
        public DatabaseLog()
        {
            DatabaseLogId = 0;
            PostTime = DateTime.Parse("0001/01/01 0:00:00");
            DatabaseUser = null;
            Event = null;
            Schema = null;
            Object = null;
            Tsql = null;
            XmlEvent = null;
        }
    }
}
