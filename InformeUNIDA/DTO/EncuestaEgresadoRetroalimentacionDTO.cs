using System;

namespace InformeUNIDA.DTO
{
    public class EncuestaEgresadoRetroalimentacionDTO
    {
        public Int32 cinstitucion { get; set; }
        public String dinstitucion { get; set; }
        public Int32 cprograma { get; set; }
        public String dprograma { get; set; }
        public Int32 cperiodo { get; set; }
        public String dperiodo { get; set; }
        public Int32 anio { get; set; }
        public Int32 ccarrera { get; set; }
        public String dcarrera { get; set; }
        public Int32 grupo { get; set; }
        public String preguntanumero { get; set; }
        public String preguntadescripcion { get; set; }
        public Int32 resp1 { get; set; }
        public Int32 resp2 { get; set; }
        public Int32 resp3 { get; set; }
        public Int32 resp4 { get; set; }
        public Int32 resp5 { get; set; }
        public Int32 resp6 { get; set; }
        public Int32 resp7 { get; set; }
        public Int32 resp8 { get; set; }
        public Int32 resp9 { get; set; }
        public Int32 resp10 { get; set; }
        public Int32 promedio_pregunta { get; set; }
        public Int32 cant_egresados { get; set; }

    }
}
