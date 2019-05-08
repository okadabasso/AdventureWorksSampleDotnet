using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Sample.Entities
{
    [Table("Person.Person")]
    public partial class Person
    {
        public Person()
        {
            BusinessEntityId = 0;
            PersonType = null;
            NameStyle = false;
            Title = null;
            FirstName = null;
            MiddleName = null;
            LastName = null;
            Suffix = null;
            EmailPromotion = 0;
            AdditionalContactInfo = null;
            Demographics = null;
            Rowguid = Guid.Parse("00000000-0000-0000-0000-000000000000");
            ModifiedDate = DateTime.Parse("0001/01/01 0:00:00");
            BusinessEntityContacts = new HashSet<BusinessEntityContact>();
            EmailAddresses = new HashSet<EmailAddress>();
            PersonPhones = new HashSet<PersonPhone>();
            Customers = new HashSet<Customer>();
            PersonCreditCards = new HashSet<PersonCreditCard>();

        }

        ///<summary>Primary key for Person records.</summary>
        [Key]
        [Column("BusinessEntityID", Order = 0, TypeName = "int")]
        public int BusinessEntityId { get; set; }

        ///<summary>Primary type of person: SC = Store Contact, IN = Individual (retail) customer, SP = Sales person, EM = Employee (non-sales), VC = Vendor contact, GC = General contact</summary>
        [Required]
        [Column("PersonType", Order = 1, TypeName = "nchar")]
        [StringLength(2)]
        public string PersonType { get; set; }

        ///<summary>0 = The data in FirstName and LastName are stored in western style (first name, last name) order.  1 = Eastern style (last name, first name) order.</summary>
        [Column("NameStyle", Order = 2, TypeName = "bit")]
        public bool NameStyle { get; set; }

        ///<summary>A courtesy title. For example, Mr. or Ms.</summary>
        [Column("Title", Order = 3, TypeName = "nvarchar")]
        [StringLength(8)]
        public string Title { get; set; }

        ///<summary>First name of the person.</summary>
        [Required]
        [Column("FirstName", Order = 4, TypeName = "nvarchar")]
        [StringLength(50)]
        public string FirstName { get; set; }

        ///<summary>Middle name or middle initial of the person.</summary>
        [Column("MiddleName", Order = 5, TypeName = "nvarchar")]
        [StringLength(50)]
        public string MiddleName { get; set; }

        ///<summary>Last name of the person.</summary>
        [Required]
        [Column("LastName", Order = 6, TypeName = "nvarchar")]
        [StringLength(50)]
        public string LastName { get; set; }

        ///<summary>Surname suffix. For example, Sr. or Jr.</summary>
        [Column("Suffix", Order = 7, TypeName = "nvarchar")]
        [StringLength(10)]
        public string Suffix { get; set; }

        ///<summary>0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners. </summary>
        [Column("EmailPromotion", Order = 8, TypeName = "int")]
        public int EmailPromotion { get; set; }

        ///<summary>Additional contact information about the person stored in xml format. </summary>
        [Column("AdditionalContactInfo", Order = 9, TypeName = "xml")]
        public string AdditionalContactInfo { get; set; }

        ///<summary>Personal information such as hobbies, and income collected from online shoppers. Used for sales analysis.</summary>
        [Column("Demographics", Order = 10, TypeName = "xml")]
        public string Demographics { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        [Column("rowguid", Order = 11, TypeName = "uniqueidentifier")]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        [Column("ModifiedDate", Order = 12, TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        public virtual Employee Employee { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmailAddress> EmailAddresses { get; set; }

        public virtual Password Password { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonPhone> PersonPhones { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonCreditCard> PersonCreditCards { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; }

    }
}
