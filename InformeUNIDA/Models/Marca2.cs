using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Marca2
    {
        public string IniProg { get; set; }
        public string IniAsist { get; set; }
        public int? MinTarde { get; set; }
        public string FinalAsist { get; set; }
        public string FinalProg { get; set; }
        public int? MinAntes { get; set; }
        public string Dcarrera { get; set; }
        public short? Nciclo { get; set; }
        public string Dbloque { get; set; }
        public string Scurso { get; set; }
        public string Dcurso { get; set; }
        public short? Nmatriculado { get; set; }
        public string Profe { get; set; }
        public short? Ccarrera { get; set; }
        public int Cbloque { get; set; }
        public short Ccurso { get; set; }
        public short? Cprofesor { get; set; }
        public DateTime FinicioProg { get; set; }
        public DateTime? HinicioAsist { get; set; }
        public DateTime HfinalProg { get; set; }
        public DateTime? HfinalAsist { get; set; }
        public decimal? Nhoras { get; set; }
        public short? Gestado { get; set; }
    }
}
