using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Sales.SalesTaxRate")]
    public partial class SalesTaxRate
    {
        public SalesTaxRate()
        {
            SalesTaxRateId = 0;
            StateProvinceId = 0;
            TaxType = 0;
            TaxRate = 0;
            Name = null;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

        }

        ///<summary>Primary key for SalesTaxRate records.</summary>
        [Key]
        [Column("SalesTaxRateID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalesTaxRateId { get; set; }

        ///<summary>State, province, or country/region the sales tax applies to.</summary>
        [Column("StateProvinceID")]
        public int StateProvinceId { get; set; }

        ///<summary>1 = Tax applied to retail transactions, 2 = Tax applied to wholesale transactions, 3 = Tax applied to all sales (retail and wholesale) transactions.</summary>
        [Column("TaxType", Order = 2, TypeName = "tinyint")]
        public byte TaxType { get; set; }

        ///<summary>Tax rate amount.</summary>
        [Column("TaxRate", Order = 3, TypeName = "smallmoney")]
        public decimal TaxRate { get; set; }

        ///<summary>Tax rate description.</summary>
        [Required]
        [Column("Name", Order = 4, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        [Column("rowguid", Order = 5, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 6, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual StateProvince StateProvince { get; set; }

    }
}
