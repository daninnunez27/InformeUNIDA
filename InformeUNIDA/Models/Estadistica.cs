using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Estadistica
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Calumno { get; set; }
        public short Ccarrera { get; set; }
        public short Nprioridad { get; set; }
        public DateTime Fmatricula { get; set; }
        public DateTime Hinicio { get; set; }
        public DateTime Hfinal { get; set; }
        public short? Gmatricula { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
