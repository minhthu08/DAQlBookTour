using System;
using System.Collections.Generic;

namespace Webdemo.Models
{
    public partial class TUser
    {
        public TUser()
        {
            TKhachHangs = new HashSet<TKhachHang>();
            TNhanViens = new HashSet<TNhanVien>();
        }

        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string LoaiUser { get; set; } = null!;

        public virtual ICollection<TKhachHang> TKhachHangs { get; set; }
        public virtual ICollection<TNhanVien> TNhanViens { get; set; }
    }
}
