using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoRetiro
    {
        public string Gmodulo { get; set; }
        public int? Ntransaccion { get; set; }
        public short Gtipo { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Calumno { get; set; }
        public int Ccurso { get; set; }
        public int? Cbloque { get; set; }
        public DateTime Ftransaccion { get; set; }
        public short Gestado { get; set; }
        public DateTime? Fconfirmacion { get; set; }
        public short? Gmotivo { get; set; }
        public string Dglosa { get; set; }
    }
}
