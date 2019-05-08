using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Person.Address")]
    public partial class Address
    {
        public Address()
        {
            AddressId = 0;
            AddressLine1 = null;
            AddressLine2 = null;
            City = null;
            StateProvinceId = 0;
            PostalCode = null;
            SpatialLocation = null;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            BusinessEntityAddresses = new HashSet<BusinessEntityAddress>();
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();
            SalesOrderHeaders1 = new HashSet<SalesOrderHeader>();

        }

        ///<summary>Primary key for Address records.</summary>
        [Key]
        [Column("AddressID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }

        ///<summary>First street address line.</summary>
        [Required]
        [Column("AddressLine1", Order = 1, TypeName = "nvarchar")]
        [StringLength(60)]
        public string AddressLine1 { get; set; }

        ///<summary>Second street address line.</summary>
        [Column("AddressLine2", Order = 2, TypeName = "nvarchar")]
        [StringLength(60)]
        public string AddressLine2 { get; set; }

        ///<summary>Name of the city.</summary>
        [Required]
        [Column("City", Order = 3, TypeName = "nvarchar")]
        [StringLength(30)]
        public string City { get; set; }

        ///<summary>Unique identification number for the state or province. Foreign key to StateProvince table.</summary>
        [Column("StateProvinceID")]
        public int StateProvinceId { get; set; }

        ///<summary>Postal code for the street address.</summary>
        [Required]
        [Column("PostalCode", Order = 5, TypeName = "nvarchar")]
        [StringLength(15)]
        public string PostalCode { get; set; }

        ///<summary>Latitude and longitude of this address.</summary>
        [Column("SpatialLocation", Order = 6, TypeName = "geography")]
        public object SpatialLocation { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        [Column("rowguid", Order = 7, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 8, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders1 { get; set; }

        public virtual StateProvince StateProvince { get; set; }

    }
}
