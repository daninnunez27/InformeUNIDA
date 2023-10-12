using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ProfesorAsistManualVirtual
    {
        public int Registro { get; set; }
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short? Cperiodo { get; set; }
        public short? Ccarrera { get; set; }
        public short? Ccurso { get; set; }
        public short? Cbloque { get; set; }
        public short? Cprofesor { get; set; }
        public short? Mes { get; set; }
        public short? Semestre { get; set; }
        public short? Semana { get; set; }
        public short? Credito { get; set; }
        public short? Gestado { get; set; }
        public short? EstadoPago { get; set; }
        public short? ForoNovedad { get; set; }
        public short? ForoAyuda { get; set; }
        public short? Material { get; set; }
        public short? Actividad { get; set; }
        public short? ChatLinea { get; set; }
        public short? Observacion { get; set; }
        public string Tobservacion { get; set; }
        public short? GtipoAsistencias { get; set; }
        public short? NroSemanas { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
