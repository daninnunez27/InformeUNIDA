using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ExportImportNotasVirtual
    {
        public string Cexportacion { get; set; }
        public int? Cprofesor { get; set; }
        public string CcursoMoodle { get; set; }
        public string Cingreso { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaExportacion { get; set; }
        public DateTime? FechaImportacion { get; set; }
        public decimal? Nota { get; set; }
    }
}
