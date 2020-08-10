using SOHU.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOHU.Data.Respositories
{
    public class InvoicePaymentRespository : Respository<InvoicePayment>, IInvoicePaymentRespository
    {
        private readonly SOHUContext _context;

        public InvoicePaymentRespository(SOHUContext context) : base(context)
        {
            _context = context;
        }
    }
}
