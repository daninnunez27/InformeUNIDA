using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaUsuarioConfiguraTimbrado
    {
        public short Cinstitucion { get; set; }
        public int Codigo { get; set; }
        public string StipoUso { get; set; }
        public int Nserie { get; set; }
        public int NnumeroInicio { get; set; }
        public int NnumeroFinal { get; set; }
        public int Timbrado { get; set; }
        public DateTime? ValidacionDesde { get; set; }
        public DateTime? ValidacionHasta { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
