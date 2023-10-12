using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformeUNIDA.DTO
{
    public class EncuestaAlumnoSatisfaccionDTO
    {
        public Int32 cinstitucion { get; set; }
        public String dinstitucion { get; set; }
        public Int32 cprograma { get; set; }
        public String dprograma { get; set; }
        public Int32 cperiodo { get; set; }
        public String dperiodo { get; set; }
        public Int32 ccarrera { get; set; }
        public String dcarrera { get; set; }
        public Int32 preguntanumero { get; set; }
        public String preguntadescripcion { get; set; }
        public Double promedio_pregunta { get; set; }
        public Double promedio_carrera { get; set; }
        public Double cant_alumnos { get; set; }
    }
}
