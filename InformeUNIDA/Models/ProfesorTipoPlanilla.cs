using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ProfesorTipoPlanilla
    {
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public short Cprofesor { get; set; }
        public string GtipoPlanilla { get; set; }
        public decimal? MontoMensual { get; set; }
        public decimal? MontoProyectado { get; set; }
        public short? Gestado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
