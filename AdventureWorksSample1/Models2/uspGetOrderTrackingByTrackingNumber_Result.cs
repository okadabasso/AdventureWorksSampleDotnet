//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはテンプレートから生成されました。
//
//     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdventureWorksSample1.Models2
{
    using System;
    
    public partial class uspGetOrderTrackingByTrackingNumber_Result
    {
        public int SalesOrderID { get; set; }
        public string CarrierTrackingNumber { get; set; }
        public int OrderTrackingID { get; set; }
        public int TrackingEventID { get; set; }
        public string EventName { get; set; }
        public string EventDetails { get; set; }
        public System.DateTime EventDateTime { get; set; }
    }
}
