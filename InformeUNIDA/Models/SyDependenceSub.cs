using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SyDependenceSub
    {
        public string Dependence { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public int? RegisterUser { get; set; }
        public DateTime? RegisterDate { get; set; }
        public int? LastUser { get; set; }
        public DateTime? LastDate { get; set; }
    }
}
