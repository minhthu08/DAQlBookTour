using System;
using System.Collections.Generic;

namespace Webdemo.Models
{
    public partial class TAnhTour
    {
        public int MaTour { get; set; }
        public string? Tenfile { get; set; }
        public string? Vitri { get; set; }

        public virtual TTour MaTourNavigation { get; set; } = null!;
    }
}
