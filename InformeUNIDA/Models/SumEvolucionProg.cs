using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SumEvolucionProg
    {
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short? Cpromocion { get; set; }
        public short? NsecuPromocion { get; set; }
        public short? Cperiodo { get; set; }
        public short? NsecuPeriodo { get; set; }
        public short? GtipoPeriodo { get; set; }
        public short? Ccarrera { get; set; }
        public int? Qmatriculados { get; set; }
        public int? Qactivos { get; set; }
        public int? Qegresados { get; set; }
        public int? QexpConducta { get; set; }
        public int? QexpNotas { get; set; }
        public int? Qreservas { get; set; }
        public int? QretDefinitivo { get; set; }
        public int? QretPeriodo { get; set; }
    }
}
