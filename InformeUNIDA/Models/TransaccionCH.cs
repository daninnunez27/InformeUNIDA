using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TransaccionCH
    {
        public int Ctransaccion { get; set; }
        public short? Cvisitante { get; set; }
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public int? Calumno { get; set; }
        public string Cempre { get; set; }
        public string Ctrabajador { get; set; }
        public DateTime Fprestamo { get; set; }
        public int NitemPrestado { get; set; }
        public int NitemDevuelto { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int? Cpersona { get; set; }
        public string Gnaturaleza { get; set; }
    }
}
