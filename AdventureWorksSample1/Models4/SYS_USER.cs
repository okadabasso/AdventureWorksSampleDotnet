namespace AdventureWorksSample1.Models4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_USER
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long UID { get; set; }

        [Required]
        [StringLength(50)]
        public string USER_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(128)]
        public string MAIL_ADDRESS { get; set; }

        [Required]
        public string PASSWORD { get; set; }

        public DateTime? LAST_LOGIN_DATE { get; set; }

        public bool IS_AVAILABLE { get; set; }

        [StringLength(1024)]
        public string OTP { get; set; }

        public bool IS_VISIT_PASSWORD { get; set; }

        public bool IS_LOCK { get; set; }

        public int LOGIN_FAILURE_COUNT { get; set; }

        public bool DELETE_FLG { get; set; }

        public DateTime CREATE_AT { get; set; }

        [Required]
        [StringLength(50)]
        public string CREATE_BY { get; set; }

        public DateTime UPDATE_AT { get; set; }

        [Required]
        [StringLength(50)]
        public string UPDATE_BY { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] VERSION { get; set; }
    }
}
