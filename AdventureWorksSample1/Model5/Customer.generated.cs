using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.Customer")]
    public partial class Customer
    {
        public Customer()
        {
            CustomerId = 0;
            PersonId = null;
            StoreId = null;
            TerritoryId = null;
            AccountNumber = null;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();

        }

        ///<summary>Primary key.</summary>
        [Key]
        [Column("CustomerID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }

        ///<summary>Foreign key to Person.BusinessEntityID</summary>
        public int? PersonId { get; set; }

        ///<summary>Foreign key to Store.BusinessEntityID</summary>
        public int? StoreId { get; set; }

        ///<summary>ID of the territory in which the customer is located. Foreign key to SalesTerritory.SalesTerritoryID.</summary>
        public int? TerritoryId { get; set; }

        ///<summary>Unique number identifying the customer assigned by the accounting system.</summary>
        [Required]
        [Column("AccountNumber", Order = 4, TypeName = "varchar")]
        [StringLength(10)]
        public string AccountNumber { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        [Column("rowguid", Order = 5, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 6, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

        public virtual Person Person { get; set; }

        public virtual SalesTerritory SalesTerritory { get; set; }

        public virtual Store Store { get; set; }

    }
}
