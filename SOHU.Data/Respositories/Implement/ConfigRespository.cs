using SOHU.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOHU.Data.Respositories
{
    public class ConfigRespository : Respository<Config>, IConfigRespository
    {
        private readonly SOHUContext _context;

        public ConfigRespository(SOHUContext context) : base(context)
        {
            _context = context;
        }


    }
}
