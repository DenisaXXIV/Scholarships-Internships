using AnimalShelter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.Models
{
    internal class Cat : IFeline
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool isTrained { get; set; }

        public void UseLitterBox()
        {

        }

        public void Meow()
        {

        }

        public void Eat()
        {

        }

        public void Play()
        {

        }

        public void RetractClaws()
        {

        }

        public void Run()
        {

        }

        public void SelfCleaning()
        {

        }
    }
}
