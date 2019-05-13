using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("SalesTaxRate", Schema="Sales")]
    public partial class SalesTaxRate
    {
        public SalesTaxRate()
        {

        }

        ///<summary>Primary key for SalesTaxRate records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("SalesTaxRateID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalesTaxRateId { get; set; }

        ///<summary>State, province, or country/region the sales tax applies to.</summary>
        ///<remarks></remarks>
        [Column("StateProvinceID")]
        public int StateProvinceId { get; set; }

        ///<summary>1 = Tax applied to retail transactions, 2 = Tax applied to wholesale transactions, 3 = Tax applied to all sales (retail and wholesale) transactions.</summary>
        ///<remarks></remarks>
        [Column("TaxType", Order = 2)]
        public byte TaxType { get; set; }

        ///<summary>Tax rate amount.</summary>
        ///<remarks></remarks>
        [Column("TaxRate", Order = 3)]
        public decimal TaxRate { get; set; }

        ///<summary>Tax rate description.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("Name", Order = 4)]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        ///<remarks></remarks>
        [Column("rowguid", Order = 5)]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 6)]
        public DateTime ModifiedDate { get; set; }

        public virtual StateProvince StateProvince { get; set; }

    }
}
