using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class FuncionarioWeb
    {
        public short Cusuario { get; set; }
        public short Cfuncionario { get; set; }
        public int? GAcad { get; set; }
        public string Dfuncionario { get; set; }
        public string Potestad { get; set; }
        public short? Cinstitucion { get; set; }
        public short? Estado { get; set; }
        public int? GobernanzaEclass { get; set; }
        public int? OrdenGobernanza { get; set; }

        public virtual Institucion CinstitucionNavigation { get; set; }
        public virtual Usuario CusuarioNavigation { get; set; }
    }
}
