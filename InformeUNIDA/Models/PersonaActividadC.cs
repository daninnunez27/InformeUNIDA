using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PersonaActividadC
    {
        public short Cactividad { get; set; }
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public int? Cadmision { get; set; }
        public int Cpersona { get; set; }
        public int? Ceducativo1 { get; set; }
        public short? NanioEgreso { get; set; }
        public short? Ccarrera1 { get; set; }
        public int? Cmodalidad1 { get; set; }
        public short? Ccarrera2 { get; set; }
        public int? Cmodalidad2 { get; set; }
        public short? Ccarrera3 { get; set; }
        public short? Gmodalidad { get; set; }
        public short? NgradoInteres { get; set; }
        public int? Ceducativo2 { get; set; }
        public short? Corigen { get; set; }
        public string Dcontacto { get; set; }
        public short? CmedioContacto { get; set; }
        public short? CesperaEnvio { get; set; }
        public string Gingreso { get; set; }
        public string Gtercio { get; set; }
        public short? Nopcion { get; set; }
        public string GasistioCharlas { get; set; }
        public string GinteresBeca { get; set; }
        public string GcomunicoIngreso { get; set; }
        public string GegreColegio { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int? Cconectado { get; set; }
        public string Dconectado { get; set; }
        public short? Cconvenio { get; set; }
        public short? Clocal { get; set; }
    }
}
