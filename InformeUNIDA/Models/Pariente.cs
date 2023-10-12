using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Pariente
    {
        public short Cpariente { get; set; }
        public int Cpersona { get; set; }
        public short? Gparentesco { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public string ApeConyuge { get; set; }
        public string Nombre { get; set; }
        public string Spariente { get; set; }
        public string Dpariente { get; set; }
        public string Tdireccion { get; set; }
        public short? Cpais { get; set; }
        public short? Cdepartamento { get; set; }
        public short? Cprovincia { get; set; }
        public short? Cdistrito { get; set; }
        public string Ntelefono1 { get; set; }
        public string Ntelefono2 { get; set; }
        public DateTime? Fnacimiento { get; set; }
        public short? CpaisNac { get; set; }
        public short? CdepartamentoNac { get; set; }
        public short? CprovinciaNac { get; set; }
        public short? CdistritoNac { get; set; }
        public string Sexo { get; set; }
        public string LibElectoral { get; set; }
        public string LibMilitar { get; set; }
        public short? GdocIdentidad { get; set; }
        public string NdocIdentidad { get; set; }
        public short? Gestadocivil { get; set; }
        public short? Gprofesion { get; set; }
        public string Cipss { get; set; }
        public string Cafp { get; set; }
        public short? Gsangre { get; set; }
        public string Temail { get; set; }
        public string Ttrabajo { get; set; }
        public string Tcargo { get; set; }
        public short? CpaisTrab { get; set; }
        public short? CdepartamentoTrab { get; set; }
        public short? CprovinciaTrab { get; set; }
        public short? CdistritoTrab { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? GtipoTrabajo { get; set; }
        public short? Gvive { get; set; }
        public short? Npuntaje { get; set; }
    }
}
