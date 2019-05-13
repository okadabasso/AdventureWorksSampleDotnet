using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdventureWorksCore.Models
{
    [Table("Person_json", Schema="Person")]
    public partial class PersonJson
    {
        public PersonJson()
        {

        }

        ///<summary>column:PersonID</summary>
        ///<remarks></remarks>
        [Key]
        [Column("PersonID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }

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

        ///<summary>column:AdditionalContactInfo</summary>
        ///<remarks></remarks>
        [Column("AdditionalContactInfo", Order = 9)]
        public string AdditionalContactInfo { get; set; }

        ///<summary>column:Demographics</summary>
        ///<remarks></remarks>
        [Column("Demographics", Order = 10)]
        public string Demographics { get; set; }

        ///<summary>column:rowguid</summary>
        ///<remarks></remarks>
        [Column("rowguid", Order = 11)]
        public Guid Rowguid { get; set; }

        ///<summary>column:ModifiedDate</summary>
        ///<remarks></remarks>
        [Column("ModifiedDate", Order = 12)]
        public DateTime ModifiedDate { get; set; }

    }
}
