using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tobacco_Shop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        [StringLength(300)] 
        public string Description { get; set; }
        [StringLength(500)] 
        public List<Tobacco> Tobbacos { get; set; }
    }
}