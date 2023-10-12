using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlertaAlumno
    {
        public int Ntransaccion { get; set; }
        public short Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Ccarrera { get; set; }
        public int Calumno { get; set; }
        public int? Ccurso { get; set; }
        public int Calerta { get; set; }
        public string Dalerta { get; set; }
        public int? Gtiponota { get; set; }
        public DateTime Fcreacion { get; set; }
        public string Cresponsable { get; set; }
        public int? Nsecuencia { get; set; }
        public short Gestado { get; set; }
        public DateTime Fmodificacion { get; set; }
    }
}
