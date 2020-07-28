using System;
using System.Collections.Generic;

namespace SOHU.Data.Models
{
    public partial class ProductConfig
    {
        public int Id { get; set; }
        public int? UserCreated { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? UserUpdated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int? ParentId { get; set; }
        public string Note { get; set; }
        public bool? Active { get; set; }
        public int? ProductId { get; set; }
        public int? ConfigId { get; set; }
        public decimal? Value { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
    }
}
