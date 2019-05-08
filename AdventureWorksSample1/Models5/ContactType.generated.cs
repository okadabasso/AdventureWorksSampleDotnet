using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models5
{
    [Table("Person.ContactType")]
    public partial class ContactType
    {
        public ContactType()
        {
            ContactTypeId = 0;
            Name = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            BusinessEntityContacts = new HashSet<BusinessEntityContact>();

        }

        ///<summary>Primary key for ContactType records.</summary>
        [Key]
        [Column("ContactTypeID", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactTypeId { get; set; }

        ///<summary>Contact type description.</summary>
        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 2, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }

    }
}
