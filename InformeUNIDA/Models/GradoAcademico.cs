using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class GradoAcademico
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public int Calumno { get; set; }
        public string Cingreso { get; set; }
        public int Cpersona { get; set; }
        public short? CperiodoEgreso { get; set; }
        public int GgradoAcademico { get; set; }
        public DateTime? FechaEmision { get; set; }
        public int? Ntomo { get; set; }
        public int? Nfolio { get; set; }
        public int? Nasiento { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Ccarrera { get; set; }
        public string Tndiploma { get; set; }
        public string Tnresolucion { get; set; }
        public DateTime? FechaActoAcad { get; set; }
        public DateTime? FechaResolucion { get; set; }
        public short? Gautoridad1 { get; set; }
        public short? Gcargo1 { get; set; }
        public short? Gautoridad2 { get; set; }
        public short? Gcargo2 { get; set; }
        public short? Gautoridad3 { get; set; }
        public short? Gcargo3 { get; set; }
    }
}
