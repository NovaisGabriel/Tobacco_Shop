using System.ComponentModel.DataAnnotations;

namespace Tobacco_Shop.Models
{
    public class Tobacco
    {
       public int TobaccoId { get; set; }
       [Required]
       [StringLength(100)] 
       public string Name { get; set; }
       [StringLength(300)] 
       public string ShortDescription { get; set; } 
       [StringLength(1000)] 
       public string LongDescription { get; set; } 
       [StringLength(2000)] 
       public decimal Price { get; set; } 
       public string ImageURL { get; set; }
       [StringLength(2000)]  
       public string ImageThumbnailUrl { get; set; } 
       public bool IsTobaccoBest { get; set; }
       public bool Available { get; set; }
       public int CategoryId { get; set; }
       public virtual Category Category { get; set; }
    }
}