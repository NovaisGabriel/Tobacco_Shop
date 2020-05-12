using Tobacco_Shop.Models;
using Tobacco_Shop.Repositories;
using Tobacco_Shop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tobacco_Shop.Controllers
{
    public class TobaccoController : Controller
    {
        private ICategoryRepository _categoryRepository { get; }
        private readonly ITobaccoRepository _tobaccoRepository;

        public TobaccoController(ICategoryRepository categoryRepository, 
            ITobaccoRepository tobaccoRepository)
        {
            _categoryRepository = categoryRepository;
            _tobaccoRepository = tobaccoRepository;
        }

        public IActionResult List(string category)
        {
            string _category = category;
            IEnumerable<Tobacco> tobaccos;
            string categoryNow = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                tobaccos = _tobaccoRepository.Tobaccos.OrderBy(p => p.TobaccoId);
                categoryNow = "All Tobaccos";
            }
            else
            {
                if (string.Equals("National", _category, StringComparison.OrdinalIgnoreCase))
                    tobaccos = _tobaccoRepository.Tobaccos.Where(p => p.Category.CategoryName.Equals("National")).OrderBy(p => p.Name);
                else
                    tobaccos = _tobaccoRepository.Tobaccos.Where(p => p.Category.CategoryName.Equals("Imported")).OrderBy(p => p.Name);

                categoryNow = _category;
            }

            var tobaccoListViewModel = new TobaccoListViewModel
            {
                Tobaccos = tobaccos,
                CategoryNow = categoryNow
            };

            return View(tobaccoListViewModel);
        }
        public ViewResult Details(int tobaccoId)
        {
            var tobacco = _tobaccoRepository.Tobaccos.FirstOrDefault(d => d.TobaccoId == tobaccoId);
            if (tobacco == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(tobacco);
        }
        public ViewResult Search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<Tobacco> tobaccos;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                tobaccos = _tobaccoRepository.Tobaccos.OrderBy(p => p.TobaccoId);
            }
            else
            {
                tobaccos = _tobaccoRepository.Tobaccos.Where(p => p.Name.ToLower().Contains(_searchString.ToLower()));
            }

            return View("~/Views/Tobacco/List.cshtml", new TobaccoListViewModel { Tobaccos = tobaccos, CategoryNow = "All Tobaccos" });
        }

    }
}
