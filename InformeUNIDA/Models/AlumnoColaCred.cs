using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoColaCred
    {
        public short Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Calumno { get; set; }
        public int Natencion { get; set; }
        public string Sticket { get; set; }
        public DateTime Fticket { get; set; }
        public short CtipoCliente { get; set; }
        public short Nprioridad { get; set; }
        public DateTime? FinicioAtencion { get; set; }
        public DateTime? FfinalAtencion { get; set; }
        public short? Cmodulo { get; set; }
        public string Ccreacion { get; set; }
        public string Cmodificacion { get; set; }
        public string Gestado { get; set; }
        public DateTime Festado { get; set; }
        public int? Ninterno { get; set; }
        public string Corige { get; set; }
    }
}
