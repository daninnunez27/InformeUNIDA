using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TCua
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Ccurricula { get; set; }
        public short Ccarrera { get; set; }
        public string Dcurricula { get; set; }
        public string Scurricula { get; set; }
        public short Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Dobservacion { get; set; }
        public short? Cespecialidad { get; set; }
        public decimal? NnotaAprob { get; set; }
        public string Speriodo { get; set; }
        public int Cperiodo { get; set; }
    }
}
