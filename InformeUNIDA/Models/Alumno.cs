using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Alumno
    {
        public Alumno()
        {
            AlumnoPeriodos = new HashSet<AlumnoPeriodo>();
        }

        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public int Calumno { get; set; }
        public int Cpersona { get; set; }
        public string Cingreso { get; set; }
        public short? Gformaingreso { get; set; }
        public short? Gtipoingreso { get; set; }
        public decimal? Nacumulado { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime Fmodificacion { get; set; }
        public short Cperiodo { get; set; }
        public short? Cadmision { get; set; }
        public short? NcreditoAcum { get; set; }
        public string Tclave { get; set; }
        public string TclaveAdicional { get; set; }
        public string Tcorreo { get; set; }
        public string Borrar { get; set; }
        public short? Gnaturaleza { get; set; }
        public short? CperiodoCalculado { get; set; }
        public short? GaptoPracticas { get; set; }
        public string TclaveMat { get; set; }
        public short? CultPerMat { get; set; }
        public string CestadoCaja { get; set; }
        public short? GestadoFinal { get; set; }
        public short? Nreingresos { get; set; }
        public short? ClocalPref { get; set; }
        public string Tclave6 { get; set; }
        public short? GturnoX { get; set; }
        public string TesisNombre1 { get; set; }
        public string TesisNombre2 { get; set; }
        public DateTime? TesisFecha { get; set; }
        public short? TesisNota { get; set; }
        public int? OrigenVenta { get; set; }
        public string OrigenVentaDescripcion { get; set; }
        public string Tclavepadre { get; set; }

        public virtual Persona CpersonaNavigation { get; set; }
        public virtual ICollection<AlumnoPeriodo> AlumnoPeriodos { get; set; }
    }
}
