using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Person.ContactType")]
    public partial class ContactType
    {
        public ContactType()
        {
            ContactTypeID = 0;
            Name = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            BusinessEntityContacts = new HashSet<BusinessEntityContact>();

        }

        [Key]
        [Column("ContactTypeID", Order = 0, TypeName = "int")]
        public int ContactTypeID { get; set; }

        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("ModifiedDate", Order = 2, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//BusinessEntityContact ContactType
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }

    }
}
