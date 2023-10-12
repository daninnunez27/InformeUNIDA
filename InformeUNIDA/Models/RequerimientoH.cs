using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class RequerimientoH
    {
        public int Ninterno { get; set; }
        public int Nrequerimiento { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Calumno { get; set; }
        public int Ccarrera { get; set; }
        public string Cingreso { get; set; }
        public int Gturno { get; set; }
        public int Gtipo { get; set; }
        public DateTime Fsolicitado { get; set; }
        public int Catendido { get; set; }
        public string Dglosa { get; set; }
        public DateTime? FultimoFlujo { get; set; }
        public DateTime? Fcierre { get; set; }
        public string Gestado { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Tipo { get; set; }
        public DateTime Fauditoria { get; set; }
        public DateTime? Farchivado { get; set; }
    }
}
