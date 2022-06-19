using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Entities
{
    public class ShoppingCartProduct
    {
        [Required]
        [Key]
        public int ShoppingCartProductId { get; set; }

        [Required(ErrorMessage = "*** ShoppingCart Err ***")]
        [ForeignKey("ShoppingCart")]
        public int ShoppingCartId { get; set; }

        [Required(ErrorMessage = "*** Product Err ***")]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
    }
}
