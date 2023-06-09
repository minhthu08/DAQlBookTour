using System;
using System.Collections.Generic;

namespace Webdemo.Models
{
    public partial class TChiTietHoaDon
    {
        public int MaHd { get; set; }
        public int MaChiTietTour { get; set; }
        public int SoLuong { get; set; }
        public int? GiamGia { get; set; }
        public string? GhiChu { get; set; }

        public virtual TChiTietTour MaChiTietTourNavigation { get; set; } = null!;
        public virtual THoaDon MaHdNavigation { get; set; } = null!;
    }
}
