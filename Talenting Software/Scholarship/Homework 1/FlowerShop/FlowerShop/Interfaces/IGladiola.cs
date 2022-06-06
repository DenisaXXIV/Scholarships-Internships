using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Interfaces
{
    public interface IGladiola : IFlower
    {
        public int Height { get; set; }
    }
}
