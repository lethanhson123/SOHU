using SOHU.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOHU.Data.Repositories
{
    public interface IMembershipRepository : IRepository<Membership>
    {
        public bool IsValid(string account, string password);
    }
}
