using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.SpecialOffer")]
    public partial class SpecialOffer
    {
        [Key]
        [Column("SpecialOfferID", Order = 1, TypeName = "int")]
        public int SpecialOfferId { get; set; }
        [Column("Description", Order = 2, TypeName = "nvarchar")]
        [StringLength(255)]
        public string Description { get; set; }
        [Column("DiscountPct", Order = 3, TypeName = "smallmoney")]
        public decimal DiscountPct { get; set; }
        [Column("Type", Order = 4, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Type { get; set; }
        [Column("Category", Order = 5, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Category { get; set; }
        [Column("StartDate", Order = 6, TypeName = "datetime")]
        public DateTime StartDate { get; set; }
        [Column("EndDate", Order = 7, TypeName = "datetime")]
        public DateTime EndDate { get; set; }
        [Column("MinQty", Order = 8, TypeName = "int")]
        public int MinQty { get; set; }
        [Column("MaxQty", Order = 9, TypeName = "int")]
        public int? MaxQty { get; set; }
        [Column("rowguid", Order = 10, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }
        [Column("ModifiedDate", Order = 11, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public SpecialOffer()
        {
            SpecialOfferId = 0;
            Description = null;
            DiscountPct = 0;
            Type = null;
            Category = null;
            StartDate = DateTime.Parse("0001/01/01 0:00:00");
            EndDate = DateTime.Parse("0001/01/01 0:00:00");
            MinQty = 0;
            MaxQty = null;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
        }
    }
}
