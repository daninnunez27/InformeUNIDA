using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class VBibClasificacionReservaPendienteListum
    {
        public string Dpersona { get; set; }
        public string NdocIdentidad { get; set; }
        public int Creserva { get; set; }
        public int? Cclasificacion { get; set; }
        public string Ttitulo { get; set; }
        public string Tautor { get; set; }
        public string TubicacionFisica { get; set; }
        public string Teditorial { get; set; }
        public DateTime? Fhexpiracion { get; set; }
        public DateTime? Fhregistro { get; set; }
        public int? Cmovimiento { get; set; }
        public DateTime? Fhinicio { get; set; }
        public DateTime? Fhfin { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int? Cpersona { get; set; }
        public int? NcantidadDisponible { get; set; }
        public int? CclasificacionPadre { get; set; }
    }
}
