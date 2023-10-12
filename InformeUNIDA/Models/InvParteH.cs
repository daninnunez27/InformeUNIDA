using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class InvParteH
    {
        public string NserieParte { get; set; }
        public short? GtipoParte { get; set; }
        public short? Clocal { get; set; }
        public short? Calmacen { get; set; }
        public string NserieFabricante { get; set; }
        public string Dparte { get; set; }
        public string Tobservacion { get; set; }
        public short? Gmarca { get; set; }
        public short? Gmodelo { get; set; }
        public short? Gestado { get; set; }
        public decimal? Ncapacidad { get; set; }
        public DateTime? Fingreso { get; set; }
        public int? Cinstitucion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
