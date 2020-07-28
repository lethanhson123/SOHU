using System;
using System.Collections.Generic;

namespace SOHU.Data.Models
{
    public partial class Config
    {
        public int Id { get; set; }
        public int? UserCreated { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? UserUpdated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int? ParentId { get; set; }
        public string Note { get; set; }
        public bool? Active { get; set; }
        public string Config1 { get; set; }
        public string Code { get; set; }
        public string CodeName { get; set; }
        public string CodenameSub { get; set; }
        public int? SortOrder { get; set; }
    }
}
