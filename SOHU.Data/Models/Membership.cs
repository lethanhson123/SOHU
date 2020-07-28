using System;
using System.Collections.Generic;

namespace SOHU.Data.Models
{
    public partial class Membership
    {
        public int Id { get; set; }
        public int? UserCreated { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? UserUpdated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int? ParentId { get; set; }
        public string Note { get; set; }
        public bool? Active { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? Birthday { get; set; }
        public string Address { get; set; }
        public string CitizenIdentification { get; set; }
        public string Passport { get; set; }
        public decimal? Points { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Guicode { get; set; }
    }
}
