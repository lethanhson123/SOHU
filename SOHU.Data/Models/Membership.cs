using System;
using System.Collections.Generic;

namespace SOHU.Data.Models
{
    public partial class Membership : BaseModel
    {
       
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
