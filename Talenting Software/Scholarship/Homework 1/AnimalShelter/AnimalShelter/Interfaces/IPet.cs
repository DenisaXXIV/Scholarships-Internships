using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.Interfaces
{
    internal interface IPet
    {
        string Name { get; set; }
        int Age { get; set; }
        bool isTrained { get; set; }

        public void Eat();
        public void Play();
        public void Run();
    }
}
