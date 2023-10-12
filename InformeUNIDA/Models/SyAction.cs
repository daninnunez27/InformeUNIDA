using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SyAction
    {
        public SyAction()
        {
            SyOptionActions = new HashSet<SyOptionAction>();
        }

        public int ActionId { get; set; }
        public string Description { get; set; }
        public int? RegisterUser { get; set; }
        public DateTime? RegisterDate { get; set; }
        public int? LastUser { get; set; }
        public DateTime? LastDate { get; set; }
        public string Status { get; set; }
        public bool? FlagDefault { get; set; }

        public virtual ICollection<SyOptionAction> SyOptionActions { get; set; }
    }
}
