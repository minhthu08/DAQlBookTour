using System;
using System.Collections.Generic;

namespace Webdemo.Models
{
    public partial class TDiaDiem
    {
        public TDiaDiem()
        {
            TTours = new HashSet<TTour>();
        }

        public int MaDd { get; set; }
        public string TenDiaDiem { get; set; } = null!;
        public string? ChiTietDiaDiem { get; set; }

        public virtual ICollection<TTour> TTours { get; set; }
    }
}
