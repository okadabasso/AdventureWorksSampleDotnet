using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("Person_Temporal", Schema="Person")]
    public partial class PersonTemporal
    {
        public PersonTemporal()
        {

        }

        ///<summary>column:BusinessEntityID</summary>
        ///<remarks></remarks>
        [Key]
        [Column("BusinessEntityID", Order = 0)]
        public int BusinessEntityId { get; set; }

        ///<summary>column:PersonType</summary>
        ///<remarks></remarks>
        [Required]
        [Column("PersonType", Order = 1)]
        [StringLength(2)]
        public string PersonType { get; set; }

        ///<summary>column:NameStyle</summary>
        ///<remarks></remarks>
        [Column("NameStyle", Order = 2)]
        public bool NameStyle { get; set; }

        ///<summary>column:Title</summary>
        ///<remarks></remarks>
        [Column("Title", Order = 3)]
        [StringLength(8)]
        public string Title { get; set; }

        ///<summary>column:FirstName</summary>
        ///<remarks></remarks>
        [Required]
        [Column("FirstName", Order = 4)]
        [StringLength(50)]
        public string FirstName { get; set; }

        ///<summary>column:MiddleName</summary>
        ///<remarks></remarks>
        [Column("MiddleName", Order = 5)]
        [StringLength(50)]
        public string MiddleName { get; set; }

        ///<summary>column:LastName</summary>
        ///<remarks></remarks>
        [Required]
        [Column("LastName", Order = 6)]
        [StringLength(50)]
        public string LastName { get; set; }

        ///<summary>column:Suffix</summary>
        ///<remarks></remarks>
        [Column("Suffix", Order = 7)]
        [StringLength(10)]
        public string Suffix { get; set; }

        ///<summary>column:EmailPromotion</summary>
        ///<remarks></remarks>
        [Column("EmailPromotion", Order = 8)]
        public int EmailPromotion { get; set; }

        ///<summary>column:ValidFrom</summary>
        ///<remarks></remarks>
        [Column("ValidFrom", Order = 9)]
        public DateTime ValidFrom { get; set; }

        ///<summary>column:ValidTo</summary>
        ///<remarks></remarks>
        [Column("ValidTo", Order = 10)]
        public DateTime ValidTo { get; set; }

    }
}
