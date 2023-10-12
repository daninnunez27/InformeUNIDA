using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class VFicha
    {
        public short Cinstitucion { get; set; }
        public string Dinstitucion { get; set; }
        public short Cprograma { get; set; }
        public string Dprograma { get; set; }
        public short Cperiodo { get; set; }
        public string Dperiodo { get; set; }
        public short Ccarrera { get; set; }
        public string Dcarrera { get; set; }
        public short Ccurso { get; set; }
        public string ScursoU { get; set; }
        public string Dcurso { get; set; }
        public int? Cbloque { get; set; }
        public string Dbloque { get; set; }
        public int Calumno { get; set; }
        public string Cingreso { get; set; }
        public string Nombre { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public string Tcorreo { get; set; }
        public int? GdocIdentidad { get; set; }
        public string DocIdentidad { get; set; }
        public string NdocIdentidad { get; set; }
        public short? Gestado { get; set; }
        public string Destado { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
