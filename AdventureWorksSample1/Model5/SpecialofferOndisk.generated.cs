using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Sales.SpecialOffer_ondisk")]
    public partial class SpecialofferOndisk
    {
        public SpecialofferOndisk()
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
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            SpecialofferproductOndisks = new HashSet<SpecialofferproductOndisk>();

        }

        ///<summary>column:SpecialOfferID</summary>
        [Key]
        [Column("SpecialOfferID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SpecialOfferId { get; set; }

        ///<summary>column:Description</summary>
        [Required]
        [Column("Description", Order = 1, TypeName = "nvarchar")]
        [StringLength(255)]
        public string Description { get; set; }

        ///<summary>column:DiscountPct</summary>
        [Column("DiscountPct", Order = 2, TypeName = "smallmoney")]
        public decimal DiscountPct { get; set; }

        ///<summary>column:Type</summary>
        [Required]
        [Column("Type", Order = 3, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Type { get; set; }

        ///<summary>column:Category</summary>
        [Required]
        [Column("Category", Order = 4, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Category { get; set; }

        ///<summary>column:StartDate</summary>
        [Column("StartDate", Order = 5, TypeName = "datetime2")]
        public DateTime StartDate { get; set; }

        ///<summary>column:EndDate</summary>
        [Column("EndDate", Order = 6, TypeName = "datetime2")]
        public DateTime EndDate { get; set; }

        ///<summary>column:MinQty</summary>
        [Column("MinQty", Order = 7, TypeName = "int")]
        public int MinQty { get; set; }

        ///<summary>column:MaxQty</summary>
        [Column("MaxQty", Order = 8, TypeName = "int")]
        public int? MaxQty { get; set; }

        ///<summary>column:ModifiedDate</summary>
        [Column("ModifiedDate", Order = 9, TypeName = "datetime2")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialofferproductOndisk> SpecialofferproductOndisks { get; set; }

    }
}
