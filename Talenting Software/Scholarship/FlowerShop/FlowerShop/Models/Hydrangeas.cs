using FlowerShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Models
{
    internal class Hydrangeas : IHydrangeas
    {
        public string Color { get; set; }
        public int Number { get; set; }
        public float Price { get; set; }
    }
}
