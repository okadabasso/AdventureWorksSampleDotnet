using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("Address", Schema="Person")]
    public partial class Address
    {
        public Address()
        {
            BusinessEntityAddresses = new HashSet<BusinessEntityAddress>();
            BillToSalesOrderHeaders = new HashSet<SalesOrderHeader>();
            ShipToSalesOrderHeaders = new HashSet<SalesOrderHeader>();

        }

        ///<summary>Primary key for Address records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("AddressID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }

        ///<summary>First street address line.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("AddressLine1", Order = 1)]
        [StringLength(60)]
        public string AddressLine1 { get; set; }

        ///<summary>Second street address line.</summary>
        ///<remarks></remarks>
        [Column("AddressLine2", Order = 2)]
        [StringLength(60)]
        public string AddressLine2 { get; set; }

        ///<summary>Name of the city.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("City", Order = 3)]
        [StringLength(30)]
        public string City { get; set; }

        ///<summary>Unique identification number for the state or province. Foreign key to StateProvince table.</summary>
        ///<remarks></remarks>
        [Column("StateProvinceID")]
        public int StateProvinceId { get; set; }

        ///<summary>Postal code for the street address.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("PostalCode", Order = 5)]
        [StringLength(15)]
        public string PostalCode { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        ///<remarks></remarks>
        [Column("rowguid", Order = 7)]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 8)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeader> BillToSalesOrderHeaders { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeader> ShipToSalesOrderHeaders { get; set; }

        public virtual StateProvince StateProvince { get; set; }

    }
}
