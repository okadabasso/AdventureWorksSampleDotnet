using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models6
{
    [Table("dbo.table5")]
    public partial class Table5
    {
        public Table5()
        {
            Key1 = 0;
            Key2 = 0;
            Name = null;
            Table6s = new HashSet<Table6>();
            Table7s = new HashSet<Table7>();

        }

        ///<summary>column:key1</summary>
        [Key]
        [Column("key1", Order = 0, TypeName = "int")]
        public int Key1 { get; set; }

        ///<summary>column:key2</summary>
        [Key]
        [Column("key2", Order = 1, TypeName = "int")]
        public int Key2 { get; set; }

        ///<summary>column:name</summary>
        [Column("name", Order = 2, TypeName = "nvarchar")]
        public string Name { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table6> Table6s { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table7> Table7s { get; set; }

    }
}
