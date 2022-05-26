using AnimalShelter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.Models
{
    internal class Dog : ICanine
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool isTrained { get; set; }

        public string Breed { get; set; }

        public void Bark()
        {

        }

        public void Dig()
        {

        }

        public void Sit()
        {

        }

        public void Eat()
        {

        }

        public void Howl()
        {

        }

        public void Play()
        {

        }

        public void Run()
        {

        }

        public void ShedHair()
        {

        }
    }
}
