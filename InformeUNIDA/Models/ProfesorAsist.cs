using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ProfesorAsist
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public short GtipoAsistencia { get; set; }
        public DateTime FinicioProg { get; set; }
        public short Cprofesor { get; set; }
        public DateTime? HinicioAsist { get; set; }
        public DateTime HfinalProg { get; set; }
        public DateTime? HfinalAsist { get; set; }
        public decimal? Nhoras { get; set; }
        public short? Ccurso { get; set; }
        public short? Caula { get; set; }
        public short? GtipoHora { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int? Cbloque { get; set; }
        public DateTime? Frecupera { get; set; }
        public DateTime? Freemplazo { get; set; }
        public int? CprofesorReemp { get; set; }
        public string Dglosa { get; set; }
        public int IdProfesorAsist { get; set; }
        public DateTime? FhmarcacionE { get; set; }
        public DateTime? FhmarcacionS { get; set; }
        public int Grevisado { get; set; }
        public int? Nprofesor { get; set; }
        public string ClaveHoraContinua { get; set; }
        public string Tcategoria { get; set; }
        public string Tjustificacion { get; set; }
        public int? Ijustificacion { get; set; }
        public int? NminutosAntes { get; set; }
        public int? NminutosDespues { get; set; }
        public string Gadministrativo { get; set; }
        public string Cadministrativo { get; set; }
        public DateTime? Fadministrativo { get; set; }
        public string Tobservacion { get; set; }
    }
}
