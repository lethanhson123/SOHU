using System;
using System.Collections.Generic;

namespace SOHU.Data.Models
{
    public partial class MembershipPayment
    {
        public int Id { get; set; }
        public int? UserCreated { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? UserUpdated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int? ParentId { get; set; }
        public string Note { get; set; }
        public bool? Active { get; set; }
        public int? MembershipId { get; set; }
        public int? BankId { get; set; }
        public string AccountNumber { get; set; }
    }
}
