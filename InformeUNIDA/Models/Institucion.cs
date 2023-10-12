using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Institucion
    {
        public Institucion()
        {
            FuncionarioWebs = new HashSet<FuncionarioWeb>();
            Programas = new HashSet<Programa>();
        }

        public short Cinstitucion { get; set; }
        public string Dinstitucion { get; set; }
        public string Sinstitucion { get; set; }
        public string Nruc { get; set; }
        public short? Gestado { get; set; }
        public string Tdireccion { get; set; }
        public string Ntelefono1 { get; set; }
        public string Ntelefono2 { get; set; }
        public string Nfax { get; set; }
        public string Tcontacto { get; set; }
        public short? Gcargo { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }

        public virtual ICollection<FuncionarioWeb> FuncionarioWebs { get; set; }
        public virtual ICollection<Programa> Programas { get; set; }
    }
}
