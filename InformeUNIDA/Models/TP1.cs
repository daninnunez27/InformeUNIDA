using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TP1
    {
        public int Calumno { get; set; }
        public string Nombre { get; set; }
        public string Tcorreo { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public string Sexo { get; set; }
        public short? Gestadocivil { get; set; }
        public DateTime? Fnacimiento { get; set; }
        public short? Cpais { get; set; }
        public short? Cprovincia { get; set; }
        public string Cingreso { get; set; }
        public string Ntelefono1 { get; set; }
        public string Ntelefono2 { get; set; }
        public string NdocIdentidad { get; set; }
        public string SglUfIdent { get; set; }
        public string SglOrgaoEmissor { get; set; }
        public string DtEmissaoIdent { get; set; }
        public string NumTituloEleitor { get; set; }
        public string SglUfTitulo { get; set; }
        public string NumZonaTitulo { get; set; }
        public string NumSecaoTitulo { get; set; }
        public string NumCertifMilitar { get; set; }
        public string SglUfCertifMilitar { get; set; }
        public string SglEmissorCertifMilitar { get; set; }
        public string IndInadimplente { get; set; }
    }
}
