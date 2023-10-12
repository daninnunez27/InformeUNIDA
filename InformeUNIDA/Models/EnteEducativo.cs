using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EnteEducativo
    {
        public EnteEducativo()
        {
            PersonaExperiencia = new HashSet<PersonaExperiencium>();
            PersonaIdiomas = new HashSet<PersonaIdioma>();
            PersonaMencions = new HashSet<PersonaMencion>();
        }

        public short Ceducativo { get; set; }
        public string Deducativo { get; set; }
        public string Seducativo { get; set; }
        public short GtipoEnte { get; set; }
        public string Tdireccion { get; set; }
        public short? Cpais { get; set; }
        public short? Cdepartamento { get; set; }
        public short? Cprovincia { get; set; }
        public short? Cdistrito { get; set; }
        public short? Gcategoria { get; set; }
        public string Contacto1 { get; set; }
        public string Contacto2 { get; set; }
        public string Contacto3 { get; set; }
        public string Dcontacto1X { get; set; }
        public short? Gcargo1X { get; set; }
        public string Dcontacto2X { get; set; }
        public short? Gcargo2X { get; set; }
        public string Dcontacto3X { get; set; }
        public short? Gcargo3X { get; set; }
        public string Ntelefono1 { get; set; }
        public string Ntelefono2 { get; set; }
        public string Ntelefono3 { get; set; }
        public string Nfax { get; set; }
        public short? Gtipo1 { get; set; }
        public short? Gtipo2 { get; set; }
        public short? Gtipo3 { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Npension { get; set; }
        public short? Gmoneda { get; set; }
        public string Temail { get; set; }
        public short? Ncuota { get; set; }
        public short? Ncantidad1 { get; set; }
        public short? Ncantidad2 { get; set; }
        public short? Ncantidad3 { get; set; }
        public decimal? NimpMatricula { get; set; }
        public decimal? NimpApafa { get; set; }
        public decimal? NimpOtro { get; set; }
        public short? Nnivel { get; set; }
        public short? Gcategoria2 { get; set; }
        public decimal? NtipoCambio { get; set; }
        public short? Cpromotor { get; set; }
        public short? Gidioma1 { get; set; }
        public short? Gidioma2 { get; set; }
        public DateTime? Faniversario { get; set; }
        public string Twww { get; set; }
        public short? Gclasificacion { get; set; }
        public string Grree { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public int? GsectorEnte { get; set; }
        public DateTime? FconvenioPrimero { get; set; }
        public DateTime? FconvenioUltimo { get; set; }

        public virtual ICollection<PersonaExperiencium> PersonaExperiencia { get; set; }
        public virtual ICollection<PersonaIdioma> PersonaIdiomas { get; set; }
        public virtual ICollection<PersonaMencion> PersonaMencions { get; set; }
    }
}
