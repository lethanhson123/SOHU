using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SOHU.Data.Respositories;
using SOHU.MVC.Models;

namespace SOHU.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRespository _productRespository;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IProductRespository productRespository)
        {
            _logger = logger;
            _productRespository = productRespository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult ProductDetail (int ProductID)
        {
            var model = _productRespository.GetByID(ProductID);
            return View(model);
        }

        public IActionResult ProductList (int CategoryID)
        {
            return View();
        }
    }
}
