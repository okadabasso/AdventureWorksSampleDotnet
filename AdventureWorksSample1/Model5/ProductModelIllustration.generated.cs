using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.ProductModelIllustration")]
    public partial class ProductModelIllustration
    {
        [Key]
        [Column("ProductModelID", Order = 1, TypeName = "int")]
        public int ProductModelId { get; set; }
        [Key]
        [Column("IllustrationID", Order = 2, TypeName = "int")]
        public int IllustrationId { get; set; }
        [Column("ModifiedDate", Order = 3, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public ProductModelIllustration()
        {
            ProductModelId = 0;
            IllustrationId = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
