using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Interfaces
{
    public interface IRose : IFlower
    {
        public int nrOfPetals { get; set; }
        public bool isThornless { get; set; }
        public bool haveRoundedPetals { get; set; }
    }
}
