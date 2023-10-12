﻿using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BloqueCurso
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Cbloque { get; set; }
        public short Ccurso { get; set; }
        public int? Cresponsable { get; set; }
        public short? Cesquema { get; set; }
        public short? Ncupo { get; set; }
        public short? Nreservado { get; set; }
        public short? Nmatriculado { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public DateTime? Finicio { get; set; }
        public DateTime? Ffinal { get; set; }
        public short? Nsemana { get; set; }
        public short? Gcondicion { get; set; }
        public string Turl { get; set; }
        public string Tfolio { get; set; }
        public short? CodigoPractica { get; set; }
        public string Ssesion { get; set; }
        public short? Ccompania { get; set; }
        public int? Iingles { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }

        public virtual Bloque CbloqueNavigation { get; set; }
        public virtual Curso CcursoNavigation { get; set; }
        public virtual Periodo CperiodoNavigation { get; set; }
    }
}
