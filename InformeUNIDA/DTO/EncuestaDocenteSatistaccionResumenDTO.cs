using System;

namespace InformeUNIDA.DTO
{
    public class EncuestaDocenteSatistaccionResumenDTO
    {
        public String dinstitucion { get; set; }
        public String dprograma { get; set; }
        public String dperiodo { get; set; }
        public String dcarrera { get; set; }
        public Int32 preguntanumero { get; set; }
        public String preguntadescripcion { get; set; }
        public Int32 cant_resp1 { get; set; }
        public Int32 cant_resp2 { get; set; }
        public Int32 cant_resp3 { get; set; }
        public Int32 cant_resp4 { get; set; }
        public Int32 cant_resp5 { get; set; }
        public String item { get; set; }
        public String dimension { get; set; }

    }
}
