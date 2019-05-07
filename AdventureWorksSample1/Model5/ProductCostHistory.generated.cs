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
        public ProductCostHistory()
        {
            ProductID = 0;
            StartDate = DateTime.Parse("0001/01/01 0:00:00");
            EndDate = null;
            StandardCost = 0;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");


        }

        [Key]
        [Column("ProductID", Order = 0, TypeName = "int")]
        public int ProductID { get; set; }

        [Key]
        [Column("StartDate", Order = 1, TypeName = "datetime")]
        public DateTime StartDate { get; set; }

        [Column("EndDate", Order = 2, TypeName = "datetime")]
        public DateTime? EndDate { get; set; }

        [Column("StandardCost", Order = 3, TypeName = "money")]
        public decimal StandardCost { get; set; }

        [Column("ModifiedDate", Order = 4, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }

    }
}
