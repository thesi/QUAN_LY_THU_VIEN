//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QUAN_LY_THU_VIEN
{
    using System;
    using System.Collections.Generic;
    
    public partial class THONGTINCUONSACH
    {
        public string MACUONSACH { get; set; }
        public string MADAUSACH { get; set; }
        public Nullable<System.DateTime> NGAYNHAPSACH { get; set; }
        public Nullable<System.DateTime> NGAYHUYSACH { get; set; }
        public Nullable<int> TRANGTHAIMUON { get; set; }
        public Nullable<int> TRANGTHAIHUY { get; set; }
    
        public virtual THONGTINDAUSACH THONGTINDAUSACH { get; set; }
    }
}