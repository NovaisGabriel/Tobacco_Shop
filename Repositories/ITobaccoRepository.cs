using Tobacco_Shop.Models;
using System.Collections.Generic;

namespace Tobacco_Shop.Repositories
{
    public interface ITobaccoRepository
    {
         IEnumerable<Tobacco> Tobaccos{get;}
         IEnumerable<Tobacco> BestTobacco {get;}
         Tobacco GetTobaccoById(int tobaccoId);
    }
}