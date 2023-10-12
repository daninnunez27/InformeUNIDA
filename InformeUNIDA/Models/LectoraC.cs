using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class LectoraC
    {
        public int Choja { get; set; }
        public short NchequeoHoja { get; set; }
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public short Ccurso { get; set; }
        public int Cbloque { get; set; }
        public short Cprofesor { get; set; }
        public short GtipoHora { get; set; }
        public short GtipoNota { get; set; }
        public short Npagina { get; set; }
        public short NpaginaTotal { get; set; }
        public short Nverifica { get; set; }
        public short NchequeoVerifica { get; set; }
        public short Gcondicion { get; set; }
        public short Gestado { get; set; }
        public short? NsnotaHoja { get; set; }
        public short? Nsnota { get; set; }
        public short? Ngrupo { get; set; }
        public short? Nlectura { get; set; }
    }
}
