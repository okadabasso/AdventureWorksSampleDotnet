using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models6
{
    [Table("dbo.table5b")]
    public partial class Table5b
    {
        public Table5b()
        {
            Key1 = 0;
            Name = null;
            Table7s = new HashSet<Table7>();
            Table7s1 = new HashSet<Table7>();

        }

        ///<summary>column:key1</summary>
        [Key]
        [Column("key1", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Key1 { get; set; }

        ///<summary>column:name</summary>
        [Required]
        [Column("name", Order = 1, TypeName = "nvarchar")]
        public string Name { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table7> Table7s { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table7> Table7s1 { get; set; }

    }
}
