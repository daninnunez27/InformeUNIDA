using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoDefensaFinal
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Ccarrera { get; set; }
        public int Cperiodo { get; set; }
        public int Calumno { get; set; }
        public int? Abrevtutor { get; set; }
        public int? Tutor { get; set; }
        public int? Abrev1 { get; set; }
        public int? Mesa1 { get; set; }
        public int? Abrev2 { get; set; }
        public int? Mesa2 { get; set; }
        public int? Abrev3 { get; set; }
        public int? Mesa3 { get; set; }
        public string BorradorObservacion { get; set; }
        public int? BorradorEstado { get; set; }
        public int? NroActa { get; set; }
        public int? AnioActa { get; set; }
        public int? EstadoPago { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public byte[] Tesis { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public string CmodificacionTesis { get; set; }
        public DateTime? FmodificacionTesis { get; set; }
        public int? ClineaInvestigacion { get; set; }
        public string TesisNombre1 { get; set; }
        public string TesisNombre2 { get; set; }
        public DateTime? TesisFecha { get; set; }
        public short? TesisNota { get; set; }
    }
}
