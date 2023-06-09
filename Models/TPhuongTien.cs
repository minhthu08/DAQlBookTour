using System;
using System.Collections.Generic;

namespace Webdemo.Models
{
    public partial class TPhuongTien
    {
        public TPhuongTien()
        {
            TTours = new HashSet<TTour>();
        }

        public int MaPt { get; set; }
        public string LoaiPt { get; set; } = null!;

        public virtual ICollection<TTour> TTours { get; set; }
    }
}
