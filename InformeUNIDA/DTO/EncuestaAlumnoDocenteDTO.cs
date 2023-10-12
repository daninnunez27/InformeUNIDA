using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformeUNIDA.DTO
{
    public class EncuestaAlumnoDocenteDTO
    {
        public Int32 cinstitucion { get; set; }
        public String dinstitucion { get; set; }
        public Int32 cprograma { get; set; }
        public String dprograma { get; set; }
        public Int32 cperiodo { get; set; }
        public String dperiodo { get; set; }
        public Int32 ccarrera { get; set; }
        public String dcarrera { get; set; }
        public Int32 cprofesor { get; set; }
        public String dprofesor { get; set; }
        public Int32 ccurso { get; set; }
        public String dcurso { get; set; }
        public Int32 cbloque { get; set; }
        public String dbloque { get; set; }
        public Double promedio { get; set; }
        public Double cant_alumnos { get; set; }
    }
}
