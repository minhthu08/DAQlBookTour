using System;
using System.Collections.Generic;

namespace Webdemo.Models
{
    public partial class TKhachSan
    {
        public TKhachSan()
        {
            TTours = new HashSet<TTour>();
        }

        public int MaKs { get; set; }
        public string TenKs { get; set; } = null!;
        public int SoSao { get; set; }

        public virtual ICollection<TTour> TTours { get; set; }
    }
}
