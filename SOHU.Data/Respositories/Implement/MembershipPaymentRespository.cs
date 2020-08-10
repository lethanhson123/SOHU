using SOHU.Data.Helpers;
using SOHU.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOHU.Data.Respositories
{
    public class MembershipPaymentRespository : Respository<MembershipPayment>, IMembershipPaymentRespository
    {
        private readonly SOHUContext _context;

        public MembershipPaymentRespository(SOHUContext context) : base(context)
        {
            _context = context;
        }

        
    }
}
