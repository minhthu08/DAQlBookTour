using System;
using System.Collections.Generic;

namespace Webdemo.Models
{
    public partial class THoaDon
    {
        public int MaHd { get; set; }
        public DateTime NgayHd { get; set; }
        public int MaKh { get; set; }
        public int MaNv { get; set; }
        public int TongTien { get; set; }
        public int GiamGia { get; set; }
        public string PhuongThucThanhToan { get; set; } = null!;
        public int TongSau { get; set; }
        public string? GhiChu { get; set; }

        public virtual TKhachHang MaKhNavigation { get; set; } = null!;
        public virtual TNhanVien MaNvNavigation { get; set; } = null!;
        public virtual TChiTietHoaDon TChiTietHoaDon { get; set; } = null!;
    }
}
