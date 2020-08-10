using SOHU.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOHU.Data.Respositories
{
    public class InvoiceDetailRespository : Respository<InvoiceDetail>, IInvoiceDetailRespository
    {
        private readonly SOHUContext _context;

        public InvoiceDetailRespository(SOHUContext context) : base(context)
        {
            _context = context;
        }


    }
}
