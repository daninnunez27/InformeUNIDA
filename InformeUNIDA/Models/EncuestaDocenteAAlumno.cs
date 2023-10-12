﻿using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EncuestaDocenteAAlumno
    {
        public int Cencuesta { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Cprofesor { get; set; }
        public int Preguntanumero { get; set; }
        public int? Puntaje { get; set; }
        public string Observacion { get; set; }
        public int? Nciclo { get; set; }
        public int? Ccurso { get; set; }
        public int? CusuarioCoordinador { get; set; }
        public string AntiguedadAsignatura { get; set; }
        public string Responsable { get; set; }
        public DateTime Fecharegistro { get; set; }
        public string Cuestionario { get; set; }
    }
}
