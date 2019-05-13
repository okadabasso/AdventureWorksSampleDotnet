using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("Customer", Schema="Sales")]
    public partial class Customer
    {
        public Customer()
        {
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();

        }

        ///<summary>Primary key.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("CustomerID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }

        ///<summary>Foreign key to Person.BusinessEntityID</summary>
        ///<remarks></remarks>
        [Column("PersonID")]
        public int? PersonId { get; set; }

        ///<summary>Foreign key to Store.BusinessEntityID</summary>
        ///<remarks></remarks>
        [Column("StoreID")]
        public int? StoreId { get; set; }

        ///<summary>ID of the territory in which the customer is located. Foreign key to SalesTerritory.SalesTerritoryID.</summary>
        ///<remarks></remarks>
        [Column("TerritoryID")]
        public int? TerritoryId { get; set; }

        ///<summary>Unique number identifying the customer assigned by the accounting system.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("AccountNumber", Order = 4)]
        [StringLength(10)]
        public string AccountNumber { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        ///<remarks></remarks>
        [Column("rowguid", Order = 5)]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 6)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

        public virtual Person Person { get; set; }

        public virtual SalesTerritory SalesTerritory { get; set; }

        public virtual Store Store { get; set; }

    }
}
