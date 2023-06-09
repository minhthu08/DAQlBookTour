using System;
using System.Collections.Generic;

namespace Webdemo.Models
{
    public partial class TChiTietTour
    {
        public TChiTietTour()
        {
            TChiTietHoaDons = new HashSet<TChiTietHoaDon>();
        }

        public int MaChiTietTour { get; set; }
        public int MaTour { get; set; }
        public int MaSoCho { get; set; }
        public int MaTg { get; set; }
        public string Anh { get; set; } = null!;
        public string? Video { get; set; }
        public int DonGia { get; set; }
        public int? GiamGia { get; set; }
        public int SoLuongCon { get; set; }

        public virtual TAnhChiTietTour MaChiTietTourNavigation { get; set; } = null!;
        public virtual TSoCho MaSoChoNavigation { get; set; } = null!;
        public virtual TThoiGian MaTgNavigation { get; set; } = null!;
        public virtual TTour MaTourNavigation { get; set; } = null!;
        public virtual ICollection<TChiTietHoaDon> TChiTietHoaDons { get; set; }
    }
}
