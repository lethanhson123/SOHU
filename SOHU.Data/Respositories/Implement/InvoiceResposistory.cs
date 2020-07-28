using SOHU.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOHU.Data.Respositories
{
    public class InvoiceResposistory : Respository<Invoice>, IInvoiceResposistory
    {
        private readonly SOHUContext _context;

        public InvoiceResposistory(SOHUContext context) : base(context)
        {
            _context = context;
        }


    }
}
