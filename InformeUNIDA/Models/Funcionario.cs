using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Funcionario
    {
        public string Nrocedula { get; set; }
        public string Departamento { get; set; }
        public int Codigo { get; set; }
        public string Empleado { get; set; }
        public string Cargo { get; set; }
        public string Asignadoa { get; set; }
        public DateTime? Fechaingreso { get; set; }
        public decimal? Sueldo { get; set; }
        public string Direccion { get; set; }
        public string Ips { get; set; }
        public string Otroseguro { get; set; }
        public string Centrocosto { get; set; }
    }
}
