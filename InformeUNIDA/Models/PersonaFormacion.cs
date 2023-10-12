using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PersonaFormacion
    {
        public int Cpersona { get; set; }
        public int? NtelefonoFijo { get; set; }
        public int? NtelefonoMovil { get; set; }
        public int? NtelefonoOtro { get; set; }
        public string Tprofesion { get; set; }
        public string Ttitulo { get; set; }
        public string TcentroEstudios { get; set; }
        public string Tpostgrado { get; set; }
        public string TcentroPostgrado { get; set; }
        public string Totro { get; set; }
        public string TcentroOtro { get; set; }
        public string TcentroDocencia1 { get; set; }
        public string TcentroDocencia2 { get; set; }
        public string Ttrabajo { get; set; }
        public string Tcargo { get; set; }
    }
}
