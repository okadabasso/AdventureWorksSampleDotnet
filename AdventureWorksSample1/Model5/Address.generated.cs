using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Person.Address")]
    public partial class Address
    {
        public Address()
        {
            AddressID = 0;
            AddressLine1 = null;
            AddressLine2 = null;
            City = null;
            StateProvinceID = 0;
            PostalCode = null;
            SpatialLocation = null;
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            BusinessEntityAddresses = new HashSet<BusinessEntityAddress>();
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();
            SalesOrderHeaders1 = new HashSet<SalesOrderHeader>();

        }

        [Key]
        [Column("AddressID", Order = 0, TypeName = "int")]
        public int AddressID { get; set; }

        [Required]
        [Column("AddressLine1", Order = 1, TypeName = "nvarchar")]
        [StringLength(60)]
        public string AddressLine1 { get; set; }

        [Column("AddressLine2", Order = 2, TypeName = "nvarchar")]
        [StringLength(60)]
        public string AddressLine2 { get; set; }

        [Required]
        [Column("City", Order = 3, TypeName = "nvarchar")]
        [StringLength(30)]
        public string City { get; set; }

        public int StateProvinceID { get; set; }

        [Required]
        [Column("PostalCode", Order = 5, TypeName = "nvarchar")]
        [StringLength(15)]
        public string PostalCode { get; set; }

        [Column("SpatialLocation", Order = 6, TypeName = "geography")]
        public object SpatialLocation { get; set; }

        [Column("rowguid", Order = 7, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 8, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//BusinessEntityAddress Address
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }

//SalesOrderHeader Address
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

//SalesOrderHeader Address
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders1 { get; set; }

        public virtual StateProvince StateProvince { get; set; }

    }
}
