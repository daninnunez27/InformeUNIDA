using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EncuestaEmpleador
    {
        public int CencuestaEmp { get; set; }
        public DateTime Fencuesta { get; set; }
        public int Ccarrera { get; set; }
        public int Cprograma { get; set; }
        public string Dempleador { get; set; }
        public string DsectorEcon { get; set; }
        public string DtamanhoEmp { get; set; }
        public int? DtipoEmp { get; set; }
        public int? EgresadosEmp { get; set; }
        public int? CantEgresados { get; set; }
        public string MotivoSalida { get; set; }
        public string Degresado { get; set; }
        public int GdocIdentidad { get; set; }
        public string NdocIdentidad { get; set; }
        public string Tdireccion { get; set; }
        public int? Ndireccion { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
        public string Ntelefono { get; set; }
        public string Tcorreo { get; set; }
        public DateTime Fnacimiento { get; set; }
        public string DepNacimiento { get; set; }
        public int? Sexo { get; set; }
        public int? GestadoCivil { get; set; }
        public int? Cnacionalidad { get; set; }
        public string Dnacionalidad { get; set; }
        public int? Desempenio { get; set; }
        public int? ActitudDes { get; set; }
        public int? Valores { get; set; }
        public int? Satisfaccion { get; set; }
        public int? FormacionTeorica { get; set; }
        public int? EntrenamientoPractico { get; set; }
        public int? Predisposicion { get; set; }
        public int? Etica { get; set; }
        public int? Responsabilidad { get; set; }
        public int GradoPertinencia { get; set; }
        public int? AspectosFormacion { get; set; }
        public string NecesidadesConocimientos { get; set; }
        public int? ProporcionaCapac { get; set; }
        public string DproporcionaCapac { get; set; }
        public string Tcapacitacion { get; set; }
        public int? ApoyoCapac { get; set; }
        public string DapoyoCapac { get; set; }
        public string HabilidadesRequeridas { get; set; }
    }
}
