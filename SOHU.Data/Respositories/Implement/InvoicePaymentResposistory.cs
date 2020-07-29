using SOHU.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOHU.Data.Respositories
{
    public class InvoicePaymentResposistory : Respository<InvoicePayment>, IInvoicePaymentResposistory
    {
        private readonly SOHUContext _context;

        public InvoicePaymentResposistory(SOHUContext context) : base(context)
        {
            _context = context;
        }
    }
}
