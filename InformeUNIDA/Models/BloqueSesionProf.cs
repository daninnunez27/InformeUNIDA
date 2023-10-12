using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BloqueSesionProf
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Cbloque { get; set; }
        public short Ccurso { get; set; }
        public short Ndia { get; set; }
        public DateTime Hinicio { get; set; }
        public short Cprofesor { get; set; }
        public short Nprofesor { get; set; }
        public string GasistInfosil { get; set; }
        public string Gvirtual { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
