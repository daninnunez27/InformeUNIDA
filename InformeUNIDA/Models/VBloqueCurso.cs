using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class VBloqueCurso
    {
        public short Cinstitucion { get; set; }
        public string Dinstitucion { get; set; }
        public short Cprograma { get; set; }
        public string Dprograma { get; set; }
        public short Cperiodo { get; set; }
        public string Dperiodo { get; set; }
        public short Ccurso { get; set; }
        public string Scurso { get; set; }
        public string Dcurso { get; set; }
        public string PlantillaCurso { get; set; }
        public int Cbloque { get; set; }
        public string Dbloque { get; set; }
        public short? ProfesorCprofesor { get; set; }
        public string ProfesorApePaterno { get; set; }
        public string ProfesorNombre { get; set; }
        public string ProfesorApeMaterno { get; set; }
        public string ProfesorClave { get; set; }
        public string ProfesorTcorreo { get; set; }
        public short? Ccarrera { get; set; }
        public string Scarrera { get; set; }
        public string Dcarrera { get; set; }
        public short? AlumnoMatriculados { get; set; }
        public int? AlumnoActivos { get; set; }
        public int? AlumnoParticipantes { get; set; }
        public short? Ncupo { get; set; }
        public short? CGtipoCredito { get; set; }
        public string SGtipoCredito { get; set; }
        public string DGtipoCredito { get; set; }
        public short? Cesquema { get; set; }
        public string Sesquema { get; set; }
        public string Desquema { get; set; }
        public short? Nciclo { get; set; }
        public string CursoCondicion { get; set; }
        public string CursoSestado { get; set; }
        public DateTime? Finicio { get; set; }
        public DateTime? Ffinal { get; set; }
        public DateTime? TpFexamen { get; set; }
        public DateTime? EfFexamen { get; set; }
        public DateTime? EfeFexamen { get; set; }
        public DateTime? EeeFexamen { get; set; }
    }
}
