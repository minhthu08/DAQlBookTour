using System;
using System.Collections.Generic;

namespace Webdemo.Models
{
    public partial class TKhachHang
    {
        public TKhachHang()
        {
            THoaDons = new HashSet<THoaDon>();
        }

        public int MaKh { get; set; }
        public string? Username { get; set; }
        public string? TenKh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public int? Sdt { get; set; }
        public string? Email { get; set; }
        public string? DiaChi { get; set; }
        public string? LoaiKh { get; set; }
        public string? AnhDaiDien { get; set; }
        public string? GhiChu { get; set; }

        public virtual TUser? UsernameNavigation { get; set; }
        public virtual ICollection<THoaDon> THoaDons { get; set; }
    }
}
