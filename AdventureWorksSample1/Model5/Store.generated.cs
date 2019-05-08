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
            BusinessEntityId = 0;
            Name = null;
            SalesPersonId = null;
            Demographics = null;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            Customers = new HashSet<Customer>();

        }

        ///<summary>Primary key. Foreign key to Customer.BusinessEntityID.</summary>
        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityId { get; set; }

        ///<summary>Name of the store.</summary>
        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>ID of the sales person assigned to the customer. Foreign key to SalesPerson.BusinessEntityID.</summary>
        public int? SalesPersonId { get; set; }

        ///<summary>Demographic informationg about the store such as the number of employees, annual sales and store type.</summary>
        [Column("Demographics", Order = 3, TypeName = "xml")]
        public string Demographics { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        [Column("rowguid", Order = 4, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 5, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; }

        public virtual SalesPerson SalesPerson { get; set; }

    }
}
