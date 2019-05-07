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
        public SpecialOffer()
        {
            SpecialOfferID = 0;
            Description = null;
            DiscountPct = 0;
            Type = null;
            Category = null;
            StartDate = DateTime.Parse("0001/01/01 0:00:00");
            EndDate = DateTime.Parse("0001/01/01 0:00:00");
            MinQty = 0;
            MaxQty = null;
            rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            SpecialOfferProducts = new HashSet<SpecialOfferProduct>();

        }

        [Key]
        [Column("SpecialOfferID", Order = 0, TypeName = "int")]
        public int SpecialOfferID { get; set; }

        [Required]
        [Column("Description", Order = 1, TypeName = "nvarchar")]
        [StringLength(255)]
        public string Description { get; set; }

        [Column("DiscountPct", Order = 2, TypeName = "smallmoney")]
        public decimal DiscountPct { get; set; }

        [Required]
        [Column("Type", Order = 3, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Type { get; set; }

        [Required]
        [Column("Category", Order = 4, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Category { get; set; }

        [Column("StartDate", Order = 5, TypeName = "datetime")]
        public DateTime StartDate { get; set; }

        [Column("EndDate", Order = 6, TypeName = "datetime")]
        public DateTime EndDate { get; set; }

        [Column("MinQty", Order = 7, TypeName = "int")]
        public int MinQty { get; set; }

        [Column("MaxQty", Order = 8, TypeName = "int")]
        public int? MaxQty { get; set; }

        [Column("rowguid", Order = 9, TypeName = "uniqueidentifier")]
        public Guid rowguid { get; set; }

        [Column("ModifiedDate", Order = 10, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//SpecialOfferProduct SpecialOffer
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialOfferProduct> SpecialOfferProducts { get; set; }

    }
}
