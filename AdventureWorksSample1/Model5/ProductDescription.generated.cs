using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.ProductDescription")]
    public partial class ProductDescription
    {
        [Key]
        [Column("ProductDescriptionID", Order = 1, TypeName = "int")]
        public int ProductDescriptionId { get; set; }
        [Column("Description", Order = 2, TypeName = "nvarchar")]
        [StringLength(400)]
        public string Description { get; set; }
        [Column("rowguid", Order = 3, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }
        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public ProductDescription()
        {
            ProductDescriptionId = 0;
            Description = null;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
