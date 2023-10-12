using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Equiparacione
    {
        public int? Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public int Ccurso { get; set; }
        public int Calumno { get; set; }
        public int GtipoAprobacion { get; set; }
        public int? Cperiodo { get; set; }
        public int? Ccurricula { get; set; }
        public string Tresolucion { get; set; }
        public DateTime? Fresolucion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public int Id { get; set; }
        public int? Procesado { get; set; }
        public string InDel { get; set; }
        public int Secuencial { get; set; }
        public int Nvez { get; set; }
        public string Observacion { get; set; }
    }
}
