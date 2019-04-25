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
        [Key]
        [Column("AddressID", Order = 1, TypeName = "int")]
        public int AddressId { get; set; }
        [Column("AddressLine1", Order = 2, TypeName = "nvarchar")]
        [StringLength(60)]
        public string AddressLine1 { get; set; }
        [Column("AddressLine2", Order = 3, TypeName = "nvarchar")]
        [StringLength(60)]
        public string AddressLine2 { get; set; }
        [Column("City", Order = 4, TypeName = "nvarchar")]
        [StringLength(30)]
        public string City { get; set; }
        [Column("StateProvinceID", Order = 5, TypeName = "int")]
        public int StateProvinceId { get; set; }
        [Column("PostalCode", Order = 6, TypeName = "nvarchar")]
        [StringLength(15)]
        public string PostalCode { get; set; }
        [Column("SpatialLocation", Order = 7, TypeName = "geography")]
        public object SpatialLocation { get; set; }
        [Column("rowguid", Order = 8, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }
        [Column("ModifiedDate", Order = 9, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
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
        }
    }
}
