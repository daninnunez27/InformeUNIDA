using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class MaterialH
    {
        public int? Cmaterial { get; set; }
        public string Scurso { get; set; }
        public string Dbloque { get; set; }
        public decimal? Ano { get; set; }
        public decimal? Semestre { get; set; }
        public decimal? Cprofesor { get; set; }
        public decimal? Calumno { get; set; }
        public string Dtitulo { get; set; }
        public string Tarchivo { get; set; }
        public string Tdescripcion { get; set; }
        public decimal? Ntamano { get; set; }
        public string Tipo { get; set; }
        public byte[] BinArchivo { get; set; }
        public DateTime? Fcreacion { get; set; }
        public int? Ccurso { get; set; }
        public int? Cbloque { get; set; }
        public int? Cperiodo { get; set; }
        public int? TipoMaterial { get; set; }
        public int? TipoTarea { get; set; }
        public int? Estado { get; set; }
        public int? Puntaje { get; set; }
        public string Referencia { get; set; }
        public string CmodificacionReferencia { get; set; }
        public DateTime? FmodificacionReferencia { get; set; }
        public int? Clog { get; set; }
        public int IdCreacion { get; set; }
        public DateTime? FechaLimite { get; set; }
        public string CmodificacionFechaLimite { get; set; }
        public DateTime? FmodificacionFechaLimite { get; set; }
        public string Link1 { get; set; }
        public string Link2 { get; set; }
        public string Link3 { get; set; }
        public string Link4 { get; set; }
        public int? TiempoTarea { get; set; }
        public string CmodificacionEstado { get; set; }
        public DateTime? FmodificacionEstado { get; set; }
        public string CmodificacionMover { get; set; }
        public DateTime? FmodificacionMover { get; set; }
    }
}
