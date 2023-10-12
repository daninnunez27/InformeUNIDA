using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class VBancaObligacionMovimientoPagoPorInteraccion
    {
        public int? Cinteraccion { get; set; }
        public decimal? Efectivo { get; set; }
        public decimal? TarjetaCredito { get; set; }
        public decimal? TarjetaDebito { get; set; }
        public decimal? Cheques { get; set; }
        public decimal? PagoExpress { get; set; }
        public decimal? DepositosEnCuenta { get; set; }
        public decimal? VisionBanco { get; set; }
        public decimal? AquiPago { get; set; }
        public decimal? CanjePublicitarioRrhh { get; set; }
        public decimal? CobranzaPorCobrar { get; set; }
        public decimal? Otros { get; set; }
        public decimal? Documenta { get; set; }
    }
}
