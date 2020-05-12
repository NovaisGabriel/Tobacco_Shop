using System.Collections.Generic;
using Tobacco_Shop.Models;
using Tobacco_Shop.Context;
using Tobacco_Shop.Repositories;

namespace Tobacco_Shop.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {   
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext context)
        {
           _context = context; 
        }
        public IEnumerable<Category> Category => _context.Category;
    }
}