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
    
    public partial class EmployeeDepartmentHistory
    {
        public int BusinessEntityID { get; set; }
        public short DepartmentID { get; set; }
        public byte ShiftID { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Shift Shift { get; set; }
    }
}
