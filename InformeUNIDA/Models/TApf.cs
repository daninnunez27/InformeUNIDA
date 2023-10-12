using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TApf
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Calumno { get; set; }
        public short Ccarrera { get; set; }
        public int Cmodalidad { get; set; }
        public short? Gcategoria { get; set; }
        public short Gcondicion { get; set; }
        public decimal? Nponderado { get; set; }
        public DateTime? Fmatricula { get; set; }
        public decimal? Nbeca { get; set; }
        public short? Gpago { get; set; }
        public short Gestado { get; set; }
        public short? Ncredito { get; set; }
        public short? Gsituacion { get; set; }
        public short? Nprioridad { get; set; }
        public decimal? Nacumulado { get; set; }
        public short? NcreditoAcum { get; set; }
        public short? Cbloqueo { get; set; }
        public short? Gseccion { get; set; }
        public short? Norden { get; set; }
        public short? Ccurricula { get; set; }
        public string Cingreso { get; set; }
        public int Cpersona { get; set; }
        public short? Nparacad { get; set; }
        public short? NparacadAcum { get; set; }
        public short CperiodoInicial { get; set; }
        public short Gautoriza { get; set; }
        public short? Gconvalidados { get; set; }
        public string Gobservado { get; set; }
        public short? Greingreso { get; set; }
        public string Gvendedor { get; set; }
        public short? NvecesMatricula { get; set; }
        public short? NcargaAcad { get; set; }
        public short Cespecialidad { get; set; }
        public short? Cagrupamiento { get; set; }
        public short? QcursosMat { get; set; }
        public short? QcrediMat { get; set; }
        public short? QcursosAprob { get; set; }
        public short? QcursosPend { get; set; }
        public short? CperiodoVieneDe { get; set; }
        public DateTime? FreglamentoMatric { get; set; }
        public string TreglamentoMatricIp { get; set; }
        public int? Cobligacion { get; set; }
        public int? Ccronograma { get; set; }
        public DateTime? Fgestado { get; set; }
        public DateTime? Fgcondicion { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string TsystemUser { get; set; }
    }
}
