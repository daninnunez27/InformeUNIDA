using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class InvEquipo
    {
        public string NserieEquipo { get; set; }
        public short Clocal { get; set; }
        public short Calmacen { get; set; }
        public string NserieFab { get; set; }
        public string Tobservacion { get; set; }
        public short Gmarca { get; set; }
        public short? Gmodelo { get; set; }
        public short Gtipo { get; set; }
        public DateTime Fingreso { get; set; }
        public decimal? Ncapacidad { get; set; }
        public decimal? Nmemoria { get; set; }
        public short? Gprocesador { get; set; }
        public short? Nvelocidad { get; set; }
        public short Gestado { get; set; }
        public int? Cinstitucion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
