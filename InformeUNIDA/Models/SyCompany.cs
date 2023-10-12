using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SyCompany
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public int? MaxUsers { get; set; }
        public int? RegisterUser { get; set; }
        public DateTime? RegisterDate { get; set; }
        public int? LastUser { get; set; }
        public DateTime? LastDate { get; set; }
        public string DatabaseName { get; set; }
        public string LicenceType { get; set; }
        public string VersionType { get; set; }
        public string Status { get; set; }
        public int? CountryId { get; set; }
        public string Address { get; set; }
        public int? CurrencyId { get; set; }
        public string Telephone { get; set; }
        public bool? FlagAdmin { get; set; }
        public string UserDb { get; set; }
        public string PasswordDb { get; set; }
        public string FlagBenefitCenter { get; set; }
    }
}
