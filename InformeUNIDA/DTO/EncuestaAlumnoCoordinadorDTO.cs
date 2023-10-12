using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformeUNIDA.DTO
{
    public class EncuestaAlumnoCoordinadorDTO
    {
        public Int32 cinstitucion { get; set; }
        public String dinstitucion { get; set; }
        public Int32 cprograma { get; set; }
        public String dprograma { get; set; }
        public Int32 cperiodo { get; set; }
        public String dperiodo { get; set; }
        public Int32 ccarrera { get; set; }
        public String dcarrera { get; set; }
        public Int32 cusuario_coordinador { get; set; }
        public String dusuario { get; set; }
        public Int32 parte { get; set; }
        public Int32 preguntanumero { get; set; }
        public String preguntadescripcion { get; set; }
        public Int32 SI { get; set; }
        public Int32 NO { get; set; }
        public Int32 muy_en_desacuerdo { get; set; }
        public Int32 en_desacuerdo { get; set; }
        public Int32 neutro { get; set; }
        public Int32 de_acuerdo { get; set; }
        public Int32 muy_de_acuerdo { get; set; }
        public Double promedio_pregunta { get; set; }
        public Double cant_alumnos { get; set; }
    }
}
