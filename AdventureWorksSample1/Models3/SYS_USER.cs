//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはテンプレートから生成されました。
//
//     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdventureWorksSample1.Models3
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYS_USER
    {
        public long UID { get; set; }
        public string USER_ID { get; set; }
        public string NAME { get; set; }
        public string MAIL_ADDRESS { get; set; }
        public string PASSWORD { get; set; }
        public Nullable<System.DateTime> LAST_LOGIN_DATE { get; set; }
        public bool IS_AVAILABLE { get; set; }
        public string OTP { get; set; }
        public bool IS_VISIT_PASSWORD { get; set; }
        public bool IS_LOCK { get; set; }
        public int LOGIN_FAILURE_COUNT { get; set; }
        public bool DELETE_FLG { get; set; }
        public System.DateTime CREATE_AT { get; set; }
        public string CREATE_BY { get; set; }
        public System.DateTime UPDATE_AT { get; set; }
        public string UPDATE_BY { get; set; }
        public byte[] VERSION { get; set; }
    }
}
