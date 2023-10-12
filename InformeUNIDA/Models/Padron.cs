using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Padron
    {
        public int Id { get; set; }
        public string Dis { get; set; }
        public string Distrito { get; set; }
        public string Sec { get; set; }
        public string Seccional { get; set; }
        public string Loc { get; set; }
        public string LocalVotacion { get; set; }
        public string Cedula { get; set; }
        public string CedCrud { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string FecNaci { get; set; }
        public string Direccion { get; set; }
        public string Sexo { get; set; }
        public string Partido { get; set; }
        public string VotoNov { get; set; }
        public string VotoDic { get; set; }
        public string VotoAbr { get; set; }
        public string VotoJul { get; set; }
        public string VotoOct { get; set; }
    }
}
