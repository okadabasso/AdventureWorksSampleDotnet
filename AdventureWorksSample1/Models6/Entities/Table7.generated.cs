using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models6
{
    [Table("dbo.table7")]
    public partial class Table7
    {
        public Table7()
        {
            Id = 0;
            Name = null;
            Table5bKey1 = null;
            Table5bKey2 = null;

        }

        ///<summary>column:id</summary>
        [Key]
        [Column("id", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        ///<summary>column:name</summary>
        [Column("name", Order = 1, TypeName = "nvarchar")]
        public string Name { get; set; }

        ///<summary>column:table5b_key1</summary>
        [Column("table5b_key1")]
        public int? Table5bKey1 { get; set; }

        ///<summary>column:table5b_key2</summary>
        [Column("table5b_key2")]
        public int? Table5bKey2 { get; set; }

        public virtual Table5b Table5b { get; set; }

        public virtual Table5b Table5b1 { get; set; }

        public virtual Table5 Table5 { get; set; }

    }
}
