using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TicketUnidum
    {
        public int TicketId { get; set; }
        public DateTime? Femision { get; set; }
        public string Modulo { get; set; }
        public string CiMat { get; set; }
        public string Nombre { get; set; }
        public string Institucion { get; set; }
        public string Programa { get; set; }
        public string Carrera { get; set; }
        public string Tcorreo { get; set; }
        public string Usuario { get; set; }
        public string Fmodificacion { get; set; }
        public string EstadoTicket { get; set; }
    }
}
