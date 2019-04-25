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
        [Key]
        [Column("CustomerID", Order = 1, TypeName = "int")]
        public int CustomerId { get; set; }
        [Column("PersonID", Order = 2, TypeName = "int")]
        public int? PersonId { get; set; }
        [Column("StoreID", Order = 3, TypeName = "int")]
        public int? StoreId { get; set; }
        [Column("TerritoryID", Order = 4, TypeName = "int")]
        public int? TerritoryId { get; set; }
        [Column("AccountNumber", Order = 5, TypeName = "varchar")]
        [StringLength(10)]
        public string AccountNumber { get; set; }
        [Column("rowguid", Order = 6, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }
        [Column("ModifiedDate", Order = 7, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public Customer()
        {
            CustomerId = 0;
            PersonId = null;
            StoreId = null;
            TerritoryId = null;
            AccountNumber = null;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
