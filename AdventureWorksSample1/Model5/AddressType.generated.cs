using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Person.AddressType")]
    public partial class AddressType
    {
        public AddressType()
        {
            AddressTypeId = 0;
            Name = null;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            BusinessEntityAddresses = new HashSet<BusinessEntityAddress>();

        }

        ///<summary>Primary key for AddressType records.</summary>
        [Key]
        [Column("AddressTypeID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressTypeId { get; set; }

        ///<summary>Address type description. For example, Billing, Home, or Shipping.</summary>
        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        [Column("rowguid", Order = 2, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 3, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }

    }
}
