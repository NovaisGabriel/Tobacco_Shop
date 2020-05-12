using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tobacco_Shop.Models;
using Tobacco_Shop.Repositories;
using Tobacco_Shop.ViewModels;

namespace Tobacco_Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITobaccoRepository _tobaccoRepository;
        public HomeController(ITobaccoRepository tobaccoRepository)
        {
            _tobaccoRepository = tobaccoRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                BestTobacco = _tobaccoRepository.BestTobacco
            };
            return View(homeViewModel);
        }

        public ViewResult AccessDenied()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
