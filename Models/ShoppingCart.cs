using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tobacco_Shop.Models
{
    [Table("ShoppingCarts")]
    public class ShoppingCart
    {
      public int ShoppingCartId {get; set;}
      public Tobacco Tobacco {get; set;}  
      public int Quantity {get; set;}
      [StringLength(500)]
      public string SCartId {get; set;} 
    }
}