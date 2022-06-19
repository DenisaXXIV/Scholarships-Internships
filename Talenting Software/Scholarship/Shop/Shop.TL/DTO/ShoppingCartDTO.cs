using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.TL.DTO
{
    public class ShoppingCartDTO
    {
        public int ShoppingCartId { get; set; }
        public string TotalAmount { get; set; }
        public bool HasExpired { get; set; }
        public int ClientId { get; set; }
    }
}
