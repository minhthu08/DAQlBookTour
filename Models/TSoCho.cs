using System;
using System.Collections.Generic;

namespace Webdemo.Models
{
    public partial class TSoCho
    {
        public TSoCho()
        {
            TChiTietTours = new HashSet<TChiTietTour>();
        }

        public int MaSoCho { get; set; }
        public int SoCho { get; set; }

        public virtual ICollection<TChiTietTour> TChiTietTours { get; set; }
    }
}
