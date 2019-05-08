using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models6
{
    [Table("dbo.SYS_USER")]
    public partial class SysUser
    {
        public SysUser()
        {
            Uid = 0;
            UserId = null;
            Name = null;
            MailAddress = null;
            Password = null;
            LastLoginDate = null;
            IsAvailable = false;
            Otp = null;
            IsVisitPassword = false;
            IsLock = false;
            LoginFailureCount = 0;
            DeleteFlg = false;
            CreateAt = DateTime.Parse("0001/01/01 0:00:00");
            CreateBy = null;
            UpdateAt = DateTime.Parse("0001/01/01 0:00:00");
            UpdateBy = null;
            Version = null;

        }

        ///<summary>UID</summary>
        [Key]
        [Column("UID", Order = 0, TypeName = "bigint")]
        public long Uid { get; set; }

        ///<summary>ユーザーID</summary>
        [Required]
        [Column("USER_ID", Order = 1, TypeName = "varchar")]
        public string UserId { get; set; }

        ///<summary>氏名</summary>
        [Required]
        [Column("NAME", Order = 2, TypeName = "nvarchar")]
        public string Name { get; set; }

        ///<summary>メールアドレス</summary>
        [Column("MAIL_ADDRESS", Order = 3, TypeName = "varchar")]
        public string MailAddress { get; set; }

        ///<summary>ログインパスワード</summary>
        [Required]
        [Column("PASSWORD", Order = 4, TypeName = "varchar")]
        public string Password { get; set; }

        ///<summary>最終ログイン日時</summary>
        [Column("LAST_LOGIN_DATE", Order = 5, TypeName = "datetime")]
        public DateTime? LastLoginDate { get; set; }

        ///<summary>有効フラグ</summary>
        [Column("IS_AVAILABLE", Order = 6, TypeName = "bit")]
        public bool IsAvailable { get; set; }

        ///<summary>ワンタイムパスワード</summary>
        [Column("OTP", Order = 7, TypeName = "varchar")]
        public string Otp { get; set; }

        ///<summary>ワンタイムパスワード発行中</summary>
        [Column("IS_VISIT_PASSWORD", Order = 8, TypeName = "bit")]
        public bool IsVisitPassword { get; set; }

        ///<summary>アカウントロック</summary>
        [Column("IS_LOCK", Order = 9, TypeName = "bit")]
        public bool IsLock { get; set; }

        ///<summary>ログイン失敗回数</summary>
        [Column("LOGIN_FAILURE_COUNT", Order = 10, TypeName = "int")]
        public int LoginFailureCount { get; set; }

        ///<summary>削除フラグ</summary>
        [Column("DELETE_FLG", Order = 11, TypeName = "bit")]
        public bool DeleteFlg { get; set; }

        ///<summary>作成日</summary>
        [Column("CREATE_AT", Order = 12, TypeName = "datetime")]
        public DateTime CreateAt { get; set; }

        ///<summary>作成者</summary>
        [Required]
        [Column("CREATE_BY", Order = 13, TypeName = "nvarchar")]
        public string CreateBy { get; set; }

        ///<summary>更新日</summary>
        [Column("UPDATE_AT", Order = 14, TypeName = "datetime")]
        public DateTime UpdateAt { get; set; }

        ///<summary>更新者</summary>
        [Required]
        [Column("UPDATE_BY", Order = 15, TypeName = "nvarchar")]
        public string UpdateBy { get; set; }

        ///<summary>バージョン</summary>
        [Required]
        [Column("VERSION", Order = 16, TypeName = "timestamp")]
        public byte[] Version { get; set; }

    }
}
