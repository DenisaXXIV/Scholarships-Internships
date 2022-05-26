using FlowerShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Models
{
    internal class Gladiola : IGladiola
    {
        public int Height { get; set; }
        public string Color { get; set; }
        public int Number { get; set; }
        public float Price { get; set; }
    }
}
