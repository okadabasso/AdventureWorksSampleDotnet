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
            CustomerID = 0;
            PersonID = null;
            StoreID = null;
            TerritoryID = null;
            AccountNumber = null;
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            SalesOrderHeaders = new HashSet<SalesOrderHeader>();

        }

        [Key]
        [Column("CustomerID", Order = 0, TypeName = "int")]
        public int CustomerID { get; set; }

        public int? PersonID { get; set; }

        public int? StoreID { get; set; }

        public int? TerritoryID { get; set; }

        [Required]
        [Column("AccountNumber", Order = 4, TypeName = "varchar")]
        [StringLength(10)]
        public string AccountNumber { get; set; }

        [Column("rowguid", Order = 5, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 6, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//SalesOrderHeader Customer
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

        public virtual Person Person { get; set; }

        public virtual SalesTerritory SalesTerritory { get; set; }

        public virtual Store Store { get; set; }

    }
}
