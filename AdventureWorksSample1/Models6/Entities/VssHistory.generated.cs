using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models6
{
    [Table("dbo.vss_history")]
    public partial class VssHistory
    {
        public VssHistory()
        {
            Date = null;
            Time = null;
            CommitDate = null;
            File = null;
            Version = null;
            User = null;
            Comment = null;
            Gcount = null;

        }

        ///<summary>column:date</summary>
        [Key]
        [Column("date", Order = 0, TypeName = "char")]
        public string Date { get; set; }

        ///<summary>column:time</summary>
        [Column("time", Order = 1, TypeName = "char")]
        public string Time { get; set; }

        ///<summary>column:commit_date</summary>
        [Column("commit_date", Order = 2, TypeName = "datetime")]
        public DateTime? CommitDate { get; set; }

        ///<summary>column:file</summary>
        [Column("file", Order = 3, TypeName = "varchar")]
        public string File { get; set; }

        ///<summary>column:version</summary>
        [Column("version", Order = 4, TypeName = "bigint")]
        public long? Version { get; set; }

        ///<summary>column:user</summary>
        [Column("user", Order = 5, TypeName = "varchar")]
        public string User { get; set; }

        ///<summary>column:comment</summary>
        [Column("comment", Order = 6, TypeName = "nvarchar")]
        public string Comment { get; set; }

        ///<summary>column:gcount</summary>
        [Column("gcount", Order = 7, TypeName = "bigint")]
        public long? Gcount { get; set; }

    }
}
