using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class VBloqueCursoAlumno
    {
        public short Cinstitucion { get; set; }
        public string Dinstitucion { get; set; }
        public short Cprograma { get; set; }
        public string Dprograma { get; set; }
        public short Cperiodo { get; set; }
        public string Dperiodo { get; set; }
        public short Ccurso { get; set; }
        public string Dcurso { get; set; }
        public string PlantillaCurso { get; set; }
        public int? Cbloque { get; set; }
        public string Dbloque { get; set; }
        public int Calumno { get; set; }
        public int Cpersona { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public string Nombre { get; set; }
        public string Cingreso { get; set; }
        public short Ccarrera { get; set; }
        public string Dcarrera { get; set; }
        public short EstadoAlumno { get; set; }
        public string DestadoAlumno { get; set; }
        public short? EstadoCurso { get; set; }
        public string DestadoCurso { get; set; }
        public string Ntelefono1 { get; set; }
        public string Tcorreo { get; set; }
        public int? GdocIdentidad { get; set; }
        public string DdocIdentidad { get; set; }
        public string NdocIdentidad { get; set; }
        public string TclaveMat { get; set; }
        public string Smodalidad { get; set; }
    }
}
