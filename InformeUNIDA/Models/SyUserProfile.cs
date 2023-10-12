using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SyUserProfile
    {
        public int UserId { get; set; }
        public int ProfileId { get; set; }
        public int? RegisterUser { get; set; }
        public DateTime? RegisterDate { get; set; }
        public int? LastUser { get; set; }
        public DateTime? LastDate { get; set; }

        public virtual SyProfile Profile { get; set; }
        public virtual SyUser User { get; set; }
    }
}
