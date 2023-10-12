using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SyUser
    {
        public SyUser()
        {
            SyUserProfiles = new HashSet<SyUserProfile>();
        }

        public int UserId { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public int? RegisterUser { get; set; }
        public DateTime? RegisterDate { get; set; }
        public int? LastUser { get; set; }
        public DateTime? LastDate { get; set; }
        public string UserName { get; set; }
        public int? CompanyId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<SyUserProfile> SyUserProfiles { get; set; }
    }
}
