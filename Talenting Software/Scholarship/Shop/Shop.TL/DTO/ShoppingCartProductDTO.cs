using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.TL.DTO
{
    public class ShoppingCartProductDTO
    {
        public int ShoppingCartProductId { get; set; }
        public int ShoppingCartId { get; set; }
        public int ProductId { get; set; }
    }
}
