using Tobacco_Shop.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Tobacco_Shop.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.Category.OrderBy(p => p.CategoryName);
            return View(categories);
        }
    }
}