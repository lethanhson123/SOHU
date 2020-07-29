using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOHU.Data.Helpers;
using SOHU.Data.Respositories;
using SOHU.MVC.Models;

namespace SOHU.MVC.Controllers
{
    public class MembershipController : Controller
    {
        private readonly IMembershipResposistory _resposistory;

        public MembershipController(IMembershipResposistory resposistory)
        {
            _resposistory = resposistory;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult ValidUser(UserLoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                if(_resposistory.IsValid(model.Account, model.Password))
                {
                    var cookie = new CookieOptions();
                    cookie.Expires = AppGlobal.InitDateTime.AddDays(30);
                    Response.Cookies.Append("Account", model.Account, cookie);
                    Response.Cookies.Append("IsRemember", model.IsRemember.ToString(), cookie);
                    Response.Cookies.Append("Password", MD5Helper.EncryptDataMD5(model.Password, AppGlobal.MD5Key), cookie);
                    return Json(AppGlobal.Success + " - " + AppGlobal.RedirectDefault);
                }
                return Json(AppGlobal.Fail + " - " + AppGlobal.LoginFail);
            }   
            else
            {
                return Json(AppGlobal.Fail + " - " + AppGlobal.LoginFail);
            }    
        }
    }
}