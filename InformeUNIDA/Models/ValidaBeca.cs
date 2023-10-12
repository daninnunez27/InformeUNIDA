using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ValidaBeca
    {
        public int Cperiodo { get; set; }
        public int Calumno { get; set; }
        public decimal? NporcBecaCuo { get; set; }
        public int? Cconvenio { get; set; }
        public string Dglosa { get; set; }
        public DateTime? Ffecha { get; set; }
    }
}
