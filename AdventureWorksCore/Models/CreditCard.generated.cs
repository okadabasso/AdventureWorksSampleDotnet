using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("CreditCard", Schema="Sales")]
    public partial class CreditCard
    {
        public CreditCard()
        {
            PersonCreditCards = new HashSet<PersonCreditCard>();
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();

        }

        ///<summary>Primary key for CreditCard records.</summary>
        ///<remarks></remarks>
        [Key]
        [Column("CreditCardID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CreditCardId { get; set; }

        ///<summary>Credit card name.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("CardType", Order = 1)]
        [StringLength(50)]
        public string CardType { get; set; }

        ///<summary>Credit card number.</summary>
        ///<remarks></remarks>
        [Required]
        [Column("CardNumber", Order = 2)]
        [StringLength(25)]
        public string CardNumber { get; set; }

        ///<summary>Credit card expiration month.</summary>
        ///<remarks></remarks>
        [Column("ExpMonth", Order = 3)]
        public byte ExpMonth { get; set; }

        ///<summary>Credit card expiration year.</summary>
        ///<remarks></remarks>
        [Column("ExpYear", Order = 4)]
        public short ExpYear { get; set; }

        ///<summary>Date and time the record was last updated.</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 5)]
        public DateTime ModifiedDate { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonCreditCard> PersonCreditCards { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

    }
}
