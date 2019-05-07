using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.Store")]
    public partial class Store
    {
        public Store()
        {
            BusinessEntityID = 0;
            Name = null;
            SalesPersonID = null;
            Demographics = null;
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            Customers = new HashSet<Customer>();

        }

        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityID { get; set; }

        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        public int? SalesPersonID { get; set; }

        [Column("Demographics", Order = 3, TypeName = "xml")]
        public string Demographics { get; set; }

        [Column("rowguid", Order = 4, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 5, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//Customer Store
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; }

        public virtual SalesPerson SalesPerson { get; set; }

    }
}
