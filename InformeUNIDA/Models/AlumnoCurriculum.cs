using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoCurriculum
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public int Calumno { get; set; }
        public short Ccarrera { get; set; }
        public short Ccurriculum { get; set; }
        public short? Cperfil { get; set; }
        public short? Ggradoinstruccion { get; set; }
        public short? Gdisponibilidad { get; set; }
        public short? Garea1 { get; set; }
        public short? Garea2 { get; set; }
        public short? Garea3 { get; set; }
        public short? Gsector { get; set; }
        public short? Grubro { get; set; }
        public short? Gtiempo { get; set; }
        public string Tobservacion { get; set; }
        public short? Gestado { get; set; }
    }
}
