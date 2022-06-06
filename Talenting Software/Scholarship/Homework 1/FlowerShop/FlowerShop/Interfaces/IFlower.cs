using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Interfaces
{
    public interface IFlower
    {
        public string Color { get; set; }
        public int Number { get; set; }
        public float Price { get; set; }
    }
}
