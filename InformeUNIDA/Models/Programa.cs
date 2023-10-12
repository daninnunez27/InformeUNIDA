using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Programa
    {
        public Programa()
        {
            Periodos = new HashSet<Periodo>();
        }

        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public string Dprograma { get; set; }
        public string Sprograma { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Ginfosil { get; set; }
        public decimal? NnotaMinima { get; set; }
        public decimal? NnotaMaxima { get; set; }
        public string GprocesaAsist { get; set; }
        public string GeventoExtra { get; set; }
        public int CgrupoCatProf { get; set; }

        public virtual Institucion CinstitucionNavigation { get; set; }
        public virtual ICollection<Periodo> Periodos { get; set; }
    }
}
