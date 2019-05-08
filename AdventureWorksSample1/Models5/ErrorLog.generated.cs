using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("dbo.ErrorLog")]
    public partial class ErrorLog
    {
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

        ///<summary>Primary key for ErrorLog records.</summary>
        [Key]
        [Column("ErrorLogID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ErrorLogId { get; set; }

        ///<summary>The date and time at which the error occurred.</summary>
        [Column("ErrorTime", Order = 1, TypeName = "datetime")]
        public DateTime ErrorTime { get; set; }

        ///<summary>The user who executed the batch in which the error occurred.</summary>
        [Required]
        [Column("UserName", Order = 2, TypeName = "nvarchar")]
        [StringLength(128)]
        public string UserName { get; set; }

        ///<summary>The error number of the error that occurred.</summary>
        [Column("ErrorNumber", Order = 3, TypeName = "int")]
        public int ErrorNumber { get; set; }

        ///<summary>The severity of the error that occurred.</summary>
        [Column("ErrorSeverity", Order = 4, TypeName = "int")]
        public int? ErrorSeverity { get; set; }

        ///<summary>The state number of the error that occurred.</summary>
        [Column("ErrorState", Order = 5, TypeName = "int")]
        public int? ErrorState { get; set; }

        ///<summary>The name of the stored procedure or trigger where the error occurred.</summary>
        [Column("ErrorProcedure", Order = 6, TypeName = "nvarchar")]
        [StringLength(126)]
        public string ErrorProcedure { get; set; }

        ///<summary>The line number at which the error occurred.</summary>
        [Column("ErrorLine", Order = 7, TypeName = "int")]
        public int? ErrorLine { get; set; }

        ///<summary>The message text of the error that occurred.</summary>
        [Required]
        [Column("ErrorMessage", Order = 8, TypeName = "nvarchar")]
        [StringLength(4000)]
        public string ErrorMessage { get; set; }

    }
}
