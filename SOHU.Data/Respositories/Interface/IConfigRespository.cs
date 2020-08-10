using SOHU.Data.DataTransferObject;
using SOHU.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOHU.Data.Respositories
{
    public interface IConfigRespository : IRespository<Config>
    {
        public List<Config> GetByCodeToList(string Code);
    }
}
