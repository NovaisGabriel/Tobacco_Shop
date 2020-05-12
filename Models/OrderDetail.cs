using System.ComponentModel.DataAnnotations.Schema;

namespace Tobacco_Shop.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int TobaccoId { get; set; }
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public virtual Tobacco Tobacco { get; set; }
        public virtual Order Order { get; set; }
    }
}
