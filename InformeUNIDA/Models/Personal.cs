using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Personal
    {
        public string CoTrab { get; set; }
        public string NoApelPate { get; set; }
        public string NoApelMate { get; set; }
        public string NoApelCasa { get; set; }
        public string NoTrab { get; set; }
        public string CoEmpr { get; set; }
        public string DeNomb { get; set; }
        public string CoArea { get; set; }
        public string DeArea { get; set; }
        public DateTime? FeNaciTrab { get; set; }
        public string TiDocuIden { get; set; }
        public string NuDocuIden { get; set; }
        public string DeTipoSitu { get; set; }
    }
}
