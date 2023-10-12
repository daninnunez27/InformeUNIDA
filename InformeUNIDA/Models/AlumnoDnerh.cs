using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoDnerh
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Calumno { get; set; }
        public int Ccurso { get; set; }
        public int Cbloque { get; set; }
        public string Grupo { get; set; }
        public int Chospital { get; set; }
        public DateTime MesDesde { get; set; }
        public DateTime? MesHasta { get; set; }
        public string Lu { get; set; }
        public string Ma { get; set; }
        public string Mi { get; set; }
        public string Ju { get; set; }
        public string Vi { get; set; }
        public string Sa { get; set; }
        public string HorarioDesde { get; set; }
        public string HorarioHasta { get; set; }
        public int? TotalGuardia { get; set; }
        public int? Ctutor { get; set; }
        public int? CcampoPractica { get; set; }
        public string CursoBioseguridad { get; set; }
        public string ContratoFirmado { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
