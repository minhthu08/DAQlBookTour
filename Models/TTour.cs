using System;
using System.Collections.Generic;

namespace Webdemo.Models
{
    public partial class TTour
    {
        public TTour()
        {
            TChiTietTours = new HashSet<TChiTietTour>();
        }

        public int MaTour { get; set; }
        public string TenTour { get; set; } = null!;
        public int MaSoCho { get; set; }
        public int MaKs { get; set; }
        public int MaPt { get; set; }
        public int MaDd { get; set; }
        public int MaTg { get; set; }
        public DateTime NgayKh { get; set; }
        public DateTime NgayKt { get; set; }
        public string Gioithieu { get; set; } = null!;
        public int MaLoai { get; set; }
        public int MaNguoi { get; set; }
        public string AnhDaiDien { get; set; } = null!;
        public int GiaTien { get; set; }

        public virtual TDiaDiem MaDdNavigation { get; set; } = null!;
        public virtual TKhachSan MaKsNavigation { get; set; } = null!;
        public virtual TLoaiTour MaLoaiNavigation { get; set; } = null!;
        public virtual TNguoi MaNguoiNavigation { get; set; } = null!;
        public virtual TPhuongTien MaPtNavigation { get; set; } = null!;
        public virtual TAnhTour TAnhTour { get; set; } = null!;
        public virtual ICollection<TChiTietTour> TChiTietTours { get; set; }
    }
}
