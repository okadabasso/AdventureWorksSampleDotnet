using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Person.PhoneNumberType")]
    public partial class PhoneNumberType
    {
        public PhoneNumberType()
        {
            PhoneNumberTypeID = 0;
            Name = null;
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");

            PersonPhones = new HashSet<PersonPhone>();

        }

        [Key]
        [Column("PhoneNumberTypeID", Order = 0, TypeName = "int")]
        public int PhoneNumberTypeID { get; set; }

        [Required]
        [Column("Name", Order = 1, TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("ModifiedDate", Order = 2, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

//PersonPhone PhoneNumberType
            
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonPhone> PersonPhones { get; set; }

    }
}
