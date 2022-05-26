using FlowerShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Models
{
    public class Rose : IRose
    {
        public int nrOfPetals { get; set; }
        public bool isThornless { get; set; }
        public bool haveRoundedPetals { get; set; }
        public string Color { get; set; }
        public int Number { get; set; }
        public float Price { get; set; }
    }
}
