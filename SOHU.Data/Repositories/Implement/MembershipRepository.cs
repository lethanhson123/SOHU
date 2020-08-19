using SOHU.Data.Helpers;
using SOHU.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOHU.Data.Repositories
{
    public class MembershipRepository : Repository<Membership>, IMembershipRepository
    {
        private readonly SOHUContext _context;

        public MembershipRepository(SOHUContext context) : base(context)
        {
            _context = context;
        }

        public Membership GetByAccount(string Account)
        {
            return _context.Membership.FirstOrDefault(item => item.Account == Account);
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
