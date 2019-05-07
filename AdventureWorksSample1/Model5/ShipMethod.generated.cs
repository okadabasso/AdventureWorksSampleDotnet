using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Purchasing.ShipMethod")]
    public partial class ShipMethod
    {
        public ShipMethod()
        {
            ShipMethodID = 0;
            Name = null;
            ShipBase = 0;
            ShipRate = 0;
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            PurchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();

        }

        [Key]
        [Column("ShipMethodID", Order = 0, TypeName = "int")]
        public int ShipMethodID { get; set; }

        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("ShipBase", Order = 2, TypeName = "money")]
        public decimal ShipBase { get; set; }

        [Column("ShipRate", Order = 3, TypeName = "money")]
        public decimal ShipRate { get; set; }

        [Column("rowguid", Order = 4, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 5, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//PurchaseOrderHeader ShipMethod
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

//SalesOrderHeader ShipMethod
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

    }
}
