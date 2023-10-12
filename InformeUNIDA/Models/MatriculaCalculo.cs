using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class MatriculaCalculo
    {
        public int Ntransaccion { get; set; }
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Calumno { get; set; }
        public string Cingreso { get; set; }
        public int Cpersona { get; set; }
        public int Ccarrera { get; set; }
        public int Ccurso { get; set; }
        public int Cbloque { get; set; }
        public short GestadoFicha { get; set; }
        public short Cmodalidad { get; set; }
        public short NcredReal { get; set; }
        public decimal Icredito { get; set; }
        public short GtipoCredito { get; set; }
        public decimal Itotal { get; set; }
        public string GtipoCalculo { get; set; }
        public string StipoPrecio { get; set; }
        public string Svigen { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
