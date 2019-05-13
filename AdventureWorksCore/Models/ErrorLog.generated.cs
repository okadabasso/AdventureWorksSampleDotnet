using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("ErrorLog", Schema="dbo")]
    public partial class ErrorLog
    {
        public ErrorLog()
        {

        }

        ///<summary>Primary key for ErrorLog records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("ErrorLogID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ErrorLogId { get; set; }

        ///<summary>The date and time at which the error occurred.</summary>
        ///<remarks></remarks>
        [Column("ErrorTime", Order = 1)]
        public DateTime ErrorTime { get; set; }

        ///<summary>The user who executed the batch in which the error occurred.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("UserName", Order = 2)]
        [StringLength(128)]
        public string UserName { get; set; }

        ///<summary>The error number of the error that occurred.</summary>
        ///<remarks></remarks>
        [Column("ErrorNumber", Order = 3)]
        public int ErrorNumber { get; set; }

        ///<summary>The severity of the error that occurred.</summary>
        ///<remarks></remarks>
        [Column("ErrorSeverity", Order = 4)]
        public int? ErrorSeverity { get; set; }

        ///<summary>The state number of the error that occurred.</summary>
        ///<remarks></remarks>
        [Column("ErrorState", Order = 5)]
        public int? ErrorState { get; set; }

        ///<summary>The name of the stored procedure or trigger where the error occurred.</summary>
        ///<remarks></remarks>
        [Column("ErrorProcedure", Order = 6)]
        [StringLength(126)]
        public string ErrorProcedure { get; set; }

        ///<summary>The line number at which the error occurred.</summary>
        ///<remarks></remarks>
        [Column("ErrorLine", Order = 7)]
        public int? ErrorLine { get; set; }

        ///<summary>The message text of the error that occurred.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("ErrorMessage", Order = 8)]
        [StringLength(4000)]
        public string ErrorMessage { get; set; }

    }
}
