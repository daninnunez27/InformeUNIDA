using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoCurricEmp
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public int Calumno { get; set; }
        public short Ccarrera { get; set; }
        public short Ccurriculum { get; set; }
        public short Ccodigo { get; set; }
        public string Tempresa { get; set; }
        public short? Gcargo { get; set; }
        public DateTime? Fdesde { get; set; }
        public DateTime? Fhasta { get; set; }
    }
}
