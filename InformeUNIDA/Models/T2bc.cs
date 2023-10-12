using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class T2bc
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public short? Cperiodo { get; set; }
        public int? Cbloque { get; set; }
        public short? Ccurso { get; set; }
        public int Cesquema { get; set; }
        public int? Ncupo { get; set; }
        public int? Nreservado { get; set; }
        public int? Nmatriculado { get; set; }
        public int Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime Fmodificacion { get; set; }
        public int? Finicio { get; set; }
        public int? Ffinal { get; set; }
        public int? Nsemana { get; set; }
        public int Gcondicion { get; set; }
        public int? Turl { get; set; }
        public int? Tfolio { get; set; }
        public string Ssesion { get; set; }
        public int? Ccompania { get; set; }
    }
}
