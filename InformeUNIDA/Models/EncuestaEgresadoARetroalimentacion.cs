using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EncuestaEgresadoARetroalimentacion
    {
        public int Cencuesta { get; set; }
        public int Cinstitucion { get; set; }
        public int Anio { get; set; }
        public int Calumno { get; set; }
        public string Preguntanumero { get; set; }
        public bool? Resp1 { get; set; }
        public bool? Resp2 { get; set; }
        public bool? Resp3 { get; set; }
        public bool? Resp4 { get; set; }
        public bool? Resp5 { get; set; }
        public bool? Resp6 { get; set; }
        public bool? Resp7 { get; set; }
        public bool? Resp8 { get; set; }
        public bool? Resp9 { get; set; }
        public bool? Resp10 { get; set; }
        public int? Ccarrera { get; set; }
        public string Facultad { get; set; }
        public string Domicilio { get; set; }
        public string Cedula { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string Otros { get; set; }
        public string EstadoCivil { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Nacionalidad { get; set; }
        public string OtroEspecificar { get; set; }
        public int? AnioConclucionCarrera { get; set; }
        public string IngresoMes { get; set; }
        public int? IngresoAnio { get; set; }
        public string LugarTrabajo { get; set; }
        public string Contrato { get; set; }
        public string Demanda { get; set; }
        public string Comentario { get; set; }
        public DateTime? Fecharegistro { get; set; }
        public string Cuestionario { get; set; }
        public int? Cprograma { get; set; }
    }
}
