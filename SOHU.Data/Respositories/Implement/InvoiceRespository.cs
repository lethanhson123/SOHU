using SOHU.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOHU.Data.Respositories
{
    public class InvoiceRespository : Respository<Invoice>, IInvoiceRespository
    {
        private readonly SOHUContext _context;

        public InvoiceRespository(SOHUContext context) : base(context)
        {
            _context = context;
        }


    }
}
