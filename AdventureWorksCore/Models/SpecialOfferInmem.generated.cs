using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("SpecialOffer_inmem", Schema="Sales")]
    public partial class SpecialOfferInmem
    {
        public SpecialOfferInmem()
        {
            SpecialOfferProductInmems = new HashSet<SpecialOfferProductInmem>();

        }

        ///<summary>column:SpecialOfferID</summary>
        ///<remarks></remarks>
        [Key]
        [Column("SpecialOfferID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SpecialOfferId { get; set; }

        ///<summary>column:Description</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Description", Order = 1)]
        [StringLength(255)]
        public string Description { get; set; }

        ///<summary>column:DiscountPct</summary>
        ///<remarks></remarks>
        [Column("DiscountPct", Order = 2)]
        public decimal DiscountPct { get; set; }

        ///<summary>column:Type</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Type", Order = 3)]
        [StringLength(50)]
        public string Type { get; set; }

        ///<summary>column:Category</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Category", Order = 4)]
        [StringLength(50)]
        public string Category { get; set; }

        ///<summary>column:StartDate</summary>
        ///<remarks></remarks>
        [Column("StartDate", Order = 5)]
        public DateTime StartDate { get; set; }

        ///<summary>column:EndDate</summary>
        ///<remarks></remarks>
        [Column("EndDate", Order = 6)]
        public DateTime EndDate { get; set; }

        ///<summary>column:MinQty</summary>
        ///<remarks></remarks>
        [Column("MinQty", Order = 7)]
        public int MinQty { get; set; }

        ///<summary>column:MaxQty</summary>
        ///<remarks></remarks>
        [Column("MaxQty", Order = 8)]
        public int? MaxQty { get; set; }

        ///<summary>column:ModifiedDate</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 9)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialOfferProductInmem> SpecialOfferProductInmems { get; set; }

    }
}
