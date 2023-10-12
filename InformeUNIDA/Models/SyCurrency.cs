using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SyCurrency
    {
        public int CurrencyId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int? RegisterUser { get; set; }
        public DateTime? RegisterDate { get; set; }
        public int? LastUser { get; set; }
        public DateTime? LastDate { get; set; }
        public string Symbol { get; set; }
    }
}
