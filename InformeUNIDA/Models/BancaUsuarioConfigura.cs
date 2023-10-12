using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaUsuarioConfigura
    {
        public string Susuario { get; set; }
        public string StipoUso { get; set; }
        public int NserieUltimo { get; set; }
        public int NnumeroUltimo { get; set; }
        public string Tlugar { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Tobjeto { get; set; }
        public string Tobjeto2 { get; set; }
    }
}
