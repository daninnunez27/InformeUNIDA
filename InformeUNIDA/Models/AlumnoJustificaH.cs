using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoJustificaH
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Calumno { get; set; }
        public short Njustifica { get; set; }
        public short Cmotivo { get; set; }
        public DateTime Fdesde { get; set; }
        public DateTime Fhasta { get; set; }
        public short? Ndia { get; set; }
        public short Ccurso { get; set; }
        public int Cbloque { get; set; }
        public string Dsustento { get; set; }
        public string Gprocede { get; set; }
        public string GincluyeIngles { get; set; }
        public string Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Nfaltas { get; set; }
        public short? GtipoHora { get; set; }
    }
}
