using SOHU.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOHU.Data.Respositories
{
    public interface IMembershipRespository : IRespository<Membership>
    {
        public bool IsValid(string account, string password);
    }
}
