using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoEgresadoImprentum
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public string Dperiodo { get; set; }
        public int? Calumno { get; set; }
        public string Cingreso { get; set; }
        public string Dpersona { get; set; }
        public string FechaEgreso { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string DcarreraImprenta { get; set; }
        public string DenominacionTitulo { get; set; }
        public string Rector { get; set; }
        public string SecretarioGeneral { get; set; }
        public string DecanoDirector { get; set; }
        public int? CperiodoIngreso { get; set; }
        public int? CperiodoEgreso { get; set; }
        public int? CusuarioCoordinador { get; set; }
        public int? Ccarrera { get; set; }
        public int Cinteraccion { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int? ImpresionNro { get; set; }
    }
}
