using System;
using System.Collections.Generic;

namespace Webdemo.Models
{
    public partial class TThoiGian
    {
        public TThoiGian()
        {
            TChiTietTours = new HashSet<TChiTietTour>();
        }

        public int MaTg { get; set; }
        public string ThoiGian { get; set; } = null!;

        public virtual ICollection<TChiTietTour> TChiTietTours { get; set; }
    }
}
