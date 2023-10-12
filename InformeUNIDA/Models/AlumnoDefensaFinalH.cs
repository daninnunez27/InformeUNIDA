using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoDefensaFinalH
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Ccarrera { get; set; }
        public int Cperiodo { get; set; }
        public int Calumno { get; set; }
        public DateTime Fdefensa { get; set; }
        public string Examinador1 { get; set; }
        public string Examinador2 { get; set; }
        public string Examinador3 { get; set; }
        public string Examinador4 { get; set; }
        public string Examinador5 { get; set; }
        public decimal Nnota1 { get; set; }
        public decimal Nnota2 { get; set; }
        public int Gaprobado { get; set; }
        public string Ccreacion { get; set; }
        public DateTime Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int? ClineaInvestigacion { get; set; }
        public string TesisNombre1 { get; set; }
        public string TesisNombre2 { get; set; }
        public string TesisFecha { get; set; }
        public string TesisNota { get; set; }
        public DateTime Tipo { get; set; }
        public short Fauditoria { get; set; }
    }
}
