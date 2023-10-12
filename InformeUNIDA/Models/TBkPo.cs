using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TBkPo
    {
        public short Cadmision { get; set; }
        public int Cpersona { get; set; }
        public int Cpostulante { get; set; }
        public short Ccarrera1 { get; set; }
        public int? Cmodalidad1 { get; set; }
        public short? Ccarrera2 { get; set; }
        public decimal? Npuntaje { get; set; }
        public short? Npuesto { get; set; }
        public short? Gcondicion { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Isecundaria { get; set; }
        public short? GtipoExonerado { get; set; }
        public short? Ceducativo { get; set; }
        public short? GcatEnteEdu { get; set; }
        public short? Gcategoria { get; set; }
        public short? NanioEgreso { get; set; }
        public string Cingreso { get; set; }
        public short? Ceducativo2 { get; set; }
        public string TipoPago { get; set; }
        public short? ClistaPrecio { get; set; }
        public string Cingreso2 { get; set; }
        public string Tobservacion { get; set; }
        public string Scategprog { get; set; }
        public short? Ginteres { get; set; }
        public DateTime? Faprobacion { get; set; }
        public short? Ccompania { get; set; }
        public DateTime? FpagoReserva { get; set; }
        public DateTime? FpagoMatricula { get; set; }
        public string Gparticular { get; set; }
        public string GcarreraDefinida { get; set; }
        public DateTime? FRecepcionCarta { get; set; }
        public string GRindioExplor { get; set; }
        public DateTime? FEntExpConv { get; set; }
        public short? Gmodalidad { get; set; }
        public string CtpdocCaja { get; set; }
        public int? NdocumCaja { get; set; }
        public string Gintegracion { get; set; }
        public DateTime? FRsptaConv { get; set; }
        public string Sreserva { get; set; }
        public string Dreserva { get; set; }
        public string Sretiro { get; set; }
        public string Dretiro { get; set; }
        public string Dcomentario { get; set; }
        public DateTime? FasignaCateg { get; set; }
        public string SasistioEntrevis { get; set; }
        public string GasistiraCharla { get; set; }
        public short? GtipoContacto { get; set; }
        public DateTime? FCartaBienestar { get; set; }
        public short? CcarreraPrevia { get; set; }
        public string GrendiraExamen { get; set; }
        public short? GrsptaPostul { get; set; }
        public string GpostularaUsil { get; set; }
        public string GpostularaIsil { get; set; }
        public string GfichaBienestar { get; set; }
        public DateTime? FfichaBienestar { get; set; }
        public int? CinstitucionVend { get; set; }
        public int? CprogramaVend { get; set; }
        public string CingresoVend { get; set; }
        public int? CpersonaVend { get; set; }
        public string GestadoVend { get; set; }
        public string GfaxSolicita { get; set; }
        public DateTime? FfaxSolicita { get; set; }
        public short? ClocalPref { get; set; }
        public short? NcargaAcad { get; set; }
        public short? Cespecialidad { get; set; }
        public short? Cagrupamiento { get; set; }
        public int? CcarreraTraslado { get; set; }
    }
}
