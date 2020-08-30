using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOHU.API.Helpers;
using SOHU.API.RequestModel;
using SOHU.API.ResponseModel;
using SOHU.Data.Helpers;
using SOHU.Data.Repositories;

namespace SOHU.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipController : BaseController
    {
        private readonly IMembershipRepository _membershipRepository;

        public MembershipController(IMembershipRepository membershipRepository)
        {
            _membershipRepository = membershipRepository;
        }

        [HttpPost]
        public ActionResult<string> CheckUser(MembershipLoginRequestModel model)
        {
            string result = AppGlobal.InitString;
            if (_membershipRepository.IsValid(model.Account, model.Password))
            {
                var member = _membershipRepository.GetByAccount(model.Account);
                Token token = new Token
                {
                    CurrentDatetime = DateTime.Now,
                    Key = TokenHelper.GenerateString(member),
                    ExpireMinute = AppGlobal.TokenExpireMinute,
                };
            }
            return Content(result);
        }
    }
}
