using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class NotaCredeb
    {
        public int CtipoNota { get; set; }
        public int Ncredeb { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Cobligacion { get; set; }
        public DateTime Femision { get; set; }
        public int Cconcepto { get; set; }
        public int Calumno { get; set; }
        public int Cpersona { get; set; }
        public string Dmotivo { get; set; }
        public decimal Ibruto { get; set; }
        public decimal Idscto { get; set; }
        public decimal Itneto { get; set; }
        public DateTime Fvencimiento { get; set; }
        public DateTime Fcreacion { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Cmodificacion { get; set; }
    }
}
