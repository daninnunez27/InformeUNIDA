using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ConfigurarPlanillaPosgrado
    {
        public ConfigurarPlanillaPosgrado()
        {
            ProfPlanillaSalarioPosts = new HashSet<ProfPlanillaSalarioPost>();
        }

        public short Cplanilla { get; set; }
        public string Dplanilla { get; set; }
        public DateTime? Finicio { get; set; }
        public DateTime? Ffinal { get; set; }
        public short? EstadoRegistro { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }

        public virtual ICollection<ProfPlanillaSalarioPost> ProfPlanillaSalarioPosts { get; set; }
    }
}
