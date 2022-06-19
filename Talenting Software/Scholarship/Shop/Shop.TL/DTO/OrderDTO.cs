using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.TL.DTO
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        public int ClientId { get; set; }
        public string CreatedDate { get; set; }
        public float TotalAmount { get; set; }
        public int Discount { get; set; }
    }
}
