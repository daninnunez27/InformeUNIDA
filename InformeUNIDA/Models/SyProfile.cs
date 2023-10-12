using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SyProfile
    {
        public SyProfile()
        {
            SyUserProfiles = new HashSet<SyUserProfile>();
        }

        public int ProfileId { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int? RegisterUser { get; set; }
        public DateTime? RegisterDate { get; set; }
        public int? LastUser { get; set; }
        public DateTime? LastDate { get; set; }
        public bool? FlagAdmin { get; set; }
        public string CompanyId { get; set; }
        public int? ParentProfile { get; set; }
        public bool? FlagInternalUse { get; set; }
        public bool? FlagBasePackage { get; set; }

        public virtual ICollection<SyUserProfile> SyUserProfiles { get; set; }
    }
}
