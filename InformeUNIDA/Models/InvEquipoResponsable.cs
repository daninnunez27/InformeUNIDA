﻿using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class InvEquipoResponsable
    {
        public short Ctercero { get; set; }
        public string NserieEquipo { get; set; }
        public short Gestado { get; set; }
        public short? Cpabellon { get; set; }
        public short? Carea { get; set; }
        public string Gcompartido { get; set; }
        public string Nip { get; set; }
        public string TgrupoTrabajo { get; set; }
        public string Tobservacion { get; set; }
        public DateTime Fasignacion { get; set; }
        public DateTime? Fbaja { get; set; }
        public int? Clocal { get; set; }
        public int? Calmacen { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
