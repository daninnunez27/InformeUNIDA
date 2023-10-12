using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ProfesorContenido
    {
        public int Id { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Ccurso { get; set; }
        public int Cbloque { get; set; }
        public int Cprofesor { get; set; }
        public DateTime? Fregistroclase { get; set; }
        public int? Gestado { get; set; }
        public string Dcontenido { get; set; }
        public int Cprofesormod { get; set; }
        public DateTime? Fcreacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string DunidadTematica { get; set; }
        public string DcapacidadesTrabajadas { get; set; }
        public string ContenidoConceptuales { get; set; }
        public string ContenidoProcedimentales { get; set; }
        public string ContenidoActitudinales { get; set; }
        public int? CestrategiaCheckbox1 { get; set; }
        public int? CestrategiaCheckbox2 { get; set; }
        public int? CestrategiaCheckbox3 { get; set; }
        public int? CactividadesCheckbox1 { get; set; }
        public int? CactividadesCheckbox2 { get; set; }
        public int? CactividadesCheckbox3 { get; set; }
        public int? CactividadesCheckbox4 { get; set; }
        public int? CactividadesCheckbox5 { get; set; }
        public string Dmecanismo { get; set; }
        public int? TipoClase1 { get; set; }
        public int? TipoClase2 { get; set; }
        public int? TipoClase3 { get; set; }
        public int? TipoClase4 { get; set; }
    }
}
