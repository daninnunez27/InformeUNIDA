using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Consultum
    {
        public Consultum()
        {
            Indicacions = new HashSet<Indicacion>();
        }

        public int Cconsulta { get; set; }
        public int? Cespecialista { get; set; }
        public int Cpaciente { get; set; }
        public DateTime Fconsulta { get; set; }
        public int Chorario { get; set; }
        public int Ndia { get; set; }
        public DateTime Hinicio { get; set; }
        public decimal? Precio { get; set; }
        public string Stipo { get; set; }
        public string Sobservacion { get; set; }
        public int? Ccomprobante { get; set; }
        public string Sestado { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int? FlagExonerado { get; set; }
        public string Motivoconsulta { get; set; }
        public string Cmodificacionexonerado { get; set; }
        public DateTime? Fmodificacionexonerado { get; set; }

        public virtual Especialistum CespecialistaNavigation { get; set; }
        public virtual Paciente CpacienteNavigation { get; set; }
        public virtual ICollection<Indicacion> Indicacions { get; set; }
    }
}
