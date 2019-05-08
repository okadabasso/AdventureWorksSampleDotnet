using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models6
{
    [Table("dbo.src_file")]
    public partial class SrcFile
    {
        public SrcFile()
        {
            Id = 0;
            DirectoryName = null;
            SourceFileName = null;

        }

        ///<summary>column:id</summary>
        [Key]
        [Column("id", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        ///<summary>column:directory_name</summary>
        [Column("directory_name", Order = 1, TypeName = "nvarchar")]
        public string DirectoryName { get; set; }

        ///<summary>column:source_file_name</summary>
        [Column("source_file_name", Order = 2, TypeName = "nvarchar")]
        public string SourceFileName { get; set; }

    }
}
