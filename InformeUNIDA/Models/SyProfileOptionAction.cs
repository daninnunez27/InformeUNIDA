using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SyProfileOptionAction
    {
        public int ProfileId { get; set; }
        public int OptionId { get; set; }
        public int ActionId { get; set; }
        public string RegisterUser { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string LastUser { get; set; }
        public DateTime? LastDate { get; set; }
    }
}
