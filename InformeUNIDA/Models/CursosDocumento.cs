using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CursosDocumento
    {
        public int Cdocumento { get; set; }
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short? Cperiodo { get; set; }
        public short? Ccarrera { get; set; }
        public short? Ccurso { get; set; }
        public short? Cbloque { get; set; }
        public short? Cprofesor { get; set; }
        public short? Nintentos { get; set; }
        public string Dtitulo { get; set; }
        public string Tarchivo { get; set; }
        public string Tdescripcion { get; set; }
        public decimal Ntamano { get; set; }
        public string Tipo { get; set; }
        public byte[] BinArchivo { get; set; }
        public short? Gestado { get; set; }
        public short? Cprofesormod { get; set; }
        public DateTime? Fcreacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
