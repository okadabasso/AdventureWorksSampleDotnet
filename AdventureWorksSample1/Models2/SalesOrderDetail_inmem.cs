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
    using System.Collections.Generic;
    
    public partial class SalesOrderDetail_inmem
    {
        public int SalesOrderID { get; set; }
        public long SalesOrderDetailID { get; set; }
        public string CarrierTrackingNumber { get; set; }
        public short OrderQty { get; set; }
        public int ProductID { get; set; }
        public int SpecialOfferID { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitPriceDiscount { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual SalesOrderHeader_inmem SalesOrderHeader_inmem { get; set; }
        public virtual SpecialOfferProduct_inmem SpecialOfferProduct_inmem { get; set; }
    }
}
