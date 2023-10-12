using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ProfPlanillaSalarioVirt
    {
        public short Registro { get; set; }
        public short? RegistroAsistencia { get; set; }
        public short? Mes { get; set; }
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short? Cperiodo { get; set; }
        public short? Ccarrera { get; set; }
        public short? Ccarrera1 { get; set; }
        public short? Ccarrera2 { get; set; }
        public short? Ccarrera3 { get; set; }
        public short? Ccarrera4 { get; set; }
        public short? Ccarrera5 { get; set; }
        public short? Ccarrera6 { get; set; }
        public short? Ccurso { get; set; }
        public short? Cprofesor { get; set; }
        public string GtipoPlanilla { get; set; }
        public decimal? TipoPlanillaDescuento { get; set; }
        public decimal? Descuento { get; set; }
        public short? Semestre { get; set; }
        public short? NroCreditos { get; set; }
        public short? NroSemanas { get; set; }
        public short? CargaHoraria { get; set; }
        public short? HorasEf { get; set; }
        public string ComentarioEf { get; set; }
        public short? HorasEfe { get; set; }
        public string ComentarioEfe { get; set; }
        public short? HorasEee { get; set; }
        public string ComentarioEee { get; set; }
        public short? GtipoAsistencias { get; set; }
        public decimal? NmontoHora { get; set; }
        public decimal? Nmonto { get; set; }
        public decimal? NmontoNetoPagar { get; set; }
        public short? Gestado { get; set; }
        public short? EstadoRegistro { get; set; }
        public string Tobservacion { get; set; }
        public string Nrocheque { get; set; }
        public string Comentario1 { get; set; }
        public string Comentario2 { get; set; }
        public string Nivel { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
