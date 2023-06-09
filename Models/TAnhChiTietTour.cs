using System;
using System.Collections.Generic;

namespace Webdemo.Models
{
    public partial class TAnhChiTietTour
    {
        public int MaChiTietTour { get; set; }
        public string? Tenfile { get; set; }
        public string? ViTri { get; set; }

        public virtual TChiTietTour TChiTietTour { get; set; } = null!;
    }
}
