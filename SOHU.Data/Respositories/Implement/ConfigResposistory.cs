using SOHU.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOHU.Data.Respositories
{
    public class ConfigResposistory : Respository<Config>, IConfigResposistory
    {
        private readonly SOHUContext _context;

        public ConfigResposistory(SOHUContext context) : base(context)
        {
            _context = context;
        }


    }
}
