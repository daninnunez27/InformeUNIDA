using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SyOptionAction
    {
        public int OptionId { get; set; }
        public int ActionId { get; set; }
        public int? RegisterUser { get; set; }
        public DateTime? RegisterDate { get; set; }
        public int? LastUser { get; set; }
        public DateTime? LastDate { get; set; }

        public virtual SyAction Action { get; set; }
        public virtual SyOption Option { get; set; }
    }
}
