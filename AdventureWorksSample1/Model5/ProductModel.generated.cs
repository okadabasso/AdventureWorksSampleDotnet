using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.ProductModel")]
    public partial class ProductModel
    {
        [Key]
        [Column("ProductModelID", Order = 1, TypeName = "int")]
        public int ProductModelId { get; set; }
        [Column("Name", Order = 2, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("CatalogDescription", Order = 3, TypeName = "xml")]
        public object CatalogDescription { get; set; }
        [Column("Instructions", Order = 4, TypeName = "xml")]
        public object Instructions { get; set; }
        [Column("rowguid", Order = 5, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }
        [Column("ModifiedDate", Order = 6, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public ProductModel()
        {
            ProductModelId = 0;
            Name = null;
            CatalogDescription = null;
            Instructions = null;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
