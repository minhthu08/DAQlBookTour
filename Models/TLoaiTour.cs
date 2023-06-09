using System;
using System.Collections.Generic;

namespace Webdemo.Models
{
    public partial class TLoaiTour
    {
        public TLoaiTour()
        {
            TTours = new HashSet<TTour>();
        }

        public int MaLoai { get; set; }
        public string? LoaiTour { get; set; }

        public virtual ICollection<TTour> TTours { get; set; }
    }
}
