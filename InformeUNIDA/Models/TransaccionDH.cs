using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TransaccionDH
    {
        public int Ctransaccion { get; set; }
        public int Citem { get; set; }
        public int Cejemplar { get; set; }
        public DateTime? Fdevolucion { get; set; }
        public DateTime? FrealDevolucion { get; set; }
        public short GtipoPrestamo { get; set; }
        public short? CtransaccionRen { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Gestado { get; set; }
        public decimal? NimpMora { get; set; }
        public decimal? NimpMoraReal { get; set; }
        public string Gpago { get; set; }
        public int? NctaCte { get; set; }
    }
}
