using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SyLog
    {
        public int Id { get; set; }
        public int? Userid { get; set; }
        public string Note { get; set; }
        public string Ipaddress { get; set; }
        public string Machine { get; set; }
        public string Logonnt { get; set; }
        public bool? Deleted { get; set; }
        public int? DocumentId { get; set; }
        public string DocumentType { get; set; }
        public DateTime? Createdate { get; set; }
        public string StringId { get; set; }
    }
}
