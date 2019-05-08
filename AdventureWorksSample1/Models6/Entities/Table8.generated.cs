using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models6
{
    [Table("dbo.table8")]
    public partial class Table8
    {
        public Table8()
        {
            Id = 0;
            Code = null;

        }

        ///<summary>column:id</summary>
        [Key]
        [Column("id", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        ///<summary>column:code</summary>
        [Column("code", Order = 1, TypeName = "char")]
        public string Code { get; set; }

    }
}
