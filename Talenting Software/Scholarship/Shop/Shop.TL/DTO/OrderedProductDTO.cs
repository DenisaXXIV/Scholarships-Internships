using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.TL.DTO
{
    public class OrderedProductDTO
    {
        public int OrderedProductId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

    }
}
