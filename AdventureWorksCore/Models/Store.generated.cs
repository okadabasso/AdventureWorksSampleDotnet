using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("Store", Schema="Sales")]
    public partial class Store
    {
        public Store()
        {
            Customers = new HashSet<Customer>();

        }

        ///<summary>Primary key. Foreign key to Customer.BusinessEntityID.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("BusinessEntityID", Order = 0)]
        public int BusinessEntityId { get; set; }

        ///<summary>Name of the store.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Name", Order = 1)]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>ID of the sales person assigned to the customer. Foreign key to SalesPerson.BusinessEntityID.</summary>
        ///<remarks></remarks>
        [Column("SalesPersonID")]
        public int? SalesPersonId { get; set; }

        ///<summary>Demographic informationg about the store such as the number of employees, annual sales and store type.</summary>
        ///<remarks></remarks>
        [Column("Demographics", Order = 3)]
        public string Demographics { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        ///<remarks></remarks>
        [Column("rowguid", Order = 4)]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 5)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; }

        public virtual SalesPerson SalesPerson { get; set; }

    }
}
