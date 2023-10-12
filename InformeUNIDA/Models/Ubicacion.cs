using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Ubicacion
    {
        public short Cpais { get; set; }
        public short Cdepartamento { get; set; }
        public short Cprovincia { get; set; }
        public short Cdistrito { get; set; }
        public short Cnivel { get; set; }
        public string Dubicacion { get; set; }
        public string Subicacion { get; set; }
        public string DubicacionOrigen { get; set; }
        public string SubicacionOrigen { get; set; }
        public string Cpostal { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Gcategoria { get; set; }
        public string Dgentilicio { get; set; }
    }
}
