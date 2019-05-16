using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("Person", Schema="Person")]
    public partial class Person
    {
        public Person()
        {
            BusinessEntityContacts = new HashSet<BusinessEntityContact>();
            Customers = new HashSet<Customer>();
            EmailAddresses = new HashSet<EmailAddress>();
            PersonCreditCards = new HashSet<PersonCreditCard>();
            PersonPhones = new HashSet<PersonPhone>();

        }

        ///<summary>Primary key for Person records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("BusinessEntityID", Order = 0)]
        public int BusinessEntityId { get; set; }

        ///<summary>Primary type of person: SC = Store Contact, IN = Individual (retail) customer, SP = Sales person, EM = Employee (non-sales), VC = Vendor contact, GC = General contact</summary>
        ///<remarks></remarks>
        [Required]
        [Column("PersonType", Order = 1)]
        [StringLength(2)]
        public string PersonType { get; set; }

        ///<summary>0 = The data in FirstName and LastName are stored in western style (first name, last name) order.  1 = Eastern style (last name, first name) order.</summary>
        ///<remarks></remarks>
        [Column("NameStyle", Order = 2)]
        public bool NameStyle { get; set; }

        ///<summary>A courtesy title. For example, Mr. or Ms.</summary>
        ///<remarks></remarks>
        [Column("Title", Order = 3)]
        [StringLength(8)]
        public string Title { get; set; }

        ///<summary>First name of the person.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("FirstName", Order = 4)]
        [StringLength(50)]
        public string FirstName { get; set; }

        ///<summary>Middle name or middle initial of the person.</summary>
        ///<remarks></remarks>
        [Column("MiddleName", Order = 5)]
        [StringLength(50)]
        public string MiddleName { get; set; }

        ///<summary>Last name of the person.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("LastName", Order = 6)]
        [StringLength(50)]
        public string LastName { get; set; }

        ///<summary>Surname suffix. For example, Sr. or Jr.</summary>
        ///<remarks></remarks>
        [Column("Suffix", Order = 7)]
        [StringLength(10)]
        public string Suffix { get; set; }

        ///<summary>0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners. </summary>
        ///<remarks></remarks>
        [Column("EmailPromotion", Order = 8)]
        public int EmailPromotion { get; set; }

        ///<summary>Additional contact information about the person stored in xml format. </summary>
        ///<remarks></remarks>
        [Column("AdditionalContactInfo", Order = 9)]
        public string AdditionalContactInfo { get; set; }

        ///<summary>Personal information such as hobbies, and income collected from online shoppers. Used for sales analysis.</summary>
        ///<remarks></remarks>
        [Column("Demographics", Order = 10)]
        public string Demographics { get; set; }

        ///<summary>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
        ///<remarks></remarks>
        [Column("rowguid", Order = 11)]
        public Guid Rowguid { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 12)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmailAddress> EmailAddresses { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Password Password { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonCreditCard> PersonCreditCards { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonPhone> PersonPhones { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; }

    }
}
