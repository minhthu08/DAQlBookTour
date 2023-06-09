using System;
using System.Collections.Generic;

namespace Webdemo.Models
{
    public partial class TNguoi
    {
        public TNguoi()
        {
            TTours = new HashSet<TTour>();
        }

        public int MaNguoi { get; set; }
        public string? LoaiNguoi { get; set; }

        public virtual ICollection<TTour> TTours { get; set; }
    }
}
