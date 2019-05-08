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
            SpecialOfferProducts = new HashSet<SpecialOfferProduct>();

        }

        ///<summary>Primary key for SpecialOffer records.</summary>
        [Key]
        [Column("SpecialOfferID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SpecialOfferId { get; set; }

        ///<summary>Discount description.</summary>
        [Required]
        [Column("Description", Order = 1, TypeName = "nvarchar")]
        [StringLength(255)]
        public string Description { get; set; }

        ///<summary>Discount precentage.</summary>
        [Column("DiscountPct", Order = 2, TypeName = "smallmoney")]
        public decimal DiscountPct { get; set; }

        ///<summary>Discount type category.</summary>
        [Required]
        [Column("Type", Order = 3, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Type { get; set; }

        ///<summary>Group the discount applies to such as Reseller or Customer.</summary>
        [Required]
        [Column("Category", Order = 4, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Category { get; set; }

        ///<summary>Discount start date.</summary>
        [Column("StartDate", Order = 5, TypeName = "datetime")]
        public DateTime StartDate { get; set; }

        ///<summary>Discount end date.</summary>
        [Column("EndDate", Order = 6, TypeName = "datetime")]
        public DateTime EndDate { get; set; }

        ///<summary>Minimum discount percent allowed.</summary>
        [Column("MinQty", Order = 7, TypeName = "int")]
        public int MinQty { get; set; }

        ///<summary>Maximum discount percent allowed.</summary>
        [Column("MaxQty", Order = 8, TypeName = "int")]
        public int? MaxQty { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        [Column("rowguid", Order = 9, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 10, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialOfferProduct> SpecialOfferProducts { get; set; }

    }
}
