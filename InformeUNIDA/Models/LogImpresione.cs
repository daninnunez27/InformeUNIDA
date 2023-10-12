using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class LogImpresione
    {
        public string DtipoImpresion { get; set; }
        public int? Cperiodo { get; set; }
        public short? GtipoNota { get; set; }
        public int? Ccurso { get; set; }
        public int? Cbloque { get; set; }
        public int? Calumno { get; set; }
        public string Cusuario { get; set; }
        public DateTime? Fimpresion { get; set; }
    }
}
