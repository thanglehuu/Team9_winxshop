//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Team9_winxshop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietGioHang
    {
        public int MaCTGH { get; set; }
        public string MaGH { get; set; }
        public string MaSP { get; set; }
        public int SoLuong { get; set; }
    
        public virtual GioHang GioHang { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
