using SOHU.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOHU.Data.Respositories
{
    public class InvoiceDetailResposistory : Respository<InvoiceDetail>, IInvoiceDetailResposistory
    {
        private readonly SOHUContext _context;

        public InvoiceDetailResposistory(SOHUContext context) : base(context)
        {
            _context = context;
        }


    }
}
