using Tobacco_Shop.Models;
using System.Collections.Generic;

namespace Tobacco_Shop.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Category{get;} 
    }
}