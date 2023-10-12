using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ProfesorContenidoH
    {
        public int? Id { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Ccurso { get; set; }
        public int Cbloque { get; set; }
        public int Cprofesor { get; set; }
        public DateTime? Fregistroclase { get; set; }
        public int? Gestado { get; set; }
        public string Dcontenido { get; set; }
        public short Cprofesormod { get; set; }
        public DateTime? Fcreacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short Clog { get; set; }
        public string Accion { get; set; }
    }
}
