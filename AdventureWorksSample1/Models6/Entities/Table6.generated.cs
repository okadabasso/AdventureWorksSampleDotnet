using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models6
{
    [Table("dbo.table6")]
    public partial class Table6
    {
        public Table6()
        {
            Id = 0;
            Name = null;
            Table5Key1 = null;
            Table5Key2 = null;

        }

        ///<summary>column:id</summary>
        [Key]
        [Column("id", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        ///<summary>column:name</summary>
        [Column("name", Order = 1, TypeName = "nvarchar")]
        public string Name { get; set; }

        ///<summary>column:table5_key1</summary>
        [Column("table5_key1")]
        public int? Table5Key1 { get; set; }

        ///<summary>column:table5_key2</summary>
        [Column("table5_key2")]
        public int? Table5Key2 { get; set; }

        public virtual Table5 Table5 { get; set; }

    }
}
