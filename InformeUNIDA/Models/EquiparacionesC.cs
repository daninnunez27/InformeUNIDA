using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EquiparacionesC
    {
        public EquiparacionesC()
        {
            EquiparacionesDs = new HashSet<EquiparacionesD>();
        }

        public int Id { get; set; }
        public int? Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public int Ccarrera { get; set; }
        public int? Calumno { get; set; }
        public int? Cperiodo { get; set; }
        public int? GtipoAprobacion { get; set; }
        public string Tresolucion { get; set; }
        public DateTime? Fresolucion { get; set; }
        public string Funcion { get; set; }
        public int? CredDesaprobar { get; set; }
        public int? CredAprobar { get; set; }
        public DateTime? Fcreacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int Procesado { get; set; }
        public int? Nveces { get; set; }
        public string Observacion { get; set; }
        public string ProcEquiv { get; set; }

        public virtual ICollection<EquiparacionesD> EquiparacionesDs { get; set; }
    }
}
