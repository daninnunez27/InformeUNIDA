using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BloqueAlumnosPosgrado
    {
        public int Registro { get; set; }
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short? Cperiodo { get; set; }
        public short? Cbloque { get; set; }
        public short? Ccurso { get; set; }
        public short? Calumno { get; set; }
        public short? Ccarrera { get; set; }
        public short? CperiodoOrigen { get; set; }
        public short? Gestado { get; set; }
        public short? Condicion { get; set; }
        public short? Nveces { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
