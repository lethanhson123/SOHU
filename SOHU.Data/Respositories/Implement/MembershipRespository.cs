using SOHU.Data.Helpers;
using SOHU.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOHU.Data.Respositories
{
    public class MembershipRespository : Respository<Membership>, IMembershipRespository
    {
        private readonly SOHUContext _context;

        public MembershipRespository(SOHUContext context) : base(context)
        {
            _context = context;
        }

        public bool IsValid(string account, string password)
        {
            var membership = _context.Membership.FirstOrDefault(user => user.Account.Equals(account));
            if (membership != null)
            {
                if (SecurityHelper.Decrypt(membership.Guicode, membership.Password).Equals(password))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
