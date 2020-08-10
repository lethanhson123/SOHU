using SOHU.Data.Helpers;
using SOHU.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOHU.Data.Respositories
{
    public class ProductRespository : Respository<Product>, IProductRespository
    {
        private readonly SOHUContext _context;

        public ProductRespository(SOHUContext context) : base(context)
        {
            _context = context;
        }
    }
}
