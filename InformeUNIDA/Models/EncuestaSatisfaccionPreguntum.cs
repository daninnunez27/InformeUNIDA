using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EncuestaSatisfaccionPreguntum
    {
        public string Preguntanumero { get; set; }
        public string Preguntadescripcion { get; set; }
        public string Resp1Desc { get; set; }
        public string Resp2Desc { get; set; }
        public string Resp3Desc { get; set; }
        public string Resp4Desc { get; set; }
        public string Resp5Desc { get; set; }
        public string Resp6Desc { get; set; }
        public string Texto1Desc { get; set; }
        public string Texto2Desc { get; set; }
        public string Cuestionario { get; set; }
    }
}
