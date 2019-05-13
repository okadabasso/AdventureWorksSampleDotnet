using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("SpecialOffer", Schema="Sales")]
    public partial class SpecialOffer
    {
        public SpecialOffer()
        {
            SpecialOfferProducts = new HashSet<SpecialOfferProduct>();

        }

        ///<summary>Primary key for SpecialOffer records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("SpecialOfferID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SpecialOfferId { get; set; }

        ///<summary>Discount description.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Description", Order = 1)]
        [StringLength(255)]
        public string Description { get; set; }

        ///<summary>Discount precentage.</summary>
        ///<remarks></remarks>
        [Column("DiscountPct", Order = 2)]
        public decimal DiscountPct { get; set; }

        ///<summary>Discount type category.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Type", Order = 3)]
        [StringLength(50)]
        public string Type { get; set; }

        ///<summary>Group the discount applies to such as Reseller or Customer.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Category", Order = 4)]
        [StringLength(50)]
        public string Category { get; set; }

        ///<summary>Discount start date.</summary>
        ///<remarks></remarks>
        [Column("StartDate", Order = 5)]
        public DateTime StartDate { get; set; }

        ///<summary>Discount end date.</summary>
        ///<remarks></remarks>
        [Column("EndDate", Order = 6)]
        public DateTime EndDate { get; set; }

        ///<summary>Minimum discount percent allowed.</summary>
        ///<remarks></remarks>
        [Column("MinQty", Order = 7)]
        public int MinQty { get; set; }

        ///<summary>Maximum discount percent allowed.</summary>
        ///<remarks></remarks>
        [Column("MaxQty", Order = 8)]
        public int? MaxQty { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        ///<remarks></remarks>
        [Column("rowguid", Order = 9)]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 10)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialOfferProduct> SpecialOfferProducts { get; set; }

    }
}
