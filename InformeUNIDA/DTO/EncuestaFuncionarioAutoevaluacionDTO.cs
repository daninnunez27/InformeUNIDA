using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformeUNIDA.DTO
{
    public class EncuestaFuncionarioAutoevaluacionDTO
    {
        public Int32 cinstitucion { get; set; }
        public String dinstitucion { get; set; }
        public Int32 anio { get; set; }
        public Int32 preguntanumero { get; set; }
        public String preguntadescripcion { get; set; }
        public Double promedio_pregunta { get; set; }
        public Double promedio_anio { get; set; }
        public Double cant_funcionarios { get; set; }
    }
}
