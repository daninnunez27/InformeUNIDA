using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SumRetirosAnual
    {
        public short Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Nanio { get; set; }
        public int Ccarrera { get; set; }
        public int Cespecialidad { get; set; }
        public int QretiradosEne { get; set; }
        public int QretiradosFeb { get; set; }
        public int QretiradosMar { get; set; }
        public int QretiradosAbr { get; set; }
        public int QretiradosMay { get; set; }
        public int QretiradosJun { get; set; }
        public int QretiradosJul { get; set; }
        public int QretiradosAgo { get; set; }
        public int QretiradosSet { get; set; }
        public int QretiradosOct { get; set; }
        public int QretiradosNov { get; set; }
        public int QretiradosDic { get; set; }
    }
}
