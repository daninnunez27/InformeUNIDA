using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SyOption
    {
        public SyOption()
        {
            SyOptionActions = new HashSet<SyOptionAction>();
        }

        public int OptionId { get; set; }
        public string Description { get; set; }
        public int? ParentOption { get; set; }
        public int? OptionOrder { get; set; }
        public string Url { get; set; }
        public string Status { get; set; }
        public int? RegisterUser { get; set; }
        public DateTime? RegisterDate { get; set; }
        public int? LastUser { get; set; }
        public DateTime? LastDate { get; set; }
        public string VersionType { get; set; }
        public string FlagTemplate { get; set; }
        public int? IndexImage { get; set; }
        public int? SelecImage { get; set; }

        public virtual ICollection<SyOptionAction> SyOptionActions { get; set; }
    }
}
