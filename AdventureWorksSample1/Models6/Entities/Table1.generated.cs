using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models6
{
    [Table("dbo.table1")]
    public partial class Table1
    {
        public Table1()
        {
            Id = 0;
            Name = null;
            Table2s = new HashSet<Table2>();
            Table3s = new HashSet<Table3>();
            Table4s = new HashSet<Table4>();

        }

        ///<summary>id</summary>
        [Key]
        [Column("id", Order = 0, TypeName = "bigint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        ///<summary>name</summary>
        [Required]
        [Column("name", Order = 1, TypeName = "nvarchar")]
        public string Name { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table2> Table2s { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table3> Table3s { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table4> Table4s { get; set; }

    }
}
