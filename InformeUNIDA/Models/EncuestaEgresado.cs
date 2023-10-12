﻿using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EncuestaEgresado
    {
        public int Cencuesta { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Calumno { get; set; }
        public int Preguntanumero { get; set; }
        public bool? Resp1 { get; set; }
        public bool? Resp2 { get; set; }
        public bool? Resp3 { get; set; }
        public bool? Resp4 { get; set; }
        public bool? Resp5 { get; set; }
        public string Resp6 { get; set; }
        public DateTime? Fecharegistro { get; set; }
        public string Cuestionario { get; set; }
        public int? Ccarrera { get; set; }
    }
}