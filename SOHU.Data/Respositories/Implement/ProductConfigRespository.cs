using SOHU.Data.Helpers;
using SOHU.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOHU.Data.Respositories
{
    public class ProductConfigRespository : Respository<ProductConfig>, IProductConfigRespository
    {
        private readonly SOHUContext _context;

        public ProductConfigRespository(SOHUContext context) : base(context)
        {
            _context = context;
        }
    }
}
