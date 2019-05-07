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
        public ErrorLog()
        {
            ErrorLogID = 0;
            ErrorTime = DateTime.Parse("0001/01/01 0:00:00");
            UserName = null;
            ErrorNumber = 0;
            ErrorSeverity = null;
            ErrorState = null;
            ErrorProcedure = null;
            ErrorLine = null;
            ErrorMessage = null;


        }

        [Key]
        [Column("ErrorLogID", Order = 0, TypeName = "int")]
        public int ErrorLogID { get; set; }

        [Column("ErrorTime", Order = 1, TypeName = "datetime")]
        public DateTime ErrorTime { get; set; }

        [Required]
        [Column("UserName", Order = 2, TypeName = "nvarchar")]
        [StringLength(128)]
        public string UserName { get; set; }

        [Column("ErrorNumber", Order = 3, TypeName = "int")]
        public int ErrorNumber { get; set; }

        [Column("ErrorSeverity", Order = 4, TypeName = "int")]
        public int? ErrorSeverity { get; set; }

        [Column("ErrorState", Order = 5, TypeName = "int")]
        public int? ErrorState { get; set; }

        [Column("ErrorProcedure", Order = 6, TypeName = "nvarchar")]
        [StringLength(126)]
        public string ErrorProcedure { get; set; }

        [Column("ErrorLine", Order = 7, TypeName = "int")]
        public int? ErrorLine { get; set; }

        [Required]
        [Column("ErrorMessage", Order = 8, TypeName = "nvarchar")]
        [StringLength(4000)]
        public string ErrorMessage { get; set; }

    }
}
