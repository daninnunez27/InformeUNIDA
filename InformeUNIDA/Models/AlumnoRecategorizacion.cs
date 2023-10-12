using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoRecategorizacion
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Cadmision { get; set; }
        public int Cpostulante { get; set; }
        public int Cpersona { get; set; }
        public int? Calumno { get; set; }
        public string Cingreso { get; set; }
        public decimal Ipadre { get; set; }
        public decimal Imadre { get; set; }
        public decimal Ialumno { get; set; }
        public decimal Iotros { get; set; }
        public decimal IalquilerPension { get; set; }
        public decimal Ihipoteca { get; set; }
        public decimal Ipredial { get; set; }
        public decimal Iluz { get; set; }
        public decimal Iagua { get; set; }
        public decimal Itelefono { get; set; }
        public decimal Ieducacion { get; set; }
        public decimal Isalud { get; set; }
        public short NcargaFamiliar { get; set; }
        public string CcatclPropuesto { get; set; }
        public string CcatclAsignado { get; set; }
        public string Gestado { get; set; }
        public string Dglosa { get; set; }
        public string Gconvenio { get; set; }
        public string Ccnben { get; set; }
        public decimal Pdscto { get; set; }
    }
}
