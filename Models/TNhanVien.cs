using System;
using System.Collections.Generic;

namespace Webdemo.Models
{
    public partial class TNhanVien
    {
        public TNhanVien()
        {
            THoaDons = new HashSet<THoaDon>();
        }

        public int MaNv { get; set; }
        public string Username { get; set; } = null!;
        public string TenNv { get; set; } = null!;
        public DateTime NgaySinh { get; set; }
        public int Sdt1 { get; set; }
        public int Sdt2 { get; set; }
        public string DiaChi { get; set; } = null!;
        public string ChucVu { get; set; } = null!;
        public string AnhDaiDien { get; set; } = null!;
        public string? GhiChu { get; set; }

        public virtual TUser UsernameNavigation { get; set; } = null!;
        public virtual ICollection<THoaDon> THoaDons { get; set; }
    }
}
