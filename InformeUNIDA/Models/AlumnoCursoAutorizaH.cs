using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoCursoAutorizaH
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Calumno { get; set; }
        public short Ccurso { get; set; }
        public string GautorizaParcial { get; set; }
        public string GautorizaFinal { get; set; }
        public string CmodificacionParcial { get; set; }
        public DateTime? FmodificacionParcial { get; set; }
        public string CmodificacionFinal { get; set; }
        public DateTime? FmodificacionFinal { get; set; }
        public decimal? IdeudaMn { get; set; }
        public decimal? IdeudaMe { get; set; }
    }
}
