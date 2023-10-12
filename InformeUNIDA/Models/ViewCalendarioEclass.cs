using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ViewCalendarioEclass
    {
        public string Title { get; set; }
        public string Start { get; set; }
        public string ColorEvento { get; set; }
        public int? Guso { get; set; }
        public int? Cprograma { get; set; }
        public DateTime? Ffecha { get; set; }
    }
}
