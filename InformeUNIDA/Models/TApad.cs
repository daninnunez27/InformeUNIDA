using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TApad
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Calumno { get; set; }
        public string Ccarrera { get; set; }
        public int Gcondicion { get; set; }
        public int Gestado { get; set; }
        public short? Ccurricula { get; set; }
        public string Cingreso { get; set; }
        public int Cpersona { get; set; }
        public int CperiodoInicial { get; set; }
        public int Gautoriza { get; set; }
        public string Cespecialidad { get; set; }
    }
}
