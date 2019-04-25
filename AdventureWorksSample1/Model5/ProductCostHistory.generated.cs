using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Production.ProductCostHistory")]
    public partial class ProductCostHistory
    {
        [Key]
        [Column("ProductID", Order = 1, TypeName = "int")]
        public int ProductId { get; set; }
        [Key]
        [Column("StartDate", Order = 2, TypeName = "datetime")]
        public DateTime StartDate { get; set; }
        [Column("EndDate", Order = 3, TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [Column("StandardCost", Order = 4, TypeName = "money")]
        public decimal StandardCost { get; set; }
        [Column("ModifiedDate", Order = 5, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public ProductCostHistory()
        {
            ProductId = 0;
            StartDate = DateTime.Parse("0001/01/01 0:00:00");
            EndDate = null;
            StandardCost = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
