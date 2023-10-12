using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CategoriaProfesor
    {
        public string Ctrabajador { get; set; }
        public int Cpersona { get; set; }
        public int CtipoProf { get; set; }
        public int CgrupoCatProf { get; set; }
        public string TcategoriaNew { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int Cperiodo { get; set; }
    }
}
