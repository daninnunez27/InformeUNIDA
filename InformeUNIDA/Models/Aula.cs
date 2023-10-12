using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Aula
    {
        public short Clocal { get; set; }
        public int Cpabellon { get; set; }
        public short Caula { get; set; }
        public string Daula { get; set; }
        public string Saula { get; set; }
        public short? Npiso { get; set; }
        public short? Ncapacidad { get; set; }
        public int? NcapacidadMax { get; set; }
        public short? NcapacidadA { get; set; }
        public short? NcapacidadB { get; set; }
        public short? NcapacidadC { get; set; }
        public short? GtipoAula { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Gestado { get; set; }
        public string Nip { get; set; }
        public short? Gtv { get; set; }
        public short? Gvhs { get; set; }
        public short? Gconvertidor { get; set; }
        public short? Gretroproy { get; set; }
        public short? Gpc { get; set; }
        public short? Gcanon { get; set; }
        public short? Gecran { get; set; }
        public short? Nfotos { get; set; }
    }
}
