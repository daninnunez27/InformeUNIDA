using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Prioridad
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public string Cingreso { get; set; }
        public string Dcarrera { get; set; }
        public short? Nprioridad { get; set; }
        public DateTime? Fmatricula { get; set; }
        public DateTime? FmatriculaFinal { get; set; }
        public string Dmensaje { get; set; }
        public string Dpersona { get; set; }
    }
}
