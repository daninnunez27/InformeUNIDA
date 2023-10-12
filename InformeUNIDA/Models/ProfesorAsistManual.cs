using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ProfesorAsistManual
    {
        public int Registro { get; set; }
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short? Cperiodo { get; set; }
        public short? GtipoAsistencia { get; set; }
        public DateTime? FinicioProg { get; set; }
        public short? Cprofesor { get; set; }
        public DateTime? HinicioAsist { get; set; }
        public DateTime? HfinalAsist { get; set; }
        public DateTime? HorasMarcadas { get; set; }
        public short? Ccurso { get; set; }
        public short? Ccarrera { get; set; }
        public string Tobservacion { get; set; }
        public short? Gestado { get; set; }
        public short? EstadoPago { get; set; }
        public short? Cplanilla { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
