using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Person.StateProvince")]
    public partial class StateProvince
    {
        [Key]
        [Column("StateProvinceID", Order = 1, TypeName = "int")]
        public int StateProvinceId { get; set; }
        [Column("StateProvinceCode", Order = 2, TypeName = "nchar")]
        [StringLength(3)]
        public string StateProvinceCode { get; set; }
        [Column("CountryRegionCode", Order = 3, TypeName = "nvarchar")]
        [StringLength(3)]
        public string CountryRegionCode { get; set; }
        [Column("IsOnlyStateProvinceFlag", Order = 4, TypeName = "bit")]
        public bool IsOnlyStateProvinceFlag { get; set; }
        [Column("Name", Order = 5, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("TerritoryID", Order = 6, TypeName = "int")]
        public int TerritoryId { get; set; }
        [Column("rowguid", Order = 7, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }
        [Column("ModifiedDate", Order = 8, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public StateProvince()
        {
            StateProvinceId = 0;
            StateProvinceCode = null;
            CountryRegionCode = null;
            IsOnlyStateProvinceFlag = false;
            Name = null;
            TerritoryId = 0;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
