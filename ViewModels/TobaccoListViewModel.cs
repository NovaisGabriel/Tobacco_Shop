using Tobacco_Shop.Models;
using System.Collections.Generic;

namespace Tobacco_Shop.ViewModels
{
    public class TobaccoListViewModel
    {
        public IEnumerable<Tobacco> Tobaccos {get; set;}
        public string CategoryNow {get; set;}
    }
}