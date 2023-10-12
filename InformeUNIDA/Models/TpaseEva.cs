using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TpaseEva
    {
        public short Cevaluacion { get; set; }
        public string Devaluacion { get; set; }
        public string Sevaluacion { get; set; }
        public short Cadmision { get; set; }
        public DateTime? Fexamen { get; set; }
        public DateTime? Fvencimiento { get; set; }
        public short? Ngrado { get; set; }
        public short? IdistribucionAuto { get; set; }
        public short? Ivisible { get; set; }
        public short? Ccampania { get; set; }
        public short? Nproceso { get; set; }
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? IaprobacionAuto { get; set; }
        public short? IverFecha { get; set; }
        public short? Nescala { get; set; }
        public short? IverHora { get; set; }
        public short? IverInstitucion { get; set; }
        public short? GformatoFecha { get; set; }
        public short? Gentrevista { get; set; }
        public short? IpasaJunior { get; set; }
        public string GcarreXDefinir { get; set; }
        public short? CcampaniaAsoc { get; set; }
    }
}
