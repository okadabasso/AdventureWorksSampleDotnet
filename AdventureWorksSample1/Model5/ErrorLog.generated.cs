using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("dbo.ErrorLog")]
    public partial class ErrorLog
    {
        [Key]
        [Column("ErrorLogID", Order = 1, TypeName = "int")]
        public int ErrorLogId { get; set; }
        [Column("ErrorTime", Order = 2, TypeName = "datetime")]
        public DateTime ErrorTime { get; set; }
        [Column("UserName", Order = 3, TypeName = "nvarchar")]
        [StringLength(128)]
        public string UserName { get; set; }
        [Column("ErrorNumber", Order = 4, TypeName = "int")]
        public int ErrorNumber { get; set; }
        [Column("ErrorSeverity", Order = 5, TypeName = "int")]
        public int? ErrorSeverity { get; set; }
        [Column("ErrorState", Order = 6, TypeName = "int")]
        public int? ErrorState { get; set; }
        [Column("ErrorProcedure", Order = 7, TypeName = "nvarchar")]
        [StringLength(126)]
        public string ErrorProcedure { get; set; }
        [Column("ErrorLine", Order = 8, TypeName = "int")]
        public int? ErrorLine { get; set; }
        [Column("ErrorMessage", Order = 9, TypeName = "nvarchar")]
        [StringLength(4000)]
        public string ErrorMessage { get; set; }
        public ErrorLog()
        {
            ErrorLogId = 0;
            ErrorTime = DateTime.Parse("0001/01/01 0:00:00");
            UserName = null;
            ErrorNumber = 0;
            ErrorSeverity = null;
            ErrorState = null;
            ErrorProcedure = null;
            ErrorLine = null;
            ErrorMessage = null;
        }
    }
}
